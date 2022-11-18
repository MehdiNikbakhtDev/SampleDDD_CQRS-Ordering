﻿
using CSharpFunctionalExtensions;
using MediatR;
using Ordering.Domain.AggregatesModel.OrderAggregate;



namespace Ordering.API.Application.Commands
{
    public class CancelOrderCommandHandler : IRequestHandler<CancelOrderCommand, Result>
    {
        private readonly IOrderRepository _orderRepository;

        public CancelOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        /// <summary>
        /// Handler which processes the command when
        /// customer executes cancel order from app
        /// </summary>
        /// <param name="command"></param>
        public async Task<Result> Handle(CancelOrderCommand command, CancellationToken cancellationToken)
        {
            var orderToUpdate = await _orderRepository.GetAsync(command.OrderNumber);
            if (orderToUpdate == null)
            {
                return Result.Failure("The order was canceled.");
            }

            orderToUpdate.SetCancelledStatus();
            await _orderRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
            return Result.Success();
        }
    }

}
