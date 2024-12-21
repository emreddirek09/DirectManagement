using DirectManagement.APP.Features.Commands.FRole.AssignRole;
using DirectManagement.APP.Features.Commands.FRole.CreateRole;
using DirectManagement.APP.Features.Queries.FUser.GetAllUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DirectManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("AssignRole")]
        public async Task<IActionResult> AssignRole()
        {
            GetAllUsersQueryResponse response = await _mediator.Send(new GetAllUsersQueryRequest());

            return Ok(response);

        }

        [HttpPost("AddRole")]
        public async Task<IActionResult> AddRole([FromBody] CreateRoleCommandRequest model)
        {
            if (ModelState.IsValid)
            {

                CreateRoleCommandResponse res = await _mediator.Send(model);
                return Ok(res);
            }

            return BadRequest(ModelState);
        }
        [HttpPost("AssignRole")]
        public async Task<IActionResult> AssignRole([FromBody] AssignRoleCommandRequest model)
        {
            if (ModelState.IsValid)
            {

                AssignRoleCommandResponse res = await _mediator.Send(model);

                return Ok(res);
            }

            return BadRequest(ModelState);
        }
    }
}
