using FluentValidation;
using Microsoft.Extensions.Logging;
using Ordering.Application.DTOs;

namespace Ordering.Application.Validations
{
    public class ShipOrderCommandValidator : AbstractValidator<ShipOrderDTO>
    {
        public ShipOrderCommandValidator(ILogger<ShipOrderCommandValidator> logger)
        {
            RuleFor(order => order.OrderNumber).NotEmpty().WithMessage("No orderId found");

            logger.LogTrace("----- INSTANCE CREATED - {ClassName}", GetType().Name);
        }
    }
}
