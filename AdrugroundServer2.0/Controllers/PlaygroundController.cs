using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdrugroundServer2._0.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace AdrugroundServer2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaygroundController : ControllerBase
    {
        public static List<Playground> playgrounds = new List<Playground>();

        //api/playground
        [HttpGet]
        public string Get()
        {
            return JsonConvert.SerializeObject(playgrounds);
        }

        //api/playground/5
        [HttpPost("{id}")]
        public ActionResult<string> Post([FromForm]string name)
        {
            int id = playgrounds.Count + 1;

            var newPlayground = new Playground(playgrounds.Count, name, id, new Player(100,"차재훈"));
            var i = 0;
            while (i < playgrounds.Count)
            {
                if (playgrounds[i].playGroundName == name)
                {
                    this.Response.StatusCode = 403;
                    return JsonConvert.SerializeObject(new { StatusCode = "403", Responcse = "Duplicate name" });
                }
                i++;
            }
            playgrounds.Add(newPlayground);
            this.Response.StatusCode = 201;
            return JsonConvert.SerializeObject(new { StatusCode = "201", Responcse = "created" });

        }

      //  [HttpPut("id")]
    }
}