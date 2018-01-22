using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Budgetis_V0.Models;

namespace Budgetis_V0.Controllers
{
    public class RechercheController : Controller
    {
        ApplicationDbContext _context;
        public RechercheController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Recherche
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RechercheTout()
        {
            var listUsers = _context.UsersTest.ToList();
            return View(listUsers);
        }


        public ActionResult ResultatsRecherche()
        {
            var listUsers = _context.UsersTest.ToList();
            return PartialView("_resultatRecherche", listUsers);
        }

    }
}