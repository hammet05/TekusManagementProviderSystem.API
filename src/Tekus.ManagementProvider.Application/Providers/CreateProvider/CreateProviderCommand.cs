using Tekus.ManagementProvider.Application.Abstractions.Messaging;

namespace Tekus.ManagementProvider.Application.Providers.CreateProvider
{
    public record CreateProviderCommand(string nit, string name, string email) : ICommand<Guid>;

}
