using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Orchestration
{
    public class ProcessDefinitionXml
    {
        public string Id { get; set; }
        public string Bpmn20Xml { get; set; }

        public override string ToString() => $"ProcessDefinitionXml [Id={Id}]";
    }
}
