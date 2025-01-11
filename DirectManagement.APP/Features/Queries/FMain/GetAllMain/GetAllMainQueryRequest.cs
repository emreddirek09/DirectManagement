using MediatR;

namespace DirectManagement.APP.Features.Queries.FMain.GetAllMain;

public class GetAllMainQueryRequest : IRequest<GetAllMainQueryResponse>
{
    public int Page { get; set; } = 0;
    public int Size { get; set; } = 5;
}
