using Tekus.ManagementProvider.Application.Abstractions.Messaging;

namespace Tekus.ManagementProvider.Application.Services.GetServicesByCountryCode
{
    public record GetServicesByCountryCodeQuery(string countryCode) : IQuery<List<ServicesByCountryResponse>>;

}
