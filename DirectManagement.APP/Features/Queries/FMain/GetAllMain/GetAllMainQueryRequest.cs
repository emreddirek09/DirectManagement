using DirectManagement.APP.BaseResult.Abstracts;
using MediatR;

namespace DirectManagement.APP.Features.Queries.FMain.GetAllMain;
public class GetAllMainQueryRequest : IRequest<IDataResult<List<GetAllMainQueryResponse>>>
{
    public GetAllMainQueryRequest(int page, int size)
    {
        Page = page = 0;
        Size = size = 5;
    }

    public int Page { get; set; }
    public int Size { get; set; }
}
