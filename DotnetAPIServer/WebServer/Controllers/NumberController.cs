using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Extensions.Logging;
using WebServer.Process;
using WebServer.NumberGeneration;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberController : ControllerBase
    {
        [HttpGet]
        public JsonResult Get()
        {
            NumerAndWord numerAndWord = new NumerAndWord();
            return new JsonResult(numerAndWord.GetNumerAndWord());
        }
    }

}






