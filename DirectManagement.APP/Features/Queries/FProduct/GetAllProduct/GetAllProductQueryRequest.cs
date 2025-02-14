﻿using MediatR; 

namespace DirectManagement.APP.Features.Queries.FProduct.GetAllProduct;

public class GetAllProductQueryRequest:IRequest<GetAllProductQueryResponse>
{
    public int Page { get; set; } = 0;
    public int Size { get; set; } = 5;
}
