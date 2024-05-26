using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Shared.Abstracts;

namespace YGate.Server.Entities.Abstracts
{
    public interface IDataDbSetSourceBase<T>
        where T : class, IIndexable, new()
    {
        public DbContext Source { get; set; }
    }
}
