using Microsoft.AspNetCore.Mvc;

namespace WebAPP;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet("ActionResult")]
    public ActionResult<string> GetActionResult()
    {
        // return "Hello World!";
        return Ok("Hello World!");
    }

    [HttpGet("IActionResult")]
    public IActionResult GetIActionResult()
    {
        return Ok("Hello World!");
    }
}
