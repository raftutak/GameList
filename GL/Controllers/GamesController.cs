using GL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GL.Controllers
{
    public class GamesController : Controller
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Game game)
        {
            if (game.Id == 0)
                _context.Games.Add(game);
            else
            {
                var gameInDb = _context.Games.Single(c => c.Id == game.Id);

                gameInDb.Name = game.Name;
                gameInDb.Genre = game.Genre;
                gameInDb.Distributor = game.Distributor;
                gameInDb.ReleaseYear = game.ReleaseYear;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Games");
        }

        public ViewResult Index()
        {
            var games = _context.Games.ToList();

            return View(games);
        }

        public ActionResult Details(int id)
        {
            var game = _context.Games.SingleOrDefault(c => c.Id == id);

            if (game == null)
                return HttpNotFound();

            return View(game);
        }

        public ActionResult Edit(int id)
        {
            var game = _context.Games.SingleOrDefault(c => c.Id == id);

            if (game == null)
                return HttpNotFound();

            return View("GameForm", game);
        }
    }
}