

using DirectManagement.DOMAIN.DTOS.BaseDtos;

namespace DirectManagement.DOMAIN.DTOS;

public class ProductDto:BaseDto
{
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public string ProductImage { get; set; }
    public long ProductPrice { get; set; }
    public int ProductStock { get; set; }
    public char Status { get; set; }
}
