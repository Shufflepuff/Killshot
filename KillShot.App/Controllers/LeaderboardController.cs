using KillShot.App.DAL;
using KillShot.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KillShot.App.Controllers
{
    public class LeaderboardController : ApiController
    {

        public IPlayerRepository _repo { get; set; }

        public LeaderboardController(IPlayerRepository repo)
        {
            _repo = repo;
        }

        [Route("api/players")]
        public List<Player> GetAll()
        {
            var players = _repo.GetAllPlayers().ToList();
            return players;
        }
    }
}
