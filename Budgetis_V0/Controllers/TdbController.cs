using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Budgetis_V0.Models;

namespace Budgetis_V0.Controllers
{
    public class TdbController : Controller
    {

        private ApplicationDbContext _context;

        public TdbController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Tdb
        //public ActionResult Index()
        //{
        //    //List<Tache> listTask = _context.Taches.ToList();

        //    //List<Tache> listTask = _context.Taches.Where(o => o.dateExecution.Month.ToString() == DateTime.Now.Month.ToString()).ToList();



        //    return View(listTask);
            
        //}
    }
}