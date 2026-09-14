using Microsoft.AspNetCore.Mvc;

namespace MyFirstCloudApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TimeController : ControllerBase
{
    // GET /time
    [HttpGet]
    [HttpGet("time1")]
    public IActionResult Time1()
    {
        return Ok(new
        {
            Service = "Cloud Time1 Service",
            CurrentUtcTime = DateTime.UtcNow,
            Message = "Hello from Azure Time1"
        });
    }

    // GET /time
    [HttpGet("time2")]
    public IActionResult Time2()
    {
        return Ok(new
        {
            Service = "Cloud Time2 Service",
            CurrentUtcTime = DateTime.UtcNow,
            Message = "Hello from Azure Time2"
        });
    }
}