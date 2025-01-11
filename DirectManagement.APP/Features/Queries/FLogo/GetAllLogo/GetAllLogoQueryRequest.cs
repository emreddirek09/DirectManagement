using MediatR;

namespace DirectManagement.APP.Features.Queries.FLogo.GetAllLogo;


public class GetAllLogoQueryRequest : IRequest<GetAllLogoQueryResponse>
{
    public int Page { get; set; } = 0;
    public int Size { get; set; } = 5;
}
