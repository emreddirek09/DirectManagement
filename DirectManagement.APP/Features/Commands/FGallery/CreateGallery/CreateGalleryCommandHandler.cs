using DirectManagement.APP.Repositories.Galleries;
using MediatR;

namespace DirectManagement.APP.Features.Commands.FGallery.CreateGallery;

public class CreateGalleryCommandHandler : IRequestHandler<CreateGalleryCommandRequest, CreateGalleryCommandResponse>
{
    readonly IGalleryWriteRepository _galleryWriteRepository;

    public CreateGalleryCommandHandler(IGalleryWriteRepository galleryWriteRepository)
    {
        _galleryWriteRepository = galleryWriteRepository;
    }

    public Task<CreateGalleryCommandResponse> Handle(CreateGalleryCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
