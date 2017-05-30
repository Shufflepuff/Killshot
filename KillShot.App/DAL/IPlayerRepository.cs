using KillShot.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillShot.App.DAL
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetAllPlayers();
    }
}
