using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using YGate.Server.Entities;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Abstracts;
using YGate.Shared.Concretes;

namespace YGate.Server.Abstracts
{
    [Route("api/[controller]")]
    public class GenericController<T> : Controller, IGenericControllerOperations<T>
        where T : class, IIndexable, new()
    {
        public IGenericDataOperationsBase<T> source = null;
        public GenericController(IGenericDataOperationsBase<T> dataSource)
        {
            source = dataSource;
        }


        [HttpGet("[action]")]
        public JsonResult Add(T addedobj)
        {
            var returned = source.Add(addedobj);
            return Json(new { OperationName = "Add", Result = true, Data = addedobj });
        }

        [HttpGet("[action]")]
        public JsonResult Delete(T addedobj)
        {
            source.Delete(addedobj);
            return Json(new { OperationName = "Delete", Result = true, Data = addedobj });
        }

        //[HttpGet("[action]")]
        //public JsonResult Get(string pedicableString)
        //{
        //    var predi = JsonConvert.DeserializeObject<Func<T, bool>>(pedicableString);
        //    return Json(new { OperationName = "Get", Result = true, Data = source.Get(xd => xd.ID == Convert.ToInt32(pedicableString)) });
        //}

        //[HttpGet("[action]")]
        //public JsonResult GetAll()
        //{
        //    return Json(new { OperationName = "GetAll", Result = true, Data = source.GetAll() });
        //}

        //[HttpGet("[action]")]
        //public JsonResult Gets(string pedicableString)
        //{
        //    var predi = JsonConvert.DeserializeObject<Func<T, bool>>(pedicableString);
        //    return Json(new { OperationName = "Gets", Result = true, Data = source.Gets(predi) });
        //}

        [HttpGet("[action]")]
        public JsonResult Update(T addedobj)
        {
            var obj = source.Get(xd => xd.ID == addedobj.ID);
            source.Delete(obj);
            source.Add(addedobj);
            return Json(new { OperationName = "Update", Result = true, Data = addedobj });
        }
    }
}
