using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.Domain.AggregatesModel.OrderAggregate;
using Ordering.Domain.Events;

namespace Ordering.API.Application.DomainEventHandlers.OrderGracePeriodConfirmed
{
    public class OrderStatusChangedToPaidDomainEventHandler
                 : INotificationHandler<OrderStatusChangedToAwaitingValidationDomainEvent>
    {
        private readonly ILoggerFactory _logger;

        public OrderStatusChangedToPaidDomainEventHandler(ILoggerFactory logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Handle(OrderStatusChangedToAwaitingValidationDomainEvent orderStatusChangedToAwaitingValidationDomainEvent, CancellationToken cancellationToken)
        {
            _logger.CreateLogger<OrderStatusChangedToAwaitingValidationDomainEvent>()
                .LogTrace("Order with Id: {OrderId} has been successfully updated to status {Status} ({Id})",
                    orderStatusChangedToAwaitingValidationDomainEvent.OrderId, nameof(OrderStatus.AwaitingValidation), OrderStatus.AwaitingValidation.Id);

        }
    }

}
