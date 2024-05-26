using Microsoft.AspNetCore.Mvc;
using YGate.Shared.Concretes;

namespace YGate.Server.Controllers
{
    [Route("api/[controller]")]
    public class TokenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("[action]")]
        public JsonResult TokenControl(string Token)
        {
            bool result = LoginTokens.ControlToken(Token);
            if (result)
                return Json(new RequestObject() { Data = "", Message = "Invalid Token", OperationName = "TokenControl", Result = true });
            else
                return Json(new RequestObject() { Data = "", Message = "Invalid token because time out", OperationName = "TokenControl", Result = false });
        }
    }
}
