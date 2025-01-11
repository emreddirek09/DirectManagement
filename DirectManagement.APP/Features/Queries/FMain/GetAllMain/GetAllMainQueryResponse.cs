using DirectManagement.APP.BaseResult.Abstracts;
using DirectManagement.APP.BaseResult.Concretes;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.APP.Features.Queries.FMain.GetAllMain;

public class GetAllMainQueryResponse
{
    public int TotalCount { get; set; }
    public Main Main { get; set; }
}
