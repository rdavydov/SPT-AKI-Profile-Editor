﻿using System.Collections.Generic;

namespace SPT_AKI_Profile_Editor.Core.ServerClasses
{
    public class ServerDatabase : BindableEntity
    {
        private Dictionary<string, string> heads;

        private Dictionary<string, string> voices;

        private LocalesGlobal localesGlobal;

        private ServerGlobals serverGlobals;

        private Dictionary<string, TraderBase> traderInfos;

        private Dictionary<string, string> questsData;

        private List<HideoutAreaInfo> hideoutAreaInfos;

        private Dictionary<string, TarkovItem> itemsDB;

        private Dictionary<string, string> pockets;

        private List<TraderSuit> traderSuits;

        private Handbook handbook;

        public Dictionary<string, string> Heads
        {
            get => heads;
            set
            {
                heads = value;
                OnPropertyChanged("Heads");
            }
        }

        public Dictionary<string, string> Voices
        {
            get => voices;
            set
            {
                voices = value;
                OnPropertyChanged("Voices");
            }
        }

        public LocalesGlobal LocalesGlobal
        {
            get => localesGlobal;
            set
            {
                localesGlobal = value;
                OnPropertyChanged("LocalesGlobal");
            }
        }

        public ServerGlobals ServerGlobals
        {
            get => serverGlobals;
            set
            {
                serverGlobals = value;
                OnPropertyChanged("ServerGlobals");
            }
        }

        public Dictionary<string, TraderBase> TraderInfos
        {
            get => traderInfos;
            set
            {
                traderInfos = value;
                OnPropertyChanged("TraderInfos");
            }
        }

        public Dictionary<string, string> QuestsData
        {
            get => questsData;
            set
            {
                questsData = value;
                OnPropertyChanged("QuestsData");
            }
        }

        public List<HideoutAreaInfo> HideoutAreaInfos
        {
            get => hideoutAreaInfos;
            set
            {
                hideoutAreaInfos = value;
                OnPropertyChanged("HideoutAreaInfos");
            }
        }

        public Dictionary<string, TarkovItem> ItemsDB
        {
            get => itemsDB;
            set
            {
                itemsDB = value;
                OnPropertyChanged("ItemsDB");
                OnPropertyChanged("ItemsForAdding");
            }
        }

        public Dictionary<string, string> Pockets
        {
            get => pockets;
            set
            {
                pockets = value;
                OnPropertyChanged("Pockets");
            }
        }

        public List<TraderSuit> TraderSuits
        {
            get => traderSuits;
            set
            {
                traderSuits = value;
                OnPropertyChanged("TraderSuits");
            }
        }

        public Handbook Handbook
        {
            get => handbook;
            set
            {
                handbook = value;
                OnPropertyChanged("Handbook");
            }
        }

        public void SetAllTradersMax()
        {
            foreach (var trader in TraderInfos.Values)
                trader.Level = trader.MaxLevel;
        }

        public void AcquireAllClothing()
        {
            foreach (var suit in TraderSuits)
                suit.Boughted = true;
        }
    }
}