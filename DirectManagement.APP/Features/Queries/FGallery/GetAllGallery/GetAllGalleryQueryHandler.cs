using DirectManagement.APP.Repositories.Galleries;
using MediatR;

namespace DirectManagement.APP.Features.Queries.FGallery.GetAllGallery;

public class GetAllGalleryQueryHandler : IRequestHandler<GetAllGalleryQueryRequest, GetAllGalleryQueryResponse>
{
    readonly IGalleryReadRepository _galleryReadRepository;

    public GetAllGalleryQueryHandler(IGalleryReadRepository galleryReadRepository)
    {
        _galleryReadRepository = galleryReadRepository;
    }

    public Task<GetAllGalleryQueryResponse> Handle(GetAllGalleryQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
