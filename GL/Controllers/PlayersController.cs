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

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Player player)
        {
            if (player.Id == 0)
                _context.Players.Add(player);
            else
            {
                var playerInDb = _context.Players.Single(c => c.Id == player.Id);

                playerInDb.Name = player.Name;
                playerInDb.BirthDate = player.BirthDate;
                playerInDb.PlayerGender = player.PlayerGender;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Players");
        }

        [Authorize]
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

        public ActionResult Edit(int id)
        {
            var player = _context.Players.SingleOrDefault(c => c.Id == id);

            if (player == null)
                return HttpNotFound();

            return View("PlayerForm", player);
        }
    }
}