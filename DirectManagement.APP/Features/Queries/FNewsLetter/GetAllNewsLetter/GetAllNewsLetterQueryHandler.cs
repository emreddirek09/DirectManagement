using DirectManagement.APP.Repositories.NewsLetters;
using MediatR;

namespace DirectManagement.APP.Features.Queries.FNewsLetter.GetAllNewsLetter;

public class GetAllNewsLetterQueryHandler : IRequestHandler<GetAllNewsLetterQueryRequest, GetAllNewsLetterQueryResponse>
{
    readonly INewsLetterReadRepository _newsLetterReadRepository;

    public GetAllNewsLetterQueryHandler(INewsLetterReadRepository newsLetterReadRepository)
    {
        _newsLetterReadRepository = newsLetterReadRepository;
    }

    public Task<GetAllNewsLetterQueryResponse> Handle(GetAllNewsLetterQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
