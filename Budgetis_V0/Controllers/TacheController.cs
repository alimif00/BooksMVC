using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Budgetis_V0.Models;


namespace Budgetis_V0.Controllers
{
    public class TacheController : Controller
    {
        // GET: Tache
        public ActionResult Index()
        {
            return View();
        }


        //public ActionResult Liste(int? id)
        //{
        //    ListeTache listTask = new ListeTache();
        //    listTask.taches = new List<Tache> {
        //        new Tache() {id=1, description="Payer la facture",cout=150.00},
        //        new Tache() {id=2, description="Ranger la maison"},
        //        new Tache() {id=3, description="Course BIM",cout=200.00}

        //    };
        //    return View(listTask);
        //}



        public ActionResult Liste(int? id)
        {
            List<Tache> listTask = getTaches();
            return View(listTask);
        }



        public ActionResult Detail(int id)
        {
            var task = getTaches().SingleOrDefault(c => c.id == id);
           
                     if (task == null)
                              return HttpNotFound();
            
                     return View(task);
        }


        private List<Tache> getTaches()
        {
            return new List<Tache>
            {
                new Tache() {id=1, description="Payer la facture",cout=150.00},
                new Tache() {id=2, description="Ranger la maison"},
                new Tache() {id=3, description="Course BIM",cout=200.00}
            };

        }


    }
}