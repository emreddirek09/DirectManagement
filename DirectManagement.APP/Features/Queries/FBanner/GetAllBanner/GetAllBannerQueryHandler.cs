using DirectManagement.APP.Repositories.Banners;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Features.Queries.FBanner.GetAllBanner
{
    public class GetAllBannerQueryHandler : IRequestHandler<GetAllBannerQueryRequest, GetAllBannerQueryResponse>
    {
        readonly IBannerReadRepository _readRepository;

        public GetAllBannerQueryHandler(IBannerReadRepository readRepository)
        {
            _readRepository = readRepository;
        }

        public Task<GetAllBannerQueryResponse> Handle(GetAllBannerQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
