using Tekus.ManagementProvider.Domain.Abstractions;

namespace Tekus.ManagementProvider.Domain.Entities.Providers
{
    public record Email
    {
        public string Value { get; }

        public Email(string value) => Value = value;

        public static Result<Email> Create(string value)
        {
            return Result<Email>.Success(new Email(value.Trim()));
        }

        public override string ToString() => Value;
    }
}
