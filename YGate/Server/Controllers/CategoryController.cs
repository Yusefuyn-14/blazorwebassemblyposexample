using Microsoft.AspNetCore.Mvc;
using YGate.Server.Abstracts;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Concretes;

namespace YGate.Server.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : GenericController<Category>
    {
        public CategoryController(IGenericDataOperationsBase<Category> dataSource) : base(dataSource)
        {
        }

        [HttpGet("[action]")]
        public JsonResult GetCategoryFromOwnerGuid(string OwnerGuid)
        {
            if (string.IsNullOrEmpty(OwnerGuid))
                return Json(new RequestObject() { Data = "", Message = "Failed because invalid or empty ownerguid", OperationName = $"GetCategoryFromOwnerGuid:{OwnerGuid}:{DateTime.Now}:Failed", Result = false });

            var returnedData = this.source.Gets(xd=> xd.OwnerGuid == OwnerGuid);
            return Json(new RequestObject() { Data = returnedData, Message = "Success", OperationName = $"GetCategoryFromOwnerGuid:{OwnerGuid}:{DateTime.Now}:Success", Result = true });
        }
    }
}
