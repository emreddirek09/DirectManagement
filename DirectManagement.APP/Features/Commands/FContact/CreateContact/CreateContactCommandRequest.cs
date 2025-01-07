using DirectManagement.APPFeatures.Commands.FContact.CreateContact;
using MediatR;

namespace DirectManagement.APP.Features.Commands.FContact.CreateContact;

public class CreateContactCommandRequest : IRequest<CreateContactCommandRespons>
{
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public string Email { get; set; }
    public string MapLink { get; set; }
    public string Phone { get; set; }
}

