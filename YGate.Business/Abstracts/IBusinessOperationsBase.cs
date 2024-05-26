using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Abstracts;

namespace YGate.Business.Abstracts
{
    public interface IBusinessOperationsBase<T> : IGenericDataOperationsBase<T>
        where T: class, IIndexable, new()
    {
    }
}
