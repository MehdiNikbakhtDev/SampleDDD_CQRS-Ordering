using MediatR;
using Ordering.Domain.AggregatesModel.OrderAggregate;

namespace Ordering.Domain.Event
{
    public class OrderShippedDomainEvent : INotification
    {
        public Order Order { get; }

        public OrderShippedDomainEvent(Order order)
        {
            Order = order;
        }
    }
}
