﻿using DirectManagement.APP.Features.Commands.FUser.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DirectManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        readonly private IMediator _mediator;

        public RegisterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] CreateUserCommandRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); 
            }

            var response = await _mediator.Send(model);
            return Ok(response);
        }
    }
}
