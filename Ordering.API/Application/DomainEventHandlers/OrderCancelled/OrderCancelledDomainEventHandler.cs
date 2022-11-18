using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.Domain.AggregatesModel.OrderAggregate;
using Ordering.Domain.Events;


namespace Ordering.API.Application.DomainEventHandlers.OrderCancelled
{
    public class OrderStatusChangedToAwaitingValidationDomainEventHandler
                 : INotificationHandler<OrderCancelledDomainEvent>
    {
        private readonly ILoggerFactory _logger;

        public OrderStatusChangedToAwaitingValidationDomainEventHandler(
            ILoggerFactory logger)

        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Handle(OrderCancelledDomainEvent orderCancelledDomainEvent, CancellationToken cancellationToken)
        {
            _logger.CreateLogger<OrderCancelledDomainEvent>()
                .LogTrace("Order with Id: {OrderId} has been successfully updated to status {Status} ({Id})",
                    orderCancelledDomainEvent.Order.Id, nameof(OrderStatus.Cancelled), OrderStatus.Cancelled.Id);
        }
    }
}
