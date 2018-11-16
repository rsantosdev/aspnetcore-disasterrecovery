using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCore.DisasterRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            var tz = TimeZoneInfo.Local;
            return Ok(new {
                tz.Id,
                tz.DisplayName,
                time = DateTime.Now.ToUniversalTime(),
                utc = DateTime.UtcNow.ToUniversalTime()
            });
        }
    }
}
