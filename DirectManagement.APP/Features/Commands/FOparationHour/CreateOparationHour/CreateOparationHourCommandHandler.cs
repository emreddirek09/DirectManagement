

using DirectManagement.APP.Repositories.OparationHours;
using MediatR;

namespace DirectManagement.APP.Features.Commands.FOparationHour.CreateOparationHour;

public class CreateOparationHourCommandHandler : IRequestHandler<CreateOparationHourCommandRequest, CreateOparationHourCommandResponse>
{
    readonly IOparationHourWriteRepository _oparationHourWriteRepository;

    public CreateOparationHourCommandHandler(IOparationHourWriteRepository oparationHourWriteRepository)
    {
        _oparationHourWriteRepository = oparationHourWriteRepository;
    }

    public Task<CreateOparationHourCommandResponse> Handle(CreateOparationHourCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
