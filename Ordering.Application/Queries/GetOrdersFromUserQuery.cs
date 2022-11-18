using CSharpFunctionalExtensions;
using Dapper;
using MediatR;
using Microsoft.Data.SqlClient;
using Ordering.Application.DTOs;
using Ordering.Application.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace Ordering.Application.Queries
{
    public class GetOrdersFromUserQuery : IRequest<Result<IEnumerable<OrderSummary>>>
    {
        public GetOrdersFromUserQuery(int userId)
        {
            this.UserId = userId;
        }
        public int UserId { get; }
    }
}

