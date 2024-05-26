using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Abstracts;

namespace YGate.Server.Entities
{
    public class OperationsBaseDbSetClass<T> : IDataDbSetSourceBase<T>, IGenericDataOperationsBase<T>, IPostgresql, IEntityFramework
        where T : class, IIndexable, new()
    {
        public DbContext Source { get; set; }

        public bool Add(T addedobj)
        {
            try
            {
                addedobj.ID = Source.Set<T>().Count() + 1;
                Source.Set<T>().Add(addedobj);
                Source.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(T addedobj)
        {
            try
            {
                Source.Set<T>().Remove(addedobj);
                Source.SaveChanges();
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
                return Source.Set<T>().FirstOrDefault(predicable);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return Source.Set<T>().Where(xd => xd.ID != -1);
            }
            catch (Exception)
            {
                return default;
            }
        }

        public IEnumerable<T> Gets(Func<T, bool> predicable)
        {
            try
            {
                return Source.Set<T>().Where(predicable);
            }
            catch (Exception)
            {
                return default;
            }
        }

        public bool Update(T addedobj)
        {
            try
            {
                Source.Set<T>().Update(addedobj);
                Source.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
