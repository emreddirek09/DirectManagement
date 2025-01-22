using DirectManagement.DOMAIN.DTOS.BaseDtos;

namespace DirectManagement.DOMAIN.DTOS;

public class NewsLatterDto : BaseDto
{
    public string Email { get; set; }
    public char Status { get; set; }
}
