using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Ninject;
using Ninject.Parameters;
using Ninject.Syntax;
using IDependencyResolver = System.Web.Mvc.IDependencyResolver;

namespace Lesson1
{
    public class AlzNinjecrDependancyResolver :  System.Web.Http.Dependencies.IDependencyResolver
    {
        private IKernel _kernel;

        public AlzNinjecrDependancyResolver(IKernel kernel)
        {
            _kernel = kernel;
        }


        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType, new IParameter[0]);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType, new IParameter[0]);
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }


        public void Dispose()
        {
            //_kernel.Dispose();
        }

    }
}