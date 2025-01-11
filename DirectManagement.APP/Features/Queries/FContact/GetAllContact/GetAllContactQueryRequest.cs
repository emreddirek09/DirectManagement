using MediatR;

namespace DirectManagement.APP.Features.Queries.FContact.GetAllContact;

public class GetAllContactQueryRequest : IRequest<GetAllContactQueryResponse>
{
    public int Page { get; set; } = 0;
    public int Size { get; set; } = 5;
}
