namespace Tekus.ManagementProvider.Application.Services.GetServicesByCountryCode
{
    public class ServicesByCountryResponse
    {
        public ServicesByCountryResponse(string? nit, string? name, string? email, string? serviceName, decimal hourlyRateUsd, bool isActive)
        {
            Nit = nit;
            Name = name;
            Email = email;
            ServiceName = serviceName;
            HourlyRateUsd = hourlyRateUsd;
            IsActive = isActive;
        }

        public string? Nit { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? ServiceName { get; set; }

        public decimal HourlyRateUsd { get; set; }

        public bool IsActive { get; set; }




    }
}
