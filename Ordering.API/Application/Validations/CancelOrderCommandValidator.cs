using System;
using FluentValidation;
using Microsoft.Extensions.Logging;
using Ordering.Application.DTOs;

namespace Ordering.Application.Validations
{
    public class CancelOrderCommandValidator : AbstractValidator<CancelOrderDTO>
    {
        public CancelOrderCommandValidator(ILogger<CancelOrderCommandValidator> logger)
        {
            RuleFor(order => order.OrderNumber).NotEmpty().WithMessage("No orderId found");

            logger.LogTrace("----- INSTANCE CREATED - {ClassName}", GetType().Name);
        }
    }
}
