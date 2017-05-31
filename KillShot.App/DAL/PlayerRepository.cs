using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillShot.App.Models;

namespace KillShot.App.DAL
{
    public class PlayerRepository : IPlayerRepository
    {
        readonly ApplicationDbContext _context;

        public PlayerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            return _context.Players;
        }

        public bool IncrementPlayerScore(int id)
        {
            var playerToIncrement = _context.Players.FirstOrDefault(p => p.Id == id);

            if (playerToIncrement != null)
            {
                playerToIncrement.Score++;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}