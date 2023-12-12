using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.ServiceExtensions
{
    public static class MassTransitConfiguration
    {
        // RabbitMQ MassTransit
        public static IServiceCollection AddMassTransitWithRabbitMQProvider(this IServiceCollection services)
        {
            // MassTransit-RabbitMQ Configuration
            services.AddMassTransit(config => {
                config.UsingRabbitMq((ctx, rabbit) => {
                    rabbit.Host(GlobalConnectionStrings.RabbitMQ_Connection);
                    rabbit.ConfigureEndpoints(ctx);
                });
            });

            return services;
        }

        public static IServiceCollection AddMassTransitEstateConsumer(this IServiceCollection services)
        {
            services.AddMassTransit(config => {
                config.AddConsumer<EstateConsumer>();

                config.UsingRabbitMq((ctx, rabbit) => {
                    rabbit.Host(GlobalConnectionStrings.RabbitMQ_Connection);
                    rabbit.ConfigureEndpoints(ctx);

                    rabbit.ReceiveEndpoint(EventBusConstants.EstatesQueue, c => {
                        c.ConfigureConsumer<EstateConsumer>(ctx);
                    });
                });
            });

            return services;
        }
    }
}
