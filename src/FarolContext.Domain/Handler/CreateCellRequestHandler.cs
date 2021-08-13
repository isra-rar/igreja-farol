using System.Threading;
using System.Threading.Tasks;
using FarolContext.Domain.Commands;
using FarolContext.Domain.Commands.Request;
using FarolContext.Domain.Commands.Response;
using FarolContext.Domain.Entities;
using FarolContext.Domain.Repositories;
using Flunt.Notifications;
using MediatR;

namespace FarolContext.Domain.Handler
{
    public class CreateCellRequestHandler : Notifiable<Notification>, IRequestHandler<CreateCellRequest, GenericCommandResult<CreateCellResponse>>
    {
        private readonly ICellRepository _cellRepository;

        public CreateCellRequestHandler(ICellRepository cellRepository)
        {
            _cellRepository = cellRepository;
        }

        public Task<GenericCommandResult<CreateCellResponse>> Handle(CreateCellRequest request, CancellationToken cancellationToken)
        {
            request.Validate();
            if (!request.IsValid) {
                var failValidation = new GenericCommandResult<CreateCellResponse>(false, "Dados invalidos", request.Notifications, 400);
                return Task.FromResult(failValidation);
            }

            var cell = new Cell(request.Name, request.ChurchId, request.LeaderId, request.SupervisorId);

            _cellRepository.Create(cell);

            var result = new GenericCommandResult<CreateCellResponse>(true, "Igreja criada com sucesso",
            new CreateCellResponse
            {
                Id = cell.Id,
                CreationDate = cell.CreationDate,
                Name = cell.Name,
                ChurchId = cell.ChurchId,
                LeaderId = cell.LeaderId,
                SupervisorId = cell.SupervisorId
            });

            return Task.FromResult(result);
        }
    }
}