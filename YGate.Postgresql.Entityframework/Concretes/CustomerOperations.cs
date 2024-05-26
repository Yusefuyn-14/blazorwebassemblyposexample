using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Postgresql.Entityframework;
using YGate.Server.Entities;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Concretes;


namespace YGate.Postgresql.Entityframework.Concretes
{
    public class IndividualCustomerOperations : OperationsBaseDbSetClass<IndividualCustomer>
    {
        public IndividualCustomerOperations()
        {
            base.Source = new MyContext();
        }
    }



    public class CorporateCustomerOperations : OperationsBaseDbSetClass<CorporateCustomer>
    {
        public CorporateCustomerOperations()
        {
            base.Source = new MyContext();
        }
    }
}
