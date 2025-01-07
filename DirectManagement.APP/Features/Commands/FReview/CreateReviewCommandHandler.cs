

using DirectManagement.APP.Repositories.Reviews;
using MediatR;

namespace DirectManagement.APP.Features.Commands.FReview;

public class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommandRequest, CreateReviewCommandResponse>
{
    readonly IReviewWriteRepository _reviewWriteRepository;

    public CreateReviewCommandHandler(IReviewWriteRepository reviewWriteRepository)
    {
        _reviewWriteRepository = reviewWriteRepository;
    }

    public Task<CreateReviewCommandResponse> Handle(CreateReviewCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
