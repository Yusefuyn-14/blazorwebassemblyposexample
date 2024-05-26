using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using YGate.Server.Abstracts;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Concretes;

namespace YGate.Server.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : GenericController<Product>
    {
        public ProductController(IGenericDataOperationsBase<Product> dataSource) : base(dataSource)
        {
        }

        [HttpGet("[action]")]
        public JsonResult GetProductWithCategoryID(int ID)
        {
            return Json(new RequestObject() { Data = base.source.Gets(xd => xd.CategoryID == ID), Message = "Success", OperationName = "GetProductWithCategoryID", Result = true });
        }
    }
}
