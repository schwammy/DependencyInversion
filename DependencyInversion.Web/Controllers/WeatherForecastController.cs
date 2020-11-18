using DependencyInversion.ApplicationLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace DependencyInversion.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMembershipService _membershipService;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMembershipService membershipService)
        {
            _logger = logger;
            _membershipService = membershipService;
        }

        [HttpGet]
        public bool Get()
        {
            _membershipService.Join("Andy", "MyPassword");
            return true;
        }
    }
}
