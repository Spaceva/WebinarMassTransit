﻿using MassTransit;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;
using WebinarMassTransit.DemoCommon;

namespace WebinarMassTransit.DemoServiceA
{
    public class InformationRequestService : BackgroundService
    {
        private readonly ISendEndpointProvider sendEndpointProvider;
        private readonly ILogger<InformationRequestService> logger;

        public InformationRequestService(ISendEndpointProvider sendEndpointProvider, ILogger<InformationRequestService> logger)
        {
            this.sendEndpointProvider = sendEndpointProvider;
            this.logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            logger?.LogInformation("Starting...");
            var sendEndpoint = await this.sendEndpointProvider.GetSendEndpoint(new Uri("queue:serviceB"));
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                await sendEndpoint.Send<InformationRequest>(new { });
                logger?.LogInformation("InformationRequest message sent");
            }
        }
    }
}
