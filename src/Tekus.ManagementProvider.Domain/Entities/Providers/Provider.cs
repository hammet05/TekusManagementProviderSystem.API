using Tekus.ManagementProvider.Domain.Abstractions;
using Tekus.ManagementProvider.Domain.Entities.CustomsFields;
using Tekus.ManagementProvider.Domain.Entities.Providers.Events;
using Tekus.ManagementProvider.Domain.Entities.ProvidersServices;

namespace Tekus.ManagementProvider.Domain.Entities.Providers
{
    public class Provider : BaseEntity
    {
        protected Provider(Guid id, Nit nit, Name name, Email email) : base(id)
        {
            Nit = nit;
            Name = name;
            Email = email;
        }
        public Nit? Nit { get; private set; }
        public Name? Name { get; private set; }
        public Email? Email { get; private set; }

        public ICollection<ProviderService> ProviderServices { get; set; } = new List<ProviderService>();
        public ICollection<ProviderCustomField> CustomFields { get; set; } = new List<ProviderCustomField>();


        public static Provider Create(Nit nit, Name name, Email email)
        {
            //if (nit is null) return Result<Provider>.Fail("NIT inválido");
            //if (name is null) return Result<Provider>.Fail("Nombre inválido");
            //if (email is null) return Result<Provider>.Fail("Email inválido");

            //return Result<Provider>.Ok(new Provider(Guid.NewGuid(), nit, name, email));

            var provider = new Provider(Guid.NewGuid(), nit, name, email);
            provider.RaiseDomainEvent(new ProviderCreateDomainEvent(provider.Id));

            return provider;
        }
    }
}
