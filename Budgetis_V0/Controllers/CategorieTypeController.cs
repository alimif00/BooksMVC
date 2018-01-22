using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Budgetis_V0.ViewModel;
using Budgetis_V0.Models;

namespace Budgetis_V0.Controllers
{
    public class CategorieTypeController : Controller
    {
        ApplicationDbContext _context;
        public CategorieTypeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: CategorieType
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateCategorie()
        {
            var viewModel = new CategorieTypeViewModel
            {
                TypesCategory = getAllTypes(),
                categorie = new Categorie(),
                TypeCat = new TypeCategorie()
            };
            return View(viewModel);
        }


        public ActionResult DeleteType(int id)
        {
            var typeToDelete = _context.TypesCategorie.Single(o => o.Id==id);
            
            _context.TypesCategorie.Remove(typeToDelete);
            _context.SaveChanges();
            return RedirectToAction("CreateCategorie");
        }

        public ActionResult AddType(TypeCategorie viewmodel)
        {
            var NewtypeCate = new TypeCategorie { Id=4,CategorieID = viewmodel.CategorieID, Libelle = viewmodel.Libelle, Description = viewmodel.Description };

            _context.TypesCategorie.Add(NewtypeCate);
            _context.SaveChanges();
            
            return RedirectToAction("CreateCategorie");
        }


       




        public List<TypeCategorie> getAllTypes()
        {
            return _context.TypesCategorie.ToList();
            //return new List<TypeCategorie> {
            //    new TypeCategorie { Id=1, Libelle="Loyer", Description="Versement du loyer - Maison Florida Casablanca" },
            //    new TypeCategorie { Id=2, Libelle="Electricité", Description="Facture elecrticité ONEE" },
            //    new TypeCategorie { Id=3, Libelle="Eau", Description="Facture Eau Lydec" }
            //};
        }


        //public List<TypeCategorie> getTypesByCategorie(int id)
        //{

        //}
    }
}