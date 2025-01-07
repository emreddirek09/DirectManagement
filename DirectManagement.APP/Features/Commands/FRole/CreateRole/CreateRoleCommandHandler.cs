using DirectManagement.APP.Constants;
using DirectManagement.DOMAIN;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Features.Commands.FRole.CreateRole
{
    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommandRequest, CreateRoleCommandResponse>
    {
        private readonly RoleManager<AppRole> _roleManager;

        public CreateRoleCommandHandler(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<CreateRoleCommandResponse> Handle(CreateRoleCommandRequest request, CancellationToken cancellationToken)
        {
            try
            {
                if (!await _roleManager.RoleExistsAsync(request.RoleName))
                {
                    var result = await _roleManager.CreateAsync(new()
                    {
                        Name = request.RoleName
                    });
                    if (result.Succeeded)
                        return new CreateRoleCommandResponse
                        {
                            Success = true,
                            Message = Messages.RegisterSuccess
                        };
                }

            }
            catch (Exception ex)
            {

                return new CreateRoleCommandResponse
                {
                    Success = false,
                    Message = ex.Message.Trim().ToString()
                };
            }
            return new CreateRoleCommandResponse
            {
                Success = false,
                Message = Messages.RegisterFailed
            };

        }
    }
}
