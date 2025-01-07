using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Features.Commands.FReview
{
    public class CreateReviewCommandRequest : IRequest<CreateReviewCommandResponse>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string YourReview { get; set; }
        public int Quality { get; set; }
    }
}
