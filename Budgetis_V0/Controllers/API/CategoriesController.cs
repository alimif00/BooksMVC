using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using Budgetis_V0.Models;

namespace Budgetis_V0.Controllers.API
{
    public class CategoriesController : ApiController
    {
        private ApplicationDbContext _context;
        public CategoriesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        //GET   /API/Categories/
        public IEnumerable<Categorie> GetAllCategories()
        {
            var categories = _context.Categories.ToList();

            return categories;
        }

        //GET  /API/TypeCategories/1
     

    }
}
