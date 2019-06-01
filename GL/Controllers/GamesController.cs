using GL.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GL.Controllers
{
    public class GamesController : Controller
    {
        public ViewResult Index()
        {
            var games = GetGames();

            return View(games);
        }

        private IEnumerable<Game> GetGames()
        {
            return new List<Game>
            {
                new Game { Id = 1, Name = "Quake"},
                new Game { Id = 2, Name = "Half-Life"}
            };
        }
    }
}