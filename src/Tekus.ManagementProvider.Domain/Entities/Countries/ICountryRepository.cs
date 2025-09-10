namespace Tekus.ManagementProvider.Domain.Entities.Countries
{
    public interface ICountryRepository
    {
        Task<ICollection<Country>> GetAllAsync(CancellationToken cancellationToken);
    }
}
