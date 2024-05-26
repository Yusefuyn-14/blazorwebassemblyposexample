using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Postgresql.Entityframework;
using YGate.Server.Entities;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Concretes;

namespace YGate.Postgresql.Entityframework.Concretes
{
    public class CategoryOperations : OperationsBaseDbSetClass<Category>
    {
        public CategoryOperations()
        {
            base.Source = new MyContext();
        }
    }
}
