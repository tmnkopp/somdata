using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOMData.Models
{
    [JsonObject(NamingStrategyType = typeof(DefaultNamingStrategy))]
    public class ConsoleCommand
    {
        public int ConsoleCommandID { get; set; }
        public string CommandLine { get; set; }
        public string CommandAssembly { get; set; }
        public string CommandType { get; set; }
        public string InstanceType { get; set; }
        public DateTime CommandDate { get; set; } 
    } 
}
