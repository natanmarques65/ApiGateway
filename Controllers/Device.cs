using ApiGateway.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiGateway.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        public async Task<ActionResult<int>> PutDeviceRecord([FromBody] Device device)
        {
            try
            {
                return Ok(200);
            }
            catch (Exception ex)
            {
                return BadRequest(400);
            }
        }
    }
}
