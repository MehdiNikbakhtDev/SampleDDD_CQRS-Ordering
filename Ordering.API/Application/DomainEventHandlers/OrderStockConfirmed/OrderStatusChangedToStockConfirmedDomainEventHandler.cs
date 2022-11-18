﻿using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.Domain.AggregatesModel.OrderAggregate;
using Ordering.Domain.Events;


namespace Ordering.Application.DomainEventHandlers.OrderStockConfirmed
{
    public class OrderStatusChangedToStockConfirmedDomainEventHandler
                 : INotificationHandler<OrderStatusChangedToStockConfirmedDomainEvent>
    {
        private readonly ILoggerFactory _logger;

        public OrderStatusChangedToStockConfirmedDomainEventHandler(
            ILoggerFactory logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Handle(OrderStatusChangedToStockConfirmedDomainEvent orderStatusChangedToStockConfirmedDomainEvent, CancellationToken cancellationToken)
        {
            _logger.CreateLogger<OrderStatusChangedToStockConfirmedDomainEventHandler>()
                .LogTrace("Order with Id: {OrderId} has been successfully updated to status {Status} ({Id})",
                    orderStatusChangedToStockConfirmedDomainEvent.OrderId, nameof(OrderStatus.StockConfirmed), OrderStatus.StockConfirmed.Id);

        }
    }
}
