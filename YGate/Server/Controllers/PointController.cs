using Microsoft.AspNetCore.Mvc;
using YGate.Server.Abstracts;
using YGate.Server.Entities.Abstracts;
using YGate.Shared.Concretes;

namespace YGate.Server.Controllers
{
    public class PointController : GenericController<Point>
    {
        IGenericDataOperationsBase<Sale> _salesdata = null;
        public PointController(IGenericDataOperationsBase<Point> dataSource, IGenericDataOperationsBase<Sale> salesdata) : base(dataSource)
        {
            _salesdata = salesdata;
        }

        [HttpGet("[action]")]
        public JsonResult GetPointForRegionID(int RegionID)
        {
            var result = source.Gets(xd => xd.RegionID == RegionID)
               .GroupJoin(_salesdata.Gets(xd => xd.PayTypeID == 0), p => p.ID, s => s.PointID, (p, saleGroup) => new Point
               {
                   ID = p.ID,
                   Name = p.Name,
                   OwnerGuid = p.OwnerGuid,
                   Price = (double)saleGroup.Select(xd => xd.Price).Sum(),
                   LastProcessTime = saleGroup != null && saleGroup.Count() > 0 ? saleGroup.Select(xd => xd.SaleTime).Max() : null,
                   RegionID = p.RegionID
               })
                .ToList();



            return Json(new RequestObject()
            {
                Message = "Success",
                OperationName = "GetPointForRegionID",
                Result = true,
                Data = result
            });
        }

        [HttpGet("[action]")]
        public JsonResult AddPointWithBasicParameter(int RegionID, string Name)
        {
            var addedobj = new Point { RegionID = RegionID, Name = Name };
            var result = source.Add(addedobj);
            if (result)
                return Json(new RequestObject()
                {
                    Message = "Success",
                    OperationName = "AddPointWithBasicParameter",
                    Result = true,
                    Data = addedobj
                });
            else
                return Json(new RequestObject()
                {
                    Message = "Fail",
                    OperationName = "AddPointWithBasicParameter",
                    Result = false,
                    Data = addedobj
                });
        }
    }
}
