using Microsoft.AspNetCore.Mvc;
using YGate.Server.Abstracts;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Concretes;

namespace YGate.Server.Controllers
{
    public class PayTypeController : GenericController<PayType>
    {
        public PayTypeController(IGenericDataOperationsBase<PayType> dataSource) : base(dataSource)
        {
        }

    }
}
