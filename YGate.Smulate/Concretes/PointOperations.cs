using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Server.Entities;
using YGate.Shared.Concretes;

namespace YGate.Smulate.Concretes
{
    public class PointOperations : OperationsBaseListClass<Point>
    {
        public PointOperations()
        {
            this.Source = new List<Point>();
            this.Source.Add(new Point(){ Name = "Table 1", RegionID = 0 });
            this.Source.Add(new Point(){ Name = "Table 2", RegionID = 0 });
            this.Source.Add(new Point(){ Name = "Table 3", RegionID = 0 });
            this.Source.Add(new Point(){ Name = "Table 4", RegionID = 0 });
            this.Source.Add(new Point(){ Name = "Table 5", RegionID = 0 });
            this.Source.Add(new Point(){ Name = "Table 6", RegionID = 0 });
            this.Source.Add(new Point(){ Name = "Table 7", RegionID = 0 });
            this.Source.Add(new Point(){ Name = "Table 8", RegionID = 0 });
            this.Source.Add(new Point(){ Name = "Table 9", RegionID = 0 });
            this.Source.Add(new Point(){ Name = "Table 10", RegionID = 0 });
        }
    }
}
