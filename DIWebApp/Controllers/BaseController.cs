using Microsoft.AspNetCore.Mvc;

namespace DIWebApp;

[ApiController]
[Route("[controller]")]
public class BaseController(ILogger<BaseController> logger) : ControllerBase
{

  [HttpGet]
  public void Get() => logger.LogInformation("Hello, World! Training DI in web apps.");
}
