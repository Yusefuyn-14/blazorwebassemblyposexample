using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Server.Entities;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Concretes;

namespace YGate.Smulate.Concretes
{
    public class ProductOperations : OperationsBaseListClass<Product>
    {
        public ProductOperations()
        {
            this.Source = new List<Product>();
            this.Source.Add(new Product() { CategoryID = 1, Name = "Fanta", Price = 3.0 });
            this.Source.Add(new Product() { CategoryID = 1, Name = "Cola", Price = 3.0 });
            this.Source.Add(new Product() { CategoryID = 2, Name = "Mixed Pizza", Price = 8.0 });
            this.Source.Add(new Product() { CategoryID = 2, Name = "Chicken Pizza", Price = 8.0 });
            this.Source.Add(new Product() { CategoryID = 3, Name = "Turkish Breakfast", Price = 8.0 });
            this.Source.Add(new Product() { CategoryID = 3, Name = "English Breakfast", Price = 8.0 });
        }
    }
}
