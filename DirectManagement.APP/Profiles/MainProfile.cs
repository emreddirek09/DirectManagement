using DirectManagement.APP.Features.Queries.FMain.GetAllMain;
using DirectManagement.DOMAIN.DTOS;
using AutoMapper;
using DirectManagement.DOMAIN.Entities.Concretes;


namespace DirectManagement.APP.Profiles;
 
public class MainProfile : Profile
{
    public MainProfile()
    {
        CreateMap<Main, GetAllMainQueryResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.CompanyName))
            .ForMember(dest => dest.CompanyNo, opt => opt.MapFrom(src => src.CompanyNo))
            .ForMember(dest => dest.SiteTitle, opt => opt.MapFrom(src => src.SiteTitle))
            .ForMember(dest => dest.WebLink, opt => opt.MapFrom(src => src.WebLink))
            .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => src.CreateDate))
            .ForMember(dest => dest.UpdateDate, opt => opt.MapFrom(src => src.UpdateDate))
            .ForMember(dest => dest.DeleteDate, opt => opt.MapFrom(src => src.DeleteDate));

        CreateMap<GetAllMainQueryResponse, Main>()
          .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
          .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.CompanyName))
          .ForMember(dest => dest.CompanyNo, opt => opt.MapFrom(src => src.CompanyNo))
          .ForMember(dest => dest.SiteTitle, opt => opt.MapFrom(src => src.SiteTitle))
          .ForMember(dest => dest.WebLink, opt => opt.MapFrom(src => src.WebLink))
          .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => src.CreateDate))
          .ForMember(dest => dest.UpdateDate, opt => opt.MapFrom(src => src.UpdateDate))
          .ForMember(dest => dest.DeleteDate, opt => opt.MapFrom(src => src.DeleteDate));
    }
}
