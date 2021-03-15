using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemsComparing.Models
{
    public class CompareModel
    {
        public int Position1 { get; set; }
        public int Position2 { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Value1 { get; set; } = 0;
        public int Value2 { get; set; } = 0;
    }
}
