

using MediatR;

namespace DirectManagement.APP.Features.Commands.FOparationHour.CreateOparationHour;

public class CreateOparationHourCommandRequest:IRequest<CreateOparationHourCommandResponse>
{
    public string Day { get; set; }
    public DateTime StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public char Status { get; set; }
}
