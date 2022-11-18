using CSharpFunctionalExtensions;
using MediatR;
using Ordering.Application.DTOs;


namespace Ordering.Application.Queries
{
    public class GetOrderByIdQuery : IRequest<Result<OrderQuery>>
    {
        public GetOrderByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
