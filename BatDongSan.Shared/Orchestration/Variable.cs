using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Orchestration
{
    public class Variable
    {
        // lower case to generate JSON
        public string Type { get; set; }
        public object Value { get; set; }
        public object ValueInfo { get; set; }
    }
}
