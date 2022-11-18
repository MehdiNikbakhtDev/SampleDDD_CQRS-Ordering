
using CSharpFunctionalExtensions;
using MediatR;
using Ordering.Domain.AggregatesModel.OrderAggregate;
using System.Threading;
using System.Threading.Tasks;


namespace Ordering.API.Application.Commands
{
    public class SetStockRejectedOrderStatusCommand : IRequest<Result>
    {
        public int OrderNumber { get; private set; }

        public List<int> OrderStockItems { get; private set; }

        public SetStockRejectedOrderStatusCommand(int orderNumber, List<int> orderStockItems)
        {
            OrderNumber = orderNumber;
            OrderStockItems = orderStockItems;
        }
    }


}
