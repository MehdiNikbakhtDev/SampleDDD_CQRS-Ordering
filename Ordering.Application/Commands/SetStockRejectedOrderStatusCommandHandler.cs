
using CSharpFunctionalExtensions;
using MediatR;
using Ordering.Domain.AggregatesModel.OrderAggregate;
using System.Threading;
using System.Threading.Tasks;


namespace Ordering.Application.Commands
{
    public class ShipOrderCommand : IRequest<Result>
    {
        public int OrderNumber { get; private set; }

        public ShipOrderCommand(int orderNumber)
        {
            OrderNumber = orderNumber;
        }
    }
}
