using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperInfoService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeveloperInfoController : ControllerBase
    {
        [HttpGet]
        public DeveloperInfo Get()
        {
            return new DeveloperInfo
            {
                DeveloperName = "Perico Palotes",
                ProgrammingLanguage = ".Net/C#",
                Timestamp = DateTime.Now.ToString("yyyyMMddhhmmss")
            };
        }
    }
}
