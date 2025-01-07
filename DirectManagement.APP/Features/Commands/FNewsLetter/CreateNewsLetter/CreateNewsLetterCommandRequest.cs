

using MediatR;

namespace DirectManagement.APP.Features.Commands.FNewsLetter.CreateNewsLetter;


public class CreateNewsLetterCommandRequest : IRequest<CreateNewsLetterCommandResponse>
{
    public string Email { get; set; }
    public char Status { get; set; }

}
