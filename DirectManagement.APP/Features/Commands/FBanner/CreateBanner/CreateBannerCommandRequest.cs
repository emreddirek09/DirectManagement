using MediatR;

namespace DirectManagement.APP.Features.Commands.FBanner.CreateBanner;

public class CreateBannerCommandRequest:IRequest<CreateBannerCommandResponse>
{
    public string Description { get; set; }
    public string Title { get; set; }
    public string Button { get; set; }
    public string Url { get; set; }
    public string WebImage { get; set; }
    public string MobileImage { get; set; }

}
