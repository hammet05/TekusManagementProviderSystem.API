using Tekus.ManagementProvider.Domain.Abstractions;

namespace Tekus.ManagementProvider.Domain.Entities.Countries
{
    public class Country : BaseEntity
    {

        public Country(Guid id) : base(id)
        {
        }


        public CountryCode? CountryCode { get; private set; }
        public bool IsActive { get; private set; }
    }
}
