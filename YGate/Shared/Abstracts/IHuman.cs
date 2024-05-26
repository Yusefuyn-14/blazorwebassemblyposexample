using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGate.Shared.Abstracts
{
    public interface IHuman
    {
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Surname { get; set; }
    }
}
