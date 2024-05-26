using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Shared.Abstracts;

namespace YGate.Server.Entities.Abstracts
{
    public interface IGenericDataOperationsBase<T>
        where T : class, IIndexable, new()
    {
        public T Get(Func<T, bool> predicable);
        public IEnumerable<T> GetAll();
        public IEnumerable<T> Gets(Func<T, bool> predicable);
        public bool Add(T addedobj);
        public bool Delete(T addedobj);
        public bool Update(T addedobj);
    }
}
