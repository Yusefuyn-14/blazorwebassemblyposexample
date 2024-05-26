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
    public class Point : IIndexable, IMarkable, IPrivate
    {
        public string OwnerGuid { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public int RegionID { get; set; }
        [NotMapped]
        public double Price { get; set; } = 0.0;
        [NotMapped]
        public DateTime? LastProcessTime { get; set; }
    }
}
