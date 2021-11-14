﻿using NUnit.Framework;
using SPT_AKI_Profile_Editor.Core;
using SPT_AKI_Profile_Editor.Core.ServerClasses;
using System.Collections.Generic;

namespace SPT_AKI_Profile_Editor.Tests
{
    class ServerDatabaseTests
    {
        [OneTimeSetUp]
        public void Setup()
        {
            AppData.AppSettings.ServerPath = @"C:\SPT";
            AppData.LoadDatabase();
        }

        [Test]
        public void BotTypesHeadsNotEmpty() => Assert.AreNotEqual(new Dictionary<string, string>(), AppData.ServerDatabase.Heads);
        [Test]
        public void BotTypesHeadsNotNull() => Assert.IsNotNull(AppData.ServerDatabase.Heads);

        [Test]
        public void BotTypesVoicesNotEmpty() => Assert.AreNotEqual(new Dictionary<string, string>(), AppData.ServerDatabase.Voices);

        [Test]
        public void BotTypesVoicesNotNull() => Assert.IsNotNull(AppData.ServerDatabase.Voices);

        [Test]
        public void LocalesGlobalNotNull() => Assert.IsNotNull(AppData.ServerDatabase.LocalesGlobal);

        [Test]
        public void LocalesGlobalTradingNotEmpty() => Assert.AreNotEqual(new Dictionary<string, LocalesGlobalTrading>(), AppData.ServerDatabase.LocalesGlobal.Trading);

        [Test]
        public void LocalesGlobalTemplatesNotEmpty() => Assert.AreNotEqual(new Dictionary<string, LocalesGlobalTemplate>(), AppData.ServerDatabase.LocalesGlobal.Templates);

        [Test]
        public void LocalesGlobalCustomizationNotEmpty() => Assert.AreNotEqual(new Dictionary<string, LocalesGlobalTemplate>(), AppData.ServerDatabase.LocalesGlobal.Customization);

        [Test]
        public void LocalesGlobalQuestNotEmpty() => Assert.AreNotEqual(new Dictionary<string, LocalesGlobalQuest>(), AppData.ServerDatabase.LocalesGlobal.Quests);

        [Test]
        public void ServerGlobalsNotNull() => Assert.IsNotNull(AppData.ServerDatabase.ServerGlobals);

        [Test]
        public void ServerGlobalsConfigExpLevelExpTableNotEmpty() => Assert.AreNotEqual(System.Array.Empty<LevelExpTable>(), AppData.ServerDatabase.ServerGlobals.Config.Exp.Level.ExpTable);
        
        [Test]
        public void TraderInfosNotEmpty() => Assert.AreNotEqual(new Dictionary<string, TraderBase>(), AppData.ServerDatabase.TraderInfos);

        [Test]
        public void TraderInfosNotNul() => Assert.IsNotNull(AppData.ServerDatabase.TraderInfos);

        [Test]
        public void QuestsDataNotNul() => Assert.IsNotNull(AppData.ServerDatabase.QuestsData);

        [Test]
        public void QuestsDataNotEmpty() => Assert.AreNotEqual(new Dictionary<string, string>(), AppData.ServerDatabase.QuestsData);
    }
}