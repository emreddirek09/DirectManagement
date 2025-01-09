using DirectManagement.APP.Constants;
using DirectManagement.APP.Features.Commands.FUser.CreateUser;
using DirectManagement.DOMAIN.Entities.Concretes;
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

            try
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
            }
            catch (Exception ex)
            {

                return new GetAllUsersQueryResponse
                {
                    Success = false,
                    Message = ex.Message.Trim().ToString()
                };
            }
            return new GetAllUsersQueryResponse
            {
                Success = false,
                Message = Messages.RegisterFailed,
                Data = null

            };
             
        }
    }
}

