using System.Reflection;
using System.Web.Routing;
using AttributeRouting;
using AttributeRouting.Web.Mvc;
using Lesson1.Controllers;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Lesson1.AttributeRoutingConfig), "Start")]

namespace Lesson1 
{
    public static class AttributeRoutingConfig
	{
		public static void RegisterRoutes(RouteCollection routes) 
		{    
			// See http://github.com/mccalltd/AttributeRouting/wiki for more options.
			// To debug routes locally using the built in ASP.NET development server, go to /routes.axd

            routes.MapAttributeRoutes(config =>
            {
                config.ScanAssembly(Assembly.GetExecutingAssembly());
                config.AddRoutesFromControllersOfType<BaseController>();
                config.AddRoutesFromController<HomeController>();
            });
		}

        public static void Start() 
		{
            RegisterRoutes(RouteTable.Routes);
        }
    }
}
