using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Server.Entities;
using YGate.Shared.Concretes;

namespace YGate.Smulate.Concretes
{
    public class PayTypeOperations : OperationsBaseListClass<PayType>
    {
        public PayTypeOperations()
        {
            this.Source = new List<PayType>();
            this.Source.Add(new PayType() { Name = "Cash", ColorFromHex = "#FFFFFF" });
            this.Source.Add(new PayType() { Name = "Credit Card", ColorFromHex = "#FFFFFF" });
        }
    }
}
