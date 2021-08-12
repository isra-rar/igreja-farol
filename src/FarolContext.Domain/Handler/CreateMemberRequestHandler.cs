using System.Threading;
using System.Threading.Tasks;
using FarolContext.Domain.Commands;
using FarolContext.Domain.Commands.Request;
using FarolContext.Domain.Commands.Response;
using FarolContext.Domain.Entities;
using FarolContext.Domain.Repositories;
using FarolContext.Domain.ValueObjects;
using Flunt.Notifications;
using MediatR;

namespace FarolContext.Domain.Handler
{
    public class CreateMemberRequestHandler : Notifiable<Notification>, IRequestHandler<CreateMemberRequest, GenericCommandResult<CreateMemberResponse>>
    {
        private readonly IMemberRepository _memberRepository;

        public CreateMemberRequestHandler(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public Task<GenericCommandResult<CreateMemberResponse>> Handle(CreateMemberRequest request, CancellationToken cancellationToken)
        {
            request.Validate();
            if (!request.IsValid)
            {
                var failValidation = new GenericCommandResult<CreateMemberResponse>(false, "Dados invalidos", request.Notifications, 400);
                return Task.FromResult(failValidation);
            }

            var member = new Member(new Name(request.FirstName, request.LastName),
                request.Age, request.Gender,
                new Document(request.DocNumber, request.Type), new Email(request.Address),
                new Contact(request.Cellphone, request.Telephone),
                new Address(request.Street, request.Number, request.Neighborhood, request.City, request.State, request.Country, request.ZipCode),
                request.MemberType, request.ChurchId);

            _memberRepository.Create(member);

            var result = new GenericCommandResult<CreateMemberResponse>(true, "Membro criado com sucesso",
            new CreateMemberResponse
            {
                Id = member.Id,
                CreationDate = member.CreationDate,
                Name = member.Name,
                Age = member.Age,
                Gender = member.Gender,
                Document = member.Document,
                Email = member.Email,
                MemberType = member.MemberType,
                ChurchId = member.ChurchId
            });
            
            return Task.FromResult(result);
        }
    }
}