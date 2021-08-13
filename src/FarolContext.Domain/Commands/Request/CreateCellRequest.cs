using System;
using FarolContext.Domain.Commands.Contracts;
using FarolContext.Domain.Commands.Response;
using Flunt.Notifications;
using Flunt.Validations;
using MediatR;

namespace FarolContext.Domain.Commands.Request
{
    public class CreateCellRequest : Notifiable<Notification>, IRequest<GenericCommandResult<CreateCellResponse>>, ICommand
    {
        public CreateCellRequest(string name, Guid churchId, Guid leaderId, Guid supervisorId)
        {
            Name = name;
            ChurchId = churchId;
            LeaderId = leaderId;
            SupervisorId = supervisorId;
        }

        public string Name { get; set; }
        public Guid ChurchId { get; set; }
        public Guid LeaderId { get; set; }
        public Guid SupervisorId { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<CreateCellRequest>()
                .Requires()
                .IsGreaterThan(Name, 3, "Name", "Nome da Celula deve ser maior que 3 caracteres")
                .IsNotNull(ChurchId, "ChurchId", "Id da igreja não pode ser nulo ou vazio")
                .IsNotNull(LeaderId, "LeaderId", "Id do Lider não pode ser nulo ou vazio")
                .IsNotNull(SupervisorId, "SupervisorId", "Id do Supervisor não pode ser nulo ou vazio")
            );
        }
    }
}