using DirectManagement.APP.Repositories.Logos;
using MediatR;

namespace DirectManagement.APP.Features.Queries.FLogo.GetAllLogo;

public class GetAllLogoQueryHandler : IRequestHandler<GetAllLogoQueryRequest, GetAllLogoQueryResponse>
{
    readonly ILogoReadRepository _logoReadRepository;

    public GetAllLogoQueryHandler(ILogoReadRepository logoReadRepository)
    {
        _logoReadRepository = logoReadRepository;
    }

    public Task<GetAllLogoQueryResponse> Handle(GetAllLogoQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
