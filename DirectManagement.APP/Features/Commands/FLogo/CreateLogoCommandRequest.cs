using MediatR; 

namespace DirectManagement.APP.Features.Commands.FLogo;

public class CreateLogoCommandRequest:IRequest<CreateLogoCommandResponse>
{
    public string Icon { get; set; }
    public string LogoUrl { get; set; }
    public int LogoHeight { get; set; }
    public int LogoWidth { get; set; }
}
