using System;
using System.Collections.Generic;
using System.Text;

namespace SOMData.Models
{
    public class Scaffold
    {
        public int ScaffoldId { get; set; }
        public string ModelName { get; set; }
        public string Namespace { get; set; }
        public string SaveDestination { get; set; }
    } 
}
