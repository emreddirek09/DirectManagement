
using DirectManagement.APP.Repositories.Contacts;
using DirectManagement.APPFeatures.Commands.FContact.CreateContact;
using MediatR;

namespace DirectManagement.APP.Features.Commands.FContact.CreateContact;
public class CreateContactCommandHandler : IRequestHandler<CreateContactCommandRequest, CreateContactCommandRespons>
{
    readonly IContactWriteRepository _contactWriteRepository;

    public CreateContactCommandHandler(IContactWriteRepository contactWriteRepository)
    {
        _contactWriteRepository = contactWriteRepository;
    }

    public Task<CreateContactCommandRespons> Handle(CreateContactCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

