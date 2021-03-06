﻿using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependenciesContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddTransient(IEventBus, RabbitMQBus);
        }
    }
}
