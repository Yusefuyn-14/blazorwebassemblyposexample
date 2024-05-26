
using Microsoft.AspNetCore.Mvc;
using YGate.Server.Abstracts;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Concretes;

namespace YGate.Server.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : GenericController<User>
    {

        IGenericDataOperationsBase<User> useroperations = null;

        public LoginController(IGenericDataOperationsBase<User> userop) : base(userop)
        {
            useroperations = userop;
        }


        [HttpGet("[action]")]
        public JsonResult LoginWithUsernameOrMailAndPassword(string kom, string pass)
        {
            User user = useroperations.Get(xd => xd.UserName == kom || xd.Email == kom && xd.Password == YGate.Utils.SHA256Hash.Hashed(pass));
            if (user != null)
            {
                var token = new ProcessToken()
                {
                    Token = Guid.NewGuid().ToString(),
                    ValidTime = DateTime.Now.AddMinutes(60),
                    GID = user.GID
                };
                LoginTokens.AddToken(token);
                return Json(new RequestObject()
                {
                    Data = token,
                    Message = "Success",
                    OperationName = "LoginWithUsernameOrMailAndPassword",
                    Result = true
                });
            }
            else
                return Json(new RequestObject()
                {
                    Data = null,
                    Message = "Not Login But Incorected Username or Password",
                    OperationName = "LoginWithUsernameOrMailAndPassword",
                    Result = false
                });
        }
    }
}
