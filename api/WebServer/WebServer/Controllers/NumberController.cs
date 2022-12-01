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

        // Used for checking API status
        private static readonly string[] Summaries = new[]
                {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpPost("{number}")]
        public JsonResult Post(string number)
        {
                return new JsonResult(ValueConvert.NumberToWords(number));
        }

        [HttpGet]
        public JsonResult Get()
        {
            NumerAndWord numerAndWord = new NumerAndWord();
            return new JsonResult(numerAndWord.GetNumerAndWord());
            //return new JsonResult("Hello World");
        }
    }

}






