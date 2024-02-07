using E_Commerce_Api.Concrete;
using E_Commerce_Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly Context _context;

    public WeatherForecastController(Context context)
    {

        _context = context;
    }

   
    
    [HttpGet(Name = "users")]
    public IEnumerable<User> Get()
    {
        

        var user = _context.Users.ToList();

        return user;
    }
}

