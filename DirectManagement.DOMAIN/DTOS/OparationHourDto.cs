

using DirectManagement.DOMAIN.DTOS.BaseDtos;

namespace DirectManagement.DOMAIN.DTOS;

public class OparationHourDto:BaseDto
{
    public string Day { get; set; }
    public DateTime StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public char Status { get; set; }
}
