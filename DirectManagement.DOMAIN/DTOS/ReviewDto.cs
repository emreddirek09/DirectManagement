

using DirectManagement.DOMAIN.DTOS.BaseDtos;

namespace DirectManagement.DOMAIN.DTOS;

public class ReviewDto:BaseDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string YourReview { get; set; }
    public int Quality { get; set; }
}
