﻿using Newtonsoft.Json;

namespace SPT_AKI_Profile_Editor.Core.ProfileClasses
{
    public class CharacterHideout : BindableEntity
    {
        private HideoutArea[] areas;

        [JsonProperty("Areas")]
        public HideoutArea[] Areas
        {
            get => areas;
            set
            {
                areas = value;
                OnPropertyChanged("Areas");
            }
        }
    }
}