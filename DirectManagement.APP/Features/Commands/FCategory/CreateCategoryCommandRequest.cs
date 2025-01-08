

using MediatR;

namespace DirectManagement.APP.Features.Commands.FCategory;

public class CreateCategoryCommandRequest:IRequest<CreateCategoryCommandResponse>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageSM { get; set; }
    public string ImageLG { get; set; }
    public string MetaTitle { get; set; }
    public int Level { get; set; }
    public long Price { get; set; }
}
