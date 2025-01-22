
using DirectManagement.DOMAIN.DTOS.BaseDtos;

namespace DirectManagement.DOMAIN.DTOS;

public class MainDto:BaseDto
{ 
    public string CompanyName { get; set; }
    public string CompanyNo { get; set; }
    public string SiteTitle { get; set; }
    public string WebLink { get; set; }
}
