using DirectManagement.APP.Repositories.Categories;
using MediatR;

namespace DirectManagement.APP.Features.Queries.FCategory.GetAllCategory;

public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, GetAllCategoryQueryResponse>
{
    readonly ICategoryReadRepository _categoryReadRepository;

    public GetAllCategoryQueryHandler(ICategoryReadRepository categoryReadRepository)
    {
        _categoryReadRepository = categoryReadRepository;
    }

    public Task<GetAllCategoryQueryResponse> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
