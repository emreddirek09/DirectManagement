using DirectManagement.APP.Constants;
using DirectManagement.APP.Features.Commands.FMain.CreateMain;
using DirectManagement.DOMAIN;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Features.Commands.FRole.AssignRole
{
    public class AssignRoleCommandHandler : IRequestHandler<AssignRoleCommandRequest, AssignRoleCommandResponse>
    {
        private readonly UserManager<AppUser> _userManager;

        public AssignRoleCommandHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<AssignRoleCommandResponse> Handle(AssignRoleCommandRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(request.UserName);
                if (user == null)
                    return new AssignRoleCommandResponse()
                    {
                        Success = false,
                        Message = Messages.NotFound,
                    };

                var result = await _userManager.AddToRoleAsync(user, request.RoleName);
                if (result.Succeeded)
                    return new AssignRoleCommandResponse()
                    {
                        Success = true,
                        Message = Messages.RegisterSuccess
                    };
                else
                {
                    foreach (var item in result.Errors)
                    {
                        if (item.Code == "UserAlreadyInRole")
                        {

                            return new AssignRoleCommandResponse()
                            {
                                Success = true,
                                Message = Messages.RegisterFailed
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                return new AssignRoleCommandResponse
                {
                    Success = false,
                    Message = ex.Message.Trim().ToString()
                };
            }
            return new AssignRoleCommandResponse
            {
                Success = false,
                Message = Messages.RegisterFailed
            };

        }
    }

}