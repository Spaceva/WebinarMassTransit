﻿using CoffeeMassTransit.Contracts;
using MassTransit;

namespace RoutingSlip.Activities;

public interface OrderSubmitted : CorrelatedBy<Guid>
{
}
