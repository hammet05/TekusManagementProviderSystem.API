using Tekus.ManagementProvider.Application.Abstractions.Messaging;
using Tekus.ManagementProvider.Domain.Abstractions;
using Tekus.ManagementProvider.Domain.Entities.Providers;

namespace Tekus.ManagementProvider.Application.Providers.CreateProvider
{
    public class CreateProviderCommandHandler : ICommandHandler<CreateProviderCommand, Guid>
    {
        private readonly IProviderRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateProviderCommandHandler(IProviderRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public CreateProviderCommandHandler(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        public async Task<Result<Guid>> Handle(CreateProviderCommand request, CancellationToken cancellationToken)
        {

            var nitResult = Nit.Create(request.nit);

            var nameResult = Name.Create(request.name);

            var emailResult = Email.Create(request.email);

            if (!emailResult.IsSuccess) return (Result<Guid>)Result.Failure(emailResult!.Error!);



            //var existing = await _repository.GetFirstOrDefault(p => p.Nit!.Value! == request.nit);
            //if (existing != null)
            //    return (Result<Guid>)Result.Success();


            var providerResult = Provider.Create(nitResult.Value!, nameResult.Value!, emailResult.Value!);



            var provider = providerResult;

            await _unitOfWork.Providers.Add(provider);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Result.Success(provider.Id);
        }
    }
}
