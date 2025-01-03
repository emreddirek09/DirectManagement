﻿using DirectManagement.APP.Features.Queries.FUser.GetAllUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DirectManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("GetAllUser")]
        public async Task<IActionResult> GetAllUser([FromQuery] GetAllUsersQueryRequest model)
        {
            if (ModelState.IsValid)
            {
                GetAllUsersQueryResponse res = await _mediator.Send(model);

                return Ok(res);
            }

            return NoContent();
        }
    }
}
