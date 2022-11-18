
using CSharpFunctionalExtensions;
using MediatR;
using Ordering.Domain.AggregatesModel.OrderAggregate;
using System.Threading;
using System.Threading.Tasks;


namespace Ordering.API.Application.Commands
{
    public class SetPaidOrderStatusCommand : IRequest<Result>
    {

        public int OrderNumber { get; private set; }

        public SetPaidOrderStatusCommand(int orderNumber)
        {
            OrderNumber = orderNumber;
        }
    }
}
