using GL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GL.Controllers
{
    public class PlayersController : Controller
    {
        public ViewResult Index()
        {
            var players = GetPlayers();

            return View(players);
        }

        public ActionResult Details(int id)
        {
            var player = GetPlayers().SingleOrDefault(c => c.Id == id);

            if (player == null)
                return HttpNotFound();

            return View(player);
        }

        private IEnumerable<Player> GetPlayers()
        {
            return new List<Player>
            {
                new Player { Id = 1, Name = "John Smith"},
                new Player { Id = 2, Name = "Mary Williams"}
            };
        }
    }
}