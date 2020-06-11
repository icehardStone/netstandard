using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using sample_authorication.Authrozation;

namespace sample_authorication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public readonly ILogger<WeatherForecastController> _logger;
        public readonly IConfiguration _configuration;
        public AuthController(ILogger<WeatherForecastController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
        [HttpPost("Taken")]
        public void Taken([FromBody]User user)
        {
            string key = _configuration.GetSection("ScretKey").Value;
            string jwtString = JwtValidator.ProduceJwt(key, user);
            HttpContext.Response.Cookies.Append("Auth", jwtString);
        }
        [HttpPost("ValidateTaken")]
        public void ValidateTaken([FromHeader]string taken)
        {
            string key = _configuration.GetSection("ScretKey").Value;
            var user = JwtValidator.ValidateJwt(key, taken);
        }
    }
}