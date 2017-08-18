using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Web.Mvc;
using Unity.Mvc3;
namespace DI.Models
{
    public class ObjectFactory
    {
        private static IUnityContainer container = null;
        public ObjectFactory()
        {
            container = new UnityContainer().LoadConfiguration();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        public static IUnityContainer Container
        {
            get
            {
                container = GetContainer();
                return container;
            }
            set
            {
                container = value;
            }
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        private static IUnityContainer GetContainer()
        {
            var container = new UnityContainer().LoadConfiguration();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
    }
}