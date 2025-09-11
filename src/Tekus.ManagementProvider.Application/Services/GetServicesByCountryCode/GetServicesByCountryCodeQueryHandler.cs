using Tekus.ManagementProvider.Application.Abstractions.Messaging;
using Tekus.ManagementProvider.Domain.Abstractions;
using Tekus.ManagementProvider.Domain.Entities.ProvidersServices;

namespace Tekus.ManagementProvider.Application.Services.GetServicesByCountryCode
{
    public class GetServicesByCountryCodeQueryHandler : IQueryHandler<GetServicesByCountryCodeQuery, List<ServicesByCountryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<ProviderService> _providerServiceRepository;

        public GetServicesByCountryCodeQueryHandler(IRepository<ProviderService> providerServiceRepository)
        {
            _providerServiceRepository = providerServiceRepository;
        }


        public async Task<Result<List<ServicesByCountryResponse>>> Handle(GetServicesByCountryCodeQuery request, CancellationToken cancellationToken)
        {
            var providerServices = await _providerServiceRepository.GetAll(ps => ps.CountryId == request.countryCode, q => q.OrderBy(ps => ps.Provider!.Name!), false, ps => ps.Provider!, ps => ps.Service!);

            var data = providerServices
            .Select(ps => new ServicesByCountryResponse(
                ps.Provider!.Nit!.Value,
                ps.Provider!.Name!.Value,
                ps.Provider!.Email!.Value,
                ps.Service!.ServiceName!.value,
                ps.Service!.HourlyRateUsd,
                true
            )).ToList();

            return Result<List<ServicesByCountryResponse>>.Success(data);
        }
    }
}
