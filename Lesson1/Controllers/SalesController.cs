using System;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
//using AttributeRouting.Web.Http;
using AttributeRouting.Web.Mvc;
using Ninject;

namespace Lesson1.Controllers
{
    using TestService;
    public class SalesController : BaseController
    {
        [Inject]
        public ISalesService SalesService { private get; set; }

        [GET("api/sales")]
        public JsonResult GetList()
        {
            //if (SalesService == null)
            //{
            //    SalesService = AppKernel.Get<ISalesService>();
            //}
            var records = SalesService.GetList();
            var _total = SalesService.GetNuberSales();
            var data = new 
            {
                status = "success",
                total = _total,
                records
            };

            return Json(data , JsonRequestBehavior.AllowGet);
            //return Request.CreateResponse(HttpStatusCode.OK, new
            //{
            //    data = res,
            //    total = total,
            //    success = true
            //});
        }
        [POST("api/sales")]
        public JsonResult PostList()
        {
            var records = SalesService.GetList();
            var _total = SalesService.GetNuberSales();
            var data = new
            {
                status = "success",
                total = _total,
                records
            };

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
