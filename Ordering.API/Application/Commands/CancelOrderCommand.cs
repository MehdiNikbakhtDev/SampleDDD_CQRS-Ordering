﻿using CSharpFunctionalExtensions;
using MediatR;


namespace Ordering.Application.Commands
{
    public class CancelOrderCommand : IRequest<Result>
    {

        public int OrderNumber { get; private set; }
        public CancelOrderCommand()
        {

        }
        public CancelOrderCommand(int orderNumber)
        {
            OrderNumber = orderNumber;
        }
    }
}
