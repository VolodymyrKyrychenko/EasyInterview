﻿using Autofac;
using Autofac.Extensions.DependencyInjection;
using Infrastructure.Modules;
using Microsoft.Extensions.DependencyInjection;

namespace Web.Infrastructure.DependencyInjection
{
    public static class ConfigurationContainer
    {
        public static IContainer SetupConfigurationContainer(this IServiceCollection services)
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterModule<DataAccessModule>();
            containerBuilder.RegisterModule<ServicesModule>();
            containerBuilder.RegisterModule<CommonModule>();

            containerBuilder.Populate(services);

            var container = containerBuilder.Build();

            return container;
        }
    }
}
