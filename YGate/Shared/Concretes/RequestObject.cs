﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGate.Shared.Concretes
{
    public class RequestObject
    {
        public string OperationName { get; set; }
        public string Message { get; set; }
        public bool Result { get; set; }
        public object Data { get; set; }
    }
}
