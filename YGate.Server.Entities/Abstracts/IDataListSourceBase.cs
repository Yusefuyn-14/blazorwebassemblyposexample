using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Shared.Abstracts;

namespace YGate.Server.Entities.Abstracts
{
    public interface IDataListSourceBase<T>
        where T : class, IIndexable, new()
    {
        public IList<T> Source { get; set; }
    }
}
