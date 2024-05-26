using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Postgresql.Entityframework;
using YGate.Server.Entities;
using YGate.Shared.Concretes;

namespace YGate.Postgresql.Entityframework.Concretes
{
    public class PayTypeOperations : OperationsBaseDbSetClass<PayType>
    {
        public PayTypeOperations()
        {
            base.Source = new MyContext();
        }
    }
}
