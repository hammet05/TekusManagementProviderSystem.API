using Tekus.ManagementProvider.Domain.Abstractions;

namespace Tekus.ManagementProvider.Domain.Entities.Providers
{
    public record Name
    {
        public string Value { get; }

        public Name(string value) => Value = value;

        public static Result<Name> Create(string value)
        {
            return Result<Name>.Success(new Name(value.Trim()));
        }

        public override string ToString() => Value;
    }

}
