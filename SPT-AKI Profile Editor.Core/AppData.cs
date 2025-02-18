﻿using SPT_AKI_Profile_Editor.Core.ProfileClasses;
using SPT_AKI_Profile_Editor.Core.ServerClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace SPT_AKI_Profile_Editor.Core
{
    public static class AppData
    {
        public static readonly AppSettings AppSettings;
        public static readonly AppLocalization AppLocalization;
        public static readonly Profile Profile;
        public static readonly ServerDatabase ServerDatabase;
        public static readonly GridFilters GridFilters;
        public static readonly BackupService BackupService;

        static AppData()
        {
            GridFilters = new();
            AppSettings = new();
            AppSettings.Load();
            BackupService = new();
            AppLocalization = new(AppSettings.Language);
            Profile = new();
            ServerDatabase = new();
        }

        public static void LoadDatabase()
        {
            if (ExtMethods.PathIsServerFolder(AppSettings))
            {
                LoadLocalesGlobal();
                LoadBotTypes();
                LoadServerGlobals();
                LoadTradersInfos();
                LoadQuestsData();
                LoadHideoutAreaInfos();
                LoadItemsDB();
                FindPockets();
                LoadTraderSuits();
                LoadHandbook();
            }
        }

        public static void StartupEvents()
        {
            LoadDatabase();
            Profile.Load(Path.Combine(AppSettings.ServerPath, AppSettings.DirsList["dir_profiles"], AppSettings.DefaultProfile));
            BackupService.LoadBackupsList();
            GridFilters.Clear();
        }

        private static void LoadLocalesGlobal()
        {
            ServerDatabase.LocalesGlobal = new();
            string path = Path.Combine(AppSettings.ServerPath, AppSettings.DirsList["dir_globals"], AppSettings.Language + ".json");
            try
            {
                LocalesGlobal global = JsonSerializer.Deserialize<LocalesGlobal>(File.ReadAllText(path));
                ServerDatabase.LocalesGlobal = global;
            }
            catch (Exception ex) { Logger.Log($"ServerDatabase LocalesGlobal ({path}) loading error: {ex.Message}"); }
        }

        private static void LoadBotTypes()
        {
            Dictionary<string, string> Heads = new();
            Dictionary<string, string> Voices = new();
            foreach (var btype in Directory.GetFiles(Path.Combine(AppSettings.ServerPath, AppSettings.DirsList["dir_bots"])))
            {
                try
                {
                    if (!File.Exists(btype))
                        continue;
                    BotType bot = JsonSerializer.Deserialize<BotType>(File.ReadAllText(btype));
                    if (bot.Appearance.Heads != null)
                        foreach (var head in bot.Appearance.Heads)
                            if (!Heads.ContainsKey(head))
                                Heads.Add(head, ServerDatabase.LocalesGlobal.Customization.ContainsKey(head) ? ServerDatabase.LocalesGlobal.Customization[head].Name : head);
                    if (bot.Appearance.Voices != null)
                        foreach (var voice in bot.Appearance.Voices)
                            if (!Voices.ContainsKey(voice))
                                Voices.Add(voice, voice);
                }
                catch (Exception ex) { Logger.Log($"ServerDatabase BotType ({btype}) loading error: {ex.Message}"); }
            }
            ServerDatabase.Heads = Heads;
            ServerDatabase.Voices = Voices;
        }

        private static void LoadServerGlobals()
        {
            ServerDatabase.ServerGlobals = new();
            string path = Path.Combine(AppSettings.ServerPath, AppSettings.FilesList["file_globals"]);
            try
            {
                ServerGlobals global = JsonSerializer.Deserialize<ServerGlobals>(File.ReadAllText(path));
                ServerDatabase.ServerGlobals = global;
            }
            catch (Exception ex) { Logger.Log($"ServerDatabase ServerGlobals ({path}) loading error: {ex.Message}"); }
        }

        private static void LoadTradersInfos()
        {
            ServerDatabase.TraderInfos = new();
            var traderInfos = new Dictionary<string, TraderBase>();
            foreach (var tbase in Directory.GetDirectories(Path.Combine(AppSettings.ServerPath, AppSettings.DirsList["dir_traders"])))
            {
                if (!File.Exists(Path.Combine(tbase, "base.json")))
                    continue;
                if (Path.GetFileNameWithoutExtension(tbase) == "ragfair")
                    continue;
                try
                {
                    traderInfos.Add(Path.GetFileNameWithoutExtension(tbase), JsonSerializer.Deserialize<TraderBase>(File.ReadAllText(Path.Combine(tbase, "base.json"))));
                }
                catch (Exception ex) { Logger.Log($"ServerDatabase TraderInfo ({tbase}) loading error: {ex.Message}"); }
            }
            ServerDatabase.TraderInfos = traderInfos;
        }

        private static void LoadQuestsData()
        {
            ServerDatabase.QuestsData = new();
            string path = Path.Combine(AppSettings.ServerPath, AppSettings.FilesList["file_quests"]);
            try
            {
                Dictionary<string, QuestData> questsData = JsonSerializer.Deserialize<Dictionary<string, QuestData>>(File.ReadAllText(path));
                ServerDatabase.QuestsData = questsData.ToDictionary(x => x.Value.Id, y => y.Value.TraderId);
            }
            catch (Exception ex) { Logger.Log($"ServerDatabase QuestsData ({path}) loading error: {ex.Message}"); }
        }

        private static void LoadHideoutAreaInfos()
        {
            ServerDatabase.HideoutAreaInfos = new();
            string path = Path.Combine(AppSettings.ServerPath, AppSettings.FilesList["file_areas"]);
            try
            {
                List<HideoutAreaInfo> HideoutAreaInfos = JsonSerializer.Deserialize<List<HideoutAreaInfo>>(File.ReadAllText(path));
                ServerDatabase.HideoutAreaInfos = HideoutAreaInfos;
            }
            catch (Exception ex) { Logger.Log($"ServerDatabase HideoutAreaInfos ({path}) loading error: {ex.Message}"); }
        }

        private static void LoadItemsDB()
        {
            ServerDatabase.ItemsDB = new();
            string path = Path.Combine(AppSettings.ServerPath, AppSettings.FilesList["file_items"]);
            try
            {
                Dictionary<string, TarkovItem> itemsDB = JsonSerializer.Deserialize<Dictionary<string, TarkovItem>>(File.ReadAllText(path));
                ServerDatabase.ItemsDB = itemsDB;
            }
            catch (Exception ex) { Logger.Log($"ServerDatabase ItemsDB ({path}) loading error: {ex.Message}"); }
        }

        private static void FindPockets() => ServerDatabase.Pockets = ServerDatabase.ItemsDB
            .Where(x => x.Value.Parent == AppSettings.PocketsContainerTpl)
            .ToDictionary(x => x.Key, x => GetPocketsName(x.Value));

        private static string GetPocketsName(TarkovItem x) =>
            $"{x.LocalizedName} ({x.GetSlotsCount})";

        private static void LoadTraderSuits()
        {
            ServerDatabase.TraderSuits = new();
            var traderSuits = new List<TraderSuit>();
            foreach (var tbase in Directory.GetDirectories(Path.Combine(AppSettings.ServerPath, AppSettings.DirsList["dir_traders"])))
            {
                try
                {
                    if (!File.Exists(Path.Combine(tbase, "suits.json")))
                        continue;
                    var traderSuitsList = JsonSerializer.Deserialize<List<TraderSuit>>(File.ReadAllText(Path.Combine(tbase, "suits.json")));
                    foreach (var suit in traderSuitsList.Where(x => !traderSuits.Any(y => y.SuiteId == x.SuiteId)))
                        traderSuits.Add(suit);
                }
                catch (Exception ex) { Logger.Log($"ServerDatabase TraderSuits ({tbase}) loading error: {ex.Message}"); }
            }
            ServerDatabase.TraderSuits = traderSuits;
        }

        private static void LoadHandbook()
        {
            string path = Path.Combine(AppSettings.ServerPath, AppSettings.FilesList["file_handbook"]);
            try
            {
                Handbook handbook = JsonSerializer.Deserialize<Handbook>(File.ReadAllText(path));
                ServerDatabase.Handbook = handbook;
            }
            catch (Exception ex)
            {
                ServerDatabase.Handbook = new Handbook(new List<HandbookCategory>(), new List<HandbookItem>());
                Logger.Log($"ServerDatabase Handbook ({path}) loading error: {ex.Message}");
            }
        }
    }
}