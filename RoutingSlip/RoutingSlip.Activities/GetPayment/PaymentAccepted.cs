﻿using MassTransit;

namespace RoutingSlip.Activities;

public interface PaymentAccepted : CorrelatedBy<Guid>
{
}
