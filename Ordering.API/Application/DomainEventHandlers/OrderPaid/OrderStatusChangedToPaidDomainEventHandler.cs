using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.Domain.AggregatesModel.OrderAggregate;
using Ordering.Domain.Events;

namespace Ordering.API.Application.DomainEventHandlers.OrderPaid
{
    public class OrderStatusChangedToPaidDomainEventHandler
                 : INotificationHandler<OrderStatusChangedToPaidDomainEvent>
    {
        private readonly ILoggerFactory _logger;


        public OrderStatusChangedToPaidDomainEventHandler(
           ILoggerFactory logger
            )
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Handle(OrderStatusChangedToPaidDomainEvent orderStatusChangedToPaidDomainEvent, CancellationToken cancellationToken)
        {
            _logger.CreateLogger<OrderStatusChangedToPaidDomainEventHandler>()
                .LogTrace("Order with Id: {OrderId} has been successfully updated to status {Status} ({Id})",
                    orderStatusChangedToPaidDomainEvent.OrderId, nameof(OrderStatus.Paid), OrderStatus.Paid.Id);

        }
    }
}
