using DirectManagement.APP.Repositories.Contacts;
using MediatR;

namespace DirectManagement.APP.Features.Queries.FContact.GetAllContact;

public class GetAllContactQueryHandler : IRequestHandler<GetAllContactQueryRequest, GetAllContactQueryResponse>
{
    readonly IContactReadRepository _contactReadRepository;

    public GetAllContactQueryHandler(IContactReadRepository contactReadRepository)
    {
        _contactReadRepository = contactReadRepository;
    }

    public Task<GetAllContactQueryResponse> Handle(GetAllContactQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
