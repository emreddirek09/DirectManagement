using DirectManagement.APP.Repositories.Comments;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Features.Queries.FComment.GetAllComment;

public class GetAllCommentQueryHandler : IRequestHandler<GetAllCommentQueryRequest, GetAllCommentQueryResponse>
{
    readonly ICommentReadRepository _commentReadRepository;

    public GetAllCommentQueryHandler(ICommentReadRepository commentReadRepository)
    {
        _commentReadRepository = commentReadRepository;
    }

    public Task<GetAllCommentQueryResponse> Handle(GetAllCommentQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
    