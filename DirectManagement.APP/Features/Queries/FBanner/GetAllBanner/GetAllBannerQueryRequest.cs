﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Features.Queries.FBanner.GetAllBanner
{
    public class GetAllBannerQueryRequest : IRequest<GetAllBannerQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
