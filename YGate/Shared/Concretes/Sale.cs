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
    public class Sale : IIndexable, IColorizable, IPrivate
    {
        public string OwnerGuid { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string TicketID { get; set; }
        public int ProductID { get; set; }
        [NotMapped]
        public string ProductName { get; set; }
        public int PointID { get; set; }
        public int? CustomerID { get; set; }
        public int? EmployeeID { get; set; } 
        public int? PayTypeID { get; set; }
        public double? Price { get; set; }
        public double? Discount { get; set; }
        public double Amount { get; set; } = 1;
        public DateTime SaleTime { get; set; } = DateTime.Now;
        public string? Note { get; set; }
        [NotMapped]
        public string ColorFromHex { get; set; } = "#0F0";

        [NotMapped]
        public string SelectedID { get; set; } = Guid.NewGuid().ToString();
    }
}
