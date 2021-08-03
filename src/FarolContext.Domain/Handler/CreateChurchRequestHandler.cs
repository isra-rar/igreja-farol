using FarolContext.Domain.Commands;
using FarolContext.Domain.Commands.Contracts;
using FarolContext.Domain.Entities;
using FarolContext.Domain.Handler.Contratcs;
using FarolContext.Domain.Repositories;
using FarolContext.Domain.ValueObjects;
using Flunt.Notifications;

namespace FarolContext.Domain.Handler
{
    public class CreateChurchRequestHandler : Notifiable<Notification>, IHandler<CreateChurchCommand>
    {
        private readonly IChurchRepository _churchRepository;

        public CreateChurchRequestHandler(IChurchRepository churchRepository)
        {
            _churchRepository = churchRepository;
        }

        public ICommandResult Handle(CreateChurchCommand command)
        {
            command.Validate();
            if (!command.IsValid)
                return new GenericCommandResult(false, "Dados invalidos", command.Notifications);
            
            var church = new Church(command.Name, new Document(command.DocNumber, command.Type), new Email(command.Address), new Contact(command.Cellphone, command.Telephone),
             new Address(command.Street, command.Number, command.Neighborhood, command.City, command.State, command.Country, command.ZipCode));

            _churchRepository.Create(church);

            return new GenericCommandResult(true, "Igreja criada com sucesso", church);
        }
    }
}