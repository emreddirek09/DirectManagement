

using MediatR;

namespace DirectManagement.APP.Features.Queries.FReview.GetAllReview;

public class GetAllReviewQueryRequest:IRequest<GetAllReviewQueryResponse>
{
    public int Page { get; set; } = 0;
    public int Size { get; set; } = 5;
}
