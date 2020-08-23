using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOMData.Models
{
    [JsonObject(NamingStrategyType = typeof(DefaultNamingStrategy))]
    public class CodeTemplate
    {
        public int TemplateID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; } 
        public string Type { get; set; }
    }
}
