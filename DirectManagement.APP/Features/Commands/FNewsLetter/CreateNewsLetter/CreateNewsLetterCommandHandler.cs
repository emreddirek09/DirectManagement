

using DirectManagement.APP.Repositories.NewsLetters;
using MediatR;

namespace DirectManagement.APP.Features.Commands.FNewsLetter.CreateNewsLetter;

public class CreateNewsLetterCommandHandler : IRequestHandler<CreateNewsLetterCommandRequest, CreateNewsLetterCommandResponse>
{
    readonly INewsLetterWriteRepository _newsLetterWriteRepository;

    public CreateNewsLetterCommandHandler(INewsLetterWriteRepository newsLetterWriteRepository)
    {
        _newsLetterWriteRepository = newsLetterWriteRepository;
    }

    public Task<CreateNewsLetterCommandResponse> Handle(CreateNewsLetterCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
