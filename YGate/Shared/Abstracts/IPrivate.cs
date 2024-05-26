using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGate.Shared.Abstracts
{
    public interface IPrivate
    {
        public string OwnerGuid { get; set; }
    }
}
