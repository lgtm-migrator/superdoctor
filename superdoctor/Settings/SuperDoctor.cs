﻿using Newtonsoft.Json;
using System.ComponentModel;

namespace superdoctor.Settings
{
    class SuperDoctor
    {
        [DefaultValue(@"C:\Program Files\Supermicro\SuperDoctor5\sdc.bat")]
        [JsonProperty(PropertyName = "path", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Path { get; set; }
    }
}
