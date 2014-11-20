using System;
using System.Web;
using System.Web.Mvc;
using Ninject;
using AttributeRouting.Web.Http;//Install-Package AttributeRouting.Core.Http
namespace Lesson1.Controllers
{
    using TestService;


    public class HomeController : Controller
    {
        [Inject]
        public ISalesService SalesService { private get; set; }
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var cookie = new HttpCookie("ZolotovKok")
            {
                Domain = "localhost",
                Expires = new DateTime(2020, 1, 1),
                HttpOnly = false,
                Name = "Zolotov-Kok",
            };
            var listForTable = SalesService.GetList();
            Response.SetCookie(cookie);
            return View(listForTable);
            //return View();
        }



    }
}
