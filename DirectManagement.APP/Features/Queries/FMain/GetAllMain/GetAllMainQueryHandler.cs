using DirectManagement.APP.Repositories.Mains;
using MediatR;
namespace DirectManagement.APP.Features.Queries.FMain.GetAllMain;

public class GetAllMainQueryHandler : IRequestHandler<GetAllMainQueryRequest, GetAllMainQueryResponse>
{
    readonly IMainReadRepository _mainReadRepository;

    public GetAllMainQueryHandler(IMainReadRepository mainReadRepository)
    {
        _mainReadRepository = mainReadRepository;
    }

    public Task<GetAllMainQueryResponse> Handle(GetAllMainQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
