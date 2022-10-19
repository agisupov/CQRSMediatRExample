﻿using MediatR;

namespace CQRSMediatRExample.Notifications
{
    public record ProductAddedNotification(Product Product) : INotification;
}
