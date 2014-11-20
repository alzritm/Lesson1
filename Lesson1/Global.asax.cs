using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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



    public class MvcApplication : HttpApplication
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        protected void Application_Start()
        {
            logger.Info("Application Start");
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IKernel kernel = new StandardKernel();
            kernel.Bind<ISalesService>().To<SalesService>();
            var resolver = new AlzNinjecrDependancyResolver(kernel);
            DependencyResolver.SetResolver(resolver);
        }
        public void Init()
        {
            logger.Info("Application Init");
        }

        public void Dispose()
        {
            logger.Info("Application Dispose");
        }

        protected void Application_Error()
        {
            logger.Info("Application Error");
        }


        protected void Application_End()
        {
            logger.Info("Application End");
        }

        //protected override IKernel CreateKernel()
        //{
        //    var kernel = new StandardKernel();
        //    //kernel.Load(Assembly.GetExecutingAssembly());

        //    //GlobalConfiguration.Configuration.DependencyResolver = new LocalNinjectDependencyResolver(kernel);
        //    kernel.Bind<ISalesService>().To<SalesService>();
        //    DependencyResolver.SetResolver(new AlzNinjecrDependancyResolver(kernel));
        //    return kernel;
        //}
    }
}