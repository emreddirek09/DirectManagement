

using DirectManagement.APP.Repositories.Banners;
using MediatR;

namespace DirectManagement.APP.Features.Commands.FBanner.CreateBanner;

public class CreateBannerCommandHandler : IRequestHandler<CreateBannerCommandRequest, CreateBannerCommandResponse>
{
    readonly IBannerWriteRepository _bannerWriteRepository;

    public CreateBannerCommandHandler(IBannerWriteRepository bannerWriteRepository)
    {
        _bannerWriteRepository = bannerWriteRepository;
    }

    public Task<CreateBannerCommandResponse> Handle(CreateBannerCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
