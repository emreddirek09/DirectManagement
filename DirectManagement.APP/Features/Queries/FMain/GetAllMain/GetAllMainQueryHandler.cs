using AutoMapper;
using DirectManagement.APP.BaseResult.Abstracts;
using DirectManagement.APP.BaseResult.Concretes;
using DirectManagement.APP.Constants;
using DirectManagement.APP.Features.Queries.FMain.GetAllMain;
using DirectManagement.APP.Profiles;
using DirectManagement.APP.Repositories.Mains;
using DirectManagement.DOMAIN.Entities.Concretes;
using MediatR;
using System.Collections.Generic;

public class GetAllMainQueryHandler : IRequestHandler<GetAllMainQueryRequest, IDataResult<List<GetAllMainQueryResponse>>>
{
    private readonly IMainReadRepository _mainReadRepository;
    private readonly IMapper _mapper;

    public GetAllMainQueryHandler(IMainReadRepository mainReadRepository, IMapper mapper)
    {
        _mainReadRepository = mainReadRepository;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<GetAllMainQueryResponse>>> Handle(GetAllMainQueryRequest request, CancellationToken cancellationToken)
    {
        var configuration = new MapperConfiguration(cfg => cfg.AddProfile<MainProfile>());
        configuration.AssertConfigurationIsValid();
        #region
        //var result = mains.Select(main => new GetAllMainQueryResponse
        //{
        //    Id = main.Id,
        //    CompanyName = main.CompanyName,
        //    WebLink = main.WebLink,
        //    CompanyNo = main.CompanyNo,
        //    SiteTitle = main.SiteTitle,
        //    CreateDate = main.CreateDate,
        //    DeleteDate = main.DeleteDate,
        //    UpdateDate = main.UpdateDate,
        //}).ToList();       
        #endregion 

        var mains = await _mainReadRepository.GetAllAsync(
                    tracking: false,
                    skip: request.Page * request.Size,
                    take: request.Size
                );

        var orderedMains2 = mains
            .OrderByDescending(m => m.Id)
            .ThenByDescending(m => m.CreateDate)
            .ToList(); 

        var result = _mapper.Map<List<GetAllMainQueryResponse>>(mains.OrderByDescending(z => z.Id).ThenByDescending(z => z.CreateDate));
        return result != null ? new SuccessDataResult<List<GetAllMainQueryResponse>>(result, Messages.ListSuccess) : new ErrorDataResult<List<GetAllMainQueryResponse>>(result, Messages.ListFailed);
    }


}

