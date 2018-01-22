using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Budgetis_V0.Models;
using Budgetis_V0.ViewModel;


namespace Budgetis_V0.Controllers
{
    public class TacheController : Controller
    {
        private ApplicationDbContext _context;

        public TacheController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Tache
        public ActionResult Index()
        {
            var listTaches = _context.Taches.ToList();

            return View(listTaches);
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



      



        public ActionResult Detail(int? id)
        {
            if (id!=0)
            { 
            var task = _context.Taches.SingleOrDefault(c => c.id == id);
           
                     if (task == null)
                              return HttpNotFound();

                var viewModel = new TacheCategorieTypeViewModel
                {
                    Categories = _context.Categories.ToList(),
                    tache = task,
                    TypeCategories = _context.TypesCategorie.ToList()

                };
                     return View(viewModel);
            }else
            {
                return HttpNotFound();
            }
        }


        public ActionResult AjoutTache()
        {
            var viewModel = new TacheCategorieTypeViewModel
            {
                Categories = _context.Categories.ToList(),
                tache = new Tache(),
                TypeCategories = _context.TypesCategorie.ToList()

            };
            return View(viewModel);
        }


        public ActionResult PlanifierTache()
        {
            var viewModel = new TacheCategorieTypeViewModel
            {
                Categories = _context.Categories.ToList(),
                tache = new Tache(),
                TypeCategories = _context.TypesCategorie.ToList()

            };
            return View(viewModel);
        }

        public ActionResult Save(Tache tache)
        {
            
            var taches = _context.Taches.ToList();

            var tacheInDb = taches.SingleOrDefault(c => c.id == tache.id);
            if (tacheInDb == null)
            {
                tache.dateEstimation = DateTime.Now;
                tache.isFinished = true;
                taches.Add(tache);
            }
            else
            {
                tacheInDb.isFinished = tache.isFinished;
                tacheInDb.libelle = tache.libelle;
                tacheInDb.typeCategorie = tache.typeCategorie;
                tacheInDb.description = tache.description;
                tacheInDb.dateExecution = tache.dateExecution;
                tacheInDb.dateEstimation = tache.dateEstimation;
                tacheInDb.cout = tache.cout;
            }
            _context.SaveChanges();

         
            return View("Index", taches);
        }


        public ActionResult SavePlanif(Tache tache)
        {
            var taches = _context.Taches.ToList();
            taches.Add(tache);
            _context.SaveChanges();

           
            return View("Index", taches);
        }
    }
}