using MediatR;
using Tekus.ManagementProvider.Domain.Abstractions;

namespace Tekus.ManagementProvider.Application.Abstractions.Messaging
{
    public interface ICommand : IRequest<Result>
    {

    }

    public interface ICommand<TResponse> : IRequest<Result<TResponse>>
    {

    }



}
