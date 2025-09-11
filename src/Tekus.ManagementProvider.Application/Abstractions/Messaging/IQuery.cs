using MediatR;
using Tekus.ManagementProvider.Domain.Abstractions;

namespace Tekus.ManagementProvider.Application.Abstractions.Messaging
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {

    }
}
