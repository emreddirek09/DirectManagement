using MediatR;

namespace DirectManagement.APP.Features.Queries.FOparationHour.GetAllOparationHour;

public class GetAllOparationHourQueryRequest : IRequest<GetAllOparationHourQueryResponse>
{
    public int Page { get; set; } = 0;
    public int Size { get; set; } = 5;
}
