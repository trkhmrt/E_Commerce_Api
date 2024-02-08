using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "Yagiz"
    };

    private readonly ILogger<WeatherForecastController> _logger;


}

