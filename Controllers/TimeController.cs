using Microsoft.AspNetCore.Mvc;

namespace MyFirstCloudApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TimeController : ControllerBase
{
    // GET /time
    [HttpGet]
    public IActionResult GetCurrentTime()
    {
        return Ok(new
        {
            Service = "Cloud Time Service MacOS",
            CurrentUtcTime = DateTime.UtcNow,
            Message = "Hello from Azure on macOS"
        });
    }
}