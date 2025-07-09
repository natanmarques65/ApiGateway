using Microsoft.AspNetCore.Mvc;

namespace ApiGateway.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class AutoTest : ControllerBase
    {
        public async Task<ActionResult<int>> GetAutoTest() { return Ok(200); }
    }
}
