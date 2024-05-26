using Microsoft.AspNetCore.Mvc;
using YGate.Server.Abstracts;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Concretes;

namespace YGate.Server.Controllers
{
    [Route("api/[controller]")]
    public class SaleController : GenericController<Sale>
    {
        IGenericDataOperationsBase<Product> _prody;
        IGenericDataOperationsBase<User> _userOperations;
        public SaleController(IGenericDataOperationsBase<Sale> dataSource, IGenericDataOperationsBase<Product> prody, IGenericDataOperationsBase<User> userOperations) : base(dataSource)
        {
            _prody = prody;
            _userOperations = userOperations;
        }

        [HttpGet("[action]")]
        public JsonResult AddSales(int ProductID, int PointID, int Amount, string OwnerGuid)
        {
            var urun = _prody.Get(xd => xd.ID == ProductID);
            var obj = new Sale()
            {
                ProductID = ProductID,
                PointID = PointID,
                SaleTime = DateTime.Now.ToUniversalTime(),
                TicketID = Guid.NewGuid().ToString(),
                Amount = Amount,
                Price = urun.Price * Amount,
                EmployeeID = _userOperations.Get(xd => xd.GID == OwnerGuid).ID,
                OwnerGuid = OwnerGuid,
                ProductName = urun.Name,
                ColorFromHex = "#FFFFFF",
                Discount = 0,
                CustomerID = 0,
                Note = "",
                PayTypeID = 0,
            };
            var result = base.source.Add(obj);
            if (result)
                return Json(new YGate.Shared.Concretes.RequestObject() { Data = obj, Message = "Success", OperationName = "AddSalesWithBasicParameter", Result = true });
            else
                return Json(new YGate.Shared.Concretes.RequestObject() { Data = obj, Message = "Fail", OperationName = "AddSalesWithBasicParameter", Result = false });
        }


        [HttpGet("[action]")]
        public JsonResult GetSalesWithPointID(int PointID)
        {
            List<Sale> returnedSource = this.source.Gets(xd => xd.PointID == PointID).ToList();
            returnedSource.ForEach(x =>
            {
                x.ProductName = _prody.Get(xd => xd.ID == x.ProductID).Name;
            });
            return Json(new YGate.Shared.Concretes.RequestObject() { Data = returnedSource, Message = "Success", OperationName = "GetSalesWithPointID", Result = true });
        }

        [HttpGet("[action]")]
        public JsonResult UrunuTasi(int UrunID, int PointID, string OwnerGuid)
        {
            var obj = this.source.Get(xd => xd.ID == UrunID);

            obj.PointID = PointID;
            obj.Note = $"{OwnerGuid} tarafından taşındı.";
            var result = this.source.Update(obj);

            if (result)
                return Json(new YGate.Shared.Concretes.RequestObject() { Data = obj, Message = "Success", OperationName = "UrunuTasi", Result = true });
            else
                return Json(new YGate.Shared.Concretes.RequestObject() { Data = obj, Message = "Fail", OperationName = "UrunuTasi", Result = false });
        }

        [HttpGet("[action]")]
        public JsonResult MasaninSatislariniTasi(int OldPointID, int NewPointID, string OwnerGuid)
        {
            var obj = this.source.Gets(xd => xd.PointID == OldPointID).ToList();
            List<bool> results = new List<bool>();
            obj.ForEach(xd =>
            {
                xd.PointID = NewPointID;
                results.Add(this.source.Update(xd));
            });
            if (!results.Contains(false))
                return Json(new YGate.Shared.Concretes.RequestObject() { Data = obj, Message = "Success", OperationName = "UrunuTasi", Result = true });
            else
                return Json(new YGate.Shared.Concretes.RequestObject() { Data = obj, Message = "Fail", OperationName = "UrunuTasi", Result = false });
        }

    }
}
