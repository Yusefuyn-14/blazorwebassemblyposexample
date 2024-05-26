using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Shared.Abstracts;

namespace YGate.Shared.Concretes
{
    public class Customer : IIndexable, IMarkable, IPrivate
    {
        public string OwnerGuid { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }

    public class IndividualCustomer : Customer, IHuman
    {
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Surname { get; set; }
    }

    public class CorporateCustomer : Customer
    {
        public string CompanyType { get; set; }
        public string Address { get; set; }
        public string TaxNo { get; set; }
    }
}
