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
    public class Product : IIndexable, IMarkable, IColorizable, IPrivate
    {
        public string OwnerGuid { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string ColorFromHex { get; set; } = "#FFFFFF";
        public int CategoryID { get; set; }
        public double Price { get; set; }
    }
}
