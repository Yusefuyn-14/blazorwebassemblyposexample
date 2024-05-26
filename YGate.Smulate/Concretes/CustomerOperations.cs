using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Server.Entities;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Concretes;
using YGate.Smulate.Abstracts;

namespace YGate.Smulate.Concretes
{
    public class IndividualCustomerOperations : OperationsBaseListClass<IndividualCustomer>
    {
        public IndividualCustomerOperations()
        {
            this.Source = new List<IndividualCustomer>();
            this.Source.Add(new IndividualCustomer()
            {
                Name = "Yusuf",
                Phone = "+90539 235 04 48",
                BirthDate = DateTime.Now,
                BirthPlace = "Here",
                Surname = "KIDIR"
            });
        }
    }


    public class CorporateCustomerOperations : OperationsBaseListClass<CorporateCustomer>
    {
        public CorporateCustomerOperations()
        {
            this.Source = new List<CorporateCustomer>();
            this.Source.Add(new CorporateCustomer() {
                Address = "Here",
                CompanyType = "",
                Name = "Yusefuyn Software INC",
                Phone = "+90252 252 52 52",
                TaxNo = "4555223232A1"
            });
        }
    }
}
