using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Abstracts;

namespace YGate.Server.Entities
{
    public class OperationsBaseListClass<T> : IDataListSourceBase<T>, IGenericDataOperationsBase<T>
        where T : class, IIndexable, new()
    {
        public IList<T> Source { get; set; }
        public OperationsBaseListClass()
        {
            Source = new List<T>();
        }

        public bool Add(T addedobj)
        {
            try
            {
                addedobj.ID = Source.Count + 1;
                Source.Add(addedobj);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T addedobj)
        {
            try
            {
                Source.Remove(addedobj);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T? Get(Func<T, bool> predicable)
        {
            try
            {
                return Source.FirstOrDefault(predicable);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return Source;
        }

        public IEnumerable<T> Gets(Func<T, bool> predicable)
        {
            return Source.Where(predicable);
        }

        public bool Update(T addedobj)
        {
            try
            {
                T obj = Source.FirstOrDefault(xd => xd.ID == addedobj.ID);
                if (obj == null) return false;
                Source.Remove(obj);
                Source.Add(addedobj);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
