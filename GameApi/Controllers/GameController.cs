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
        [HttpGet("Game")]
        public List<Game> GetGames()
        {
            return this.dbh.GetGames();
        }
        [HttpPost("Game")]
        public int UploadGameS(string win)
        {
            return this.dbh.UploadGame(win);
        }
        [HttpDelete("Heroes")]
        public string DeleteHero()
        {
            throw new System.NotImplementedException();
        }
        [HttpDelete("Villains")]
        public string DeleteVillain()
        {
            throw new System.NotImplementedException();
        }
        [HttpDelete("Game")]
        public string DeleteGame()
        {
            throw new System.NotImplementedException();
        }
    }


}