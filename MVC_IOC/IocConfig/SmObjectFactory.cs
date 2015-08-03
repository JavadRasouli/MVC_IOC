﻿using System;
using System.Threading;
using Service;
using StructureMap;

namespace MVC_IOC.IocConfig
{
    public static class SmObjectFactory
    {
        private static readonly Lazy<Container> _containerBuilder =
            new Lazy<Container>(defaultContainer, LazyThreadSafetyMode.ExecutionAndPublication);

        public static IContainer Container
        {
            get { return _containerBuilder.Value; }
        }

        private static Container defaultContainer()
        {
            return new Container(x =>
            {
                x.For<IWebClientServices>().Use<WebClientServices>();
            });
        }
    }
}