using MediatR;

namespace DirectManagement.APP.Features.Queries.FNewsLetter.GetAllNewsLetter;

public class GetAllNewsLetterQueryRequest : IRequest<GetAllNewsLetterQueryResponse>
{
    public int Page { get; set; } = 0;
    public int Size { get; set; } = 5;
}
