using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tekus.ManagementProvider.Application.Providers.CreateProvider;

namespace Tekus.ManagementProvider.API.Controllers
{
    [Route("api/provider")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProviderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProviderCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);

        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            // Todo GET by Id
            return Ok();
        }
    }
}
