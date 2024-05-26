using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Server.Entities;
using YGate.Shared.Concretes;

namespace YGate.Smulate.Concretes
{
    public class CategoryOperations : OperationsBaseListClass<Category>
    {
        public CategoryOperations()
        {
            this.Source = new List<Category>();
            this.Source.Add(new Category() { ColorFromHex = "#FFFFFF", Name = "Drinks" });
            this.Source.Add(new Category() { ColorFromHex = "#FFFFFF", Name = "Pizza" });
            this.Source.Add(new Category() { ColorFromHex = "#FFFFFF", Name = "Breakfast" });
            this.Source.Add(new Category() { ColorFromHex = "#FFFFFF", Name = "Doner" });
        }
    }
}
