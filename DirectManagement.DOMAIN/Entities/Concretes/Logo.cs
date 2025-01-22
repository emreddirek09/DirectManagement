using DirectManagement.DOMAIN.Entities.BaseEntitiy;

namespace DirectManagement.DOMAIN.Entities.Concretes;


public class Logo : Base
{
    public string Icon { get; set; }
    public string LogoUrl { get; set; }
    public int LogoHeight { get; set; }
    public int LogoWidth { get; set; }
}
