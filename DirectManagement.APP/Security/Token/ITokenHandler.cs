using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Security.Token
{
    public interface ITokenHandler
    {
        DTOS.Token CreateAccessToken(int minute, List<Claim> claims);
    }
}
