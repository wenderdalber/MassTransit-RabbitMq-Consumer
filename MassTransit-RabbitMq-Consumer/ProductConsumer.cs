using MassTransit;
using MassTransit_RabbitMq_Producer.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassTransit_RabbitMq_Consumer
{
    public class ProductConsumer : IConsumer<Product>
    {
        private readonly ILogger<ProductConsumer> _logger;

        public ProductConsumer(ILogger<ProductConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<Product> context)
        {
            try
            {
                var product = context.Message;
                product.DateUpdatePrice = DateTime.Now;
                _logger.LogInformation($"Product received: {product.Id}");
            }
            catch (Exception ex) { _logger.LogError("Error on try to consume product", ex); }
            return Task.CompletedTask;
        }
    }
}
