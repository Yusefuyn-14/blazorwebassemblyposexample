using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Server.Entities;
using YGate.Shared.Concretes;

namespace YGate.Smulate.Concretes
{
    public class RegionOperations : OperationsBaseListClass<Region>
    {
        public RegionOperations()
        {
            this.Source = new List<Region>();
            this.Source.Add(new Region() { Name = "Garden", ColorFromHex = "#FF00FF" });
        }
    }
}
