using DirectManagement.APP.BaseResult.Concretes;
using DirectManagement.APP.Features.Commands.FMain.CreateMain;
using DirectManagement.APP.Features.Commands.FUser.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DirectManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        readonly private IMediator _mediator;

        public MainController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddMain")]
        public async Task<IActionResult> AddMain([FromBody] CreateMainCommandRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _mediator.Send(model);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
