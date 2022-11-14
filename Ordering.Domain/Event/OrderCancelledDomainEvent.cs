using MediatR;
using Ordering.Domain.AggregatesModel.OrderAggregate;

namespace Ordering.Domain.Event
{
    public class OrderCancelledDomainEvent : INotification
    {
        public Order Order { get; }

        public OrderCancelledDomainEvent(Order order)
        {
            Order = order;
        }
    }
}
