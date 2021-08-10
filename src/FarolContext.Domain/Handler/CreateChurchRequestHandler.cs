using System.Threading;
using System.Threading.Tasks;
using FarolContext.Domain.Commands;
using FarolContext.Domain.Commands.Contracts;
using FarolContext.Domain.Commands.Request;
using FarolContext.Domain.Commands.Response;
using FarolContext.Domain.Entities;
using FarolContext.Domain.Repositories;
using FarolContext.Domain.ValueObjects;
using Flunt.Notifications;
using MediatR;

namespace FarolContext.Domain.Handler
{
    public class CreateChurchRequestHandler : Notifiable<Notification>, IRequestHandler<CreateChurchRequest, GenericCommandResult<CreateChurchResponse>>
    {
        private readonly IChurchRepository _churchRepository;

        public CreateChurchRequestHandler(IChurchRepository churchRepository)
        {
            _churchRepository = churchRepository;
        }

        public Task<GenericCommandResult<CreateChurchResponse>> Handle(CreateChurchRequest request, CancellationToken cancellationToken)
        {
            request.Validate();
            if (!request.IsValid) {
                var failValidation = new GenericCommandResult<CreateChurchResponse>(false, "Dados invalidos", request.Notifications, 400);
                return Task.FromResult(failValidation);
            }

            var church = new Church(request.Name, new Document(request.DocNumber, request.Type), new Email(request.Address), new Contact(request.Cellphone, request.Telephone),
             new Address(request.Street, request.Number, request.Neighborhood, request.City, request.State, request.Country, request.ZipCode));

            _churchRepository.Create(church);

            var result = new GenericCommandResult<CreateChurchResponse>(true, "Igreja criada com sucesso",
            new CreateChurchResponse
            {
                Id = church.Id,
                CreationDate = church.CreationDate,
                Name = church.Name,
                DocNumber = church.Document.Number,
                Type = church.Document.Type
            });

            return Task.FromResult(result);
        }
    }
}