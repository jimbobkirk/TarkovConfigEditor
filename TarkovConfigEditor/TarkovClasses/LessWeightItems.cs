
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TarkovConfigEditor.TarkovClasses
{
    public class LessWeightItems
    {
        public string name { get; set; }
        public string author { get; set; }
        public string description { get; set; }
        public string license { get; set; }
        public string version { get; set; }
        public Src src { get; set; }
        public List<object> required { get; set; }
        public Configuration configuration { get; set; }

        public class Configuration
        {
            public bool NoWeight { get; set; }
            public bool ClampWeight { get; set; }
            public int ClampWeightAbove { get; set; }
        }

        public class Src
        {
            [JsonProperty("src/LessWeightItems.js")]
            public string SrcLessWeightItemsJs { get; set; }
        }

    }
}