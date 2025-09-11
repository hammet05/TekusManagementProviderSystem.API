using MediatR;
using Tekus.ManagementProvider.Domain.Abstractions;

namespace Tekus.ManagementProvider.Application.Abstractions.Messaging
{
    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>> where TQuery : IQuery<TResponse>
    {

    }
}
