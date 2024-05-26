using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Server.Entities;
using YGate.Shared.Concretes;

namespace YGate.Smulate.Concretes
{
    public class EmployeeOperations : OperationsBaseListClass<Employee>
    {
        public EmployeeOperations()
        {
            this.Source = new List<Employee>();
            this.Source.Add(new Employee() {
                BirthDate = DateTime.Now,
                BirthPlace = "Here",
                Name = "Yusuf",
                Surname = "KIDIR"
            });
        }
    }
}
