using DirectManagement.APP.Repositories.Logos;
using MediatR;

namespace DirectManagement.APP.Features.Commands.FLogo;

public class CreateLogoCommandHandler : IRequestHandler<CreateLogoCommandRequest, CreateLogoCommandResponse>
{
    readonly ILogoWriteRepository _logoWriteRepository;

    public CreateLogoCommandHandler(ILogoWriteRepository logoWriteRepository)
    {
        _logoWriteRepository = logoWriteRepository;
    }

    public Task<CreateLogoCommandResponse> Handle(CreateLogoCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
