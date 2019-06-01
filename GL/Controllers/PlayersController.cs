using GL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GL.Controllers
{
    public class PlayersController : Controller
    {
        private ApplicationDbContext _context;

        public PlayersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var players = _context.Players.ToList();

            return View(players);
        }

        public ActionResult Details(int id)
        {
            var player = _context.Players.SingleOrDefault(c => c.Id == id);

            if (player == null)
                return HttpNotFound();

            return View(player);
        }
    }
}