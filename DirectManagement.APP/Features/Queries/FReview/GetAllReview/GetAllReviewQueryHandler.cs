

using DirectManagement.APP.Repositories.Reviews;
using MediatR;

namespace DirectManagement.APP.Features.Queries.FReview.GetAllReview;

public class GetAllReviewQueryHandler : IRequestHandler<GetAllReviewQueryRequest, GetAllReviewQueryResponse>
{
    readonly IReviewReadRepository _reviewReadRepository;

    public GetAllReviewQueryHandler(IReviewReadRepository reviewReadRepository)
    {
        _reviewReadRepository = reviewReadRepository;
    }

    public Task<GetAllReviewQueryResponse> Handle(GetAllReviewQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
