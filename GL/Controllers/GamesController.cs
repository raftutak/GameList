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
    }
}