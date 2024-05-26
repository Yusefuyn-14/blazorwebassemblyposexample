using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Server.Entities;
using YGate.Shared.Concretes;

namespace YGate.Smulate.Concretes
{
    public class SaleOperations : OperationsBaseListClass<Sale>
    {
        public SaleOperations()
        {
            this.Source = new List<Sale>();
            this.Source.Add(new Sale()
            {
                Price = 3,
                ProductID = 1,
                EmployeeID = 1,
                CustomerID = 1,
                PointID = 1,
                SaleTime = DateTime.Now.AddDays(-3),
                PayTypeID = 1,
                Amount = 1,
                TicketID = Guid.NewGuid().ToString(),
                Note = "Manyak herif bir fantaya 13 adet pipet aldı."
            });

            string ticketID = Guid.NewGuid().ToString();
            this.Source.Add(new Sale()
            {
                Price = 3,
                ProductID = 1,
                TicketID = ticketID,
                EmployeeID = 1,
                CustomerID = 1,
                PointID = 1,
                SaleTime = DateTime.Now,
                Amount = 1,
            });
            this.Source.Add(new Sale()
            {
                Price = 8,
                ProductID = 4,
                TicketID = ticketID,
                EmployeeID = 1,
                Discount = 1.5,
                CustomerID = 1,
                PointID = 1,
                SaleTime = DateTime.Now,
                Amount = 1,
            });
        }
    }
}
