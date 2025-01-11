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

    public async Task<GetAllMainQueryResponse> Handle(GetAllMainQueryRequest request, CancellationToken cancellationToken)
    {
        var totalCount = _mainReadRepository.GetAllAsync(tracking: false).Result.Count;
        var mains = _mainReadRepository.GetAllAsync(tracking: false, skip: request.Page * request.Size, take
            : request.Size).Result
            .Select(m => new
            {
                m.Id,
                m.CompanyName,
                m.CompanyNo,
                m.SiteTitle,
                m.WebLink,
                m.CreateDate,
                m.DeleteDate,
                m.UpdateDate
            }).ToList();
        return new GetAllMainQueryResponse()
        {
            TotalCount = totalCount,
            Main = null
        };

        //var totalCount = _mainReadRepository.GetAll(false).Result.Count;
        //var mains = _mainReadRepository.GetAll(false).Result.Skip(request.Page * request.Size).Take(request.Size)
        //    .Select(m => new
        //    {
        //        m.Id,
        //        m.CompanyName,
        //        m.CompanyNo,
        //        m.SiteTitle,
        //        m.WebLink,
        //        m.CreateDate,
        //        m.DeleteDate,
        //        m.UpdateDate
        //    }).ToList();
        //return new GetAllMainQueryResponse()
        //{
        //    Main = mains,
        //    TotalCount = totalCount
        //};
    }
}
