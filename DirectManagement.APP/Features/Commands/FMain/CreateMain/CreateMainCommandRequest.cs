using DirectManagement.DOMAIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Features.Commands.FMain.CreateMain
{
    public class CreateMainCommandRequest : IRequest<CreateMainCommandResponse>
    {
        public string CompanyName { get; set; }
        public string CompanyNo { get; set; }
        public string SiteTitle { get; set; }
        public string WebLink { get; set; }
    }
}
