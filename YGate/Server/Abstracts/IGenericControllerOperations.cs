using Microsoft.AspNetCore.Mvc;
using YGate.Shared.Abstracts;

namespace YGate.Server.Abstracts
{
    public interface IGenericControllerOperations<T>
          where T : class, IIndexable, new()
    {

        //public JsonResult Get(string pedicableString);
        //public JsonResult GetAll();
        //public JsonResult Gets(string pedicableString);
        public JsonResult Add(T addedobj);
        public JsonResult Delete(T addedobj);
        public JsonResult Update(T addedobj);
    }
}
