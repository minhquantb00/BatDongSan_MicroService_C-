﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Orchestration
{
    public class ExternalTaskWorkerInfo
    {
        public int Retries { get; set; }
        public long RetryTimeout { get; set; }
        public Type Type { get; set; }
        public string TopicName { get; set; }
        public List<string> VariablesToFetch { get; set; }
        //public IExternalTaskAdapter TaskAdapter { get; set; }
    }
}
