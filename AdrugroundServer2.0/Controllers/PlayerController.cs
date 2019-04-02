using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AdrugroundServer2._0.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdrugroundServer2._0.Controllers
{
    [Route("api/[controller]")]
    public class PlayerController : Controller
    {
        public static List<Player> players = new List<Player>();

        // GET api/Player/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var newplayer = new Player(100, 100, "차재훈");
            players.Add(newplayer);
            return JsonConvert.SerializeObject(newplayer);
        }

        // POST api/Player
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Player/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Player/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
