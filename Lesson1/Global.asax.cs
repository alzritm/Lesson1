using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Mvc;
using TestService;

namespace Lesson1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801



    public class MvcApplication : NinjectHttpApplication
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                });
        }
        //public AlzNinjecrDependancyResolver resolver;
        //protected void Application_Start()
        //{
        //    logger.Info("Application Start");
        //    AreaRegistration.RegisterAllAreas();

        //    WebApiConfig.Register(GlobalConfiguration.Configuration);
        //    FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        //    RouteConfig.RegisterRoutes(RouteTable.Routes);
        //    BundleConfig.RegisterBundles(BundleTable.Bundles);

        //    IKernel kernel = new StandardKernel();
        //    kernel.Bind<ISalesService>().To<SalesService>();
        //    resolver = new AlzNinjecrDependancyResolver(kernel);
        //    DependencyResolver.SetResolver(resolver);
        //}
        //public void Init()
        //{
        //    logger.Info("Application Init");
        //}

        //public void Dispose()
        //{
        //    logger.Info("Application Dispose");
        //}

        //protected void Application_Error()
        //{
        //    logger.Info("Application Error");
        //}


        //protected void Application_End()
        //{
        //    logger.Info("Application End");
        //}
        protected override void OnApplicationStarted()
        {
            logger.Info("Application Started");
            base.OnApplicationStarted();
            AreaRegistration.RegisterAllAreas();

            //AttributeRoutingConfig.RegisterRoutes(GlobalConfiguration.Configuration.Routes);
            //WebApiConfig.Register(GlobalConfiguration.Configuration);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }

        protected override IKernel CreateKernel()
        {
            //var kernel = new StandardKernel();

            //DependencyResolver.SetResolver(new AlzNinjecrDependancyResolver(kernel));
            //return kernel;

            var kernel = new StandardKernel();
            kernel.Bind<ISalesService>().To<SalesService>();
            kernel.Load(Assembly.GetExecutingAssembly());
            //kernel.Bind<DbConnection>().ToSelf().InRequestScope();

            //kernel.Bind<IPrincipal>().ToMethod(ctx => HttpContext.Current.User).InRequestScope();
            //GlobalConfiguration.Configuration.DependencyResolver = new AlzNinjecrDependancyResolver(kernel);
            return kernel;
        }

        //protected override IKernel CreateKernel()
        //{
        //    throw new NotImplementedException();
        //}
    }
}