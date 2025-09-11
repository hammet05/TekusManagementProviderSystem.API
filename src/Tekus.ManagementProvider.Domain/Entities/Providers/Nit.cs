using Tekus.ManagementProvider.Domain.Abstractions;

namespace Tekus.ManagementProvider.Domain.Entities.Providers
{
    public record Nit
    {
        public string Value { get; }

        public Nit(string value) => Value = value;

        public static Result<Nit> Create(string value)
        {
            return Result<Nit>.Success(new Nit(value.Trim()));
        }

        public override string ToString() => Value;
    }


}
