using DirectManagement.APP.Repositories.OparationHours;
using MediatR;

namespace DirectManagement.APP.Features.Queries.FOparationHour.GetAllOparationHour;

public class GetAllOparationHourQueryHandler : IRequestHandler<GetAllOparationHourQueryRequest, GetAllOparationHourQueryResponse>
{
    readonly IOparationHourReadRepository _oparationHourReadRepository;

    public GetAllOparationHourQueryHandler(IOparationHourReadRepository oparationHourReadRepository)
    {
        _oparationHourReadRepository = oparationHourReadRepository;
    }

    public Task<GetAllOparationHourQueryResponse> Handle(GetAllOparationHourQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
