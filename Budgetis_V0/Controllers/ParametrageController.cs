using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Budgetis_V0.ViewModel;
using Budgetis_V0.Models;

namespace Budgetis_V0.Controllers
{
    public class ParametrageController : Controller
    {
        // GET: Parametrage
        private ApplicationDbContext _context;
        public ParametrageController()
        {
            _context = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var viewmodel = new DeviseIncomeViewModel
            {
                income = _context.Incomes.FirstOrDefault(),
                Devises=_context.Devises.ToList()
            };
            return View(viewmodel);
        }

        public ActionResult Save(DeviseIncomeViewModel incomeViewModel)
        {
            var incomeBD = _context.Incomes.SingleOrDefault();
            incomeBD.IncomeValue = incomeViewModel.income.IncomeValue;
            incomeBD.DeviseID = incomeViewModel.Devises.SingleOrDefault(o => o.IsSelected == true).ID;
            _context.SaveChanges();
            return View("Index");
        }
        

     }
}