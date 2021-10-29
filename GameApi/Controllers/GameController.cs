using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApi.Handlers;
using GameLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GameApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        DbHandler dbh = new DbHandler();
        public GameController()
        {

        }
        [HttpGet("Heroes")]
        public List<Hero> GetHeroList()
        {
            return this.dbh.GetHeroes();
        }
        [HttpGet("Villains")]
        public List<Villain> GetVillainList()
        {
            return this.dbh.GetVillains();
        }
        [HttpPost("Game")]
        public string UploadGame(string win)
        {
            return this.dbh.UploadGame(win);
        }
        [HttpDelete("Heroes")]
        public string DeleteHero()
        {
            throw new System.NotImplementedException();
        }
        public string DeleteVillain()
        {
            throw new System.NotImplementedException();
        }
        public string DeleteGame()
        {
            throw new System.NotImplementedException();
        }
    }


}