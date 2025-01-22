using DirectManagement.DOMAIN.DTOS.BaseDtos; 

namespace DirectManagement.DOMAIN.DTOS;

public class GalleryDto:BaseDto
{
    public string Title { get; set; }
    public string SubTitle { get; set; }
    public string Image { get; set; }
    public string BigImage { get; set; }
    public string ImageLink { get; set; }
    public char Status { get; set; }
}
