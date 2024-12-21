using DirectManagement.DOMAIN;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Features.Queries.FUser.GetAllUser
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQueryRequest, GetAllUsersQueryResponse>
    {
        private readonly UserManager<AppUser> _userManager;

        public GetAllUsersQueryHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<GetAllUsersQueryResponse> Handle(GetAllUsersQueryRequest request, CancellationToken cancellationToken)
        {
            var users = await _userManager.Users
           .Select(user => new
           {
               user.Id,
               user.Name,
               user.Surname,
               user.UserName,
               user.Email,
               user.PhoneNumber,
               user.KimlikNo
           }).ToListAsync();



            return new GetAllUsersQueryResponse
            {
                Data = users
            };
        }
    }
}

