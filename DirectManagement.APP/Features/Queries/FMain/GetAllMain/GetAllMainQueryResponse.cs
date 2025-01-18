using DirectManagement.APP.BaseResult.Abstracts;
using DirectManagement.APP.BaseResult.Concretes;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.APP.Features.Queries.FMain.GetAllMain;

public class GetAllMainQueryResponse
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string CompanyNo { get; set; }
    public string SiteTitle { get; set; }
    public string WebLink { get; set; }
    public DateTime? CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? DeleteDate { get; set; }
}
