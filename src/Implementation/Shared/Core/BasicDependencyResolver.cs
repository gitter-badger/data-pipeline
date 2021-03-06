﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http.Dependencies;

namespace Microsoft.Practices.DataPipeline
{
    public sealed class BasicDependencyResolver : IDependencyResolver
    {
        public IDependencyScope BeginScope()
        {
            return this;
        }

        public object GetService(Type serviceType)
        {
            return Activator.CreateInstance(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new Object[] {Activator.CreateInstance(serviceType)};
        }

        public void Dispose()
        {
            
        }
    }
}
