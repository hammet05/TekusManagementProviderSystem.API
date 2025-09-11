using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tekus.ManagementProvider.Application.Services.GetServicesByCountryCode;

namespace Tekus.ManagementProvider.API.Controllers
{
    [Route("api/service")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetServicesByCountry/{countryCode}")]
        public async Task<ActionResult<IEnumerable<IActionResult>>> GetServicesByCountry(string countryCode)
        {
            var query = new GetServicesByCountryCodeQuery(countryCode);

            var result = await _mediator.Send(query);

            return result.IsSuccess ? Ok(result.Value) : NotFound();
        }
    }
}
