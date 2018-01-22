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
    public class TypeCategoriesController : ApiController
    {
        private ApplicationDbContext _context;
        public TypeCategoriesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        // GET  /API/TypeCategories/
        public IEnumerable<TypeCategorie> GetAllTypes()
        {
            var types = _context.TypesCategorie.ToList();

            return types;
        }

        //GET  /API/TypeCategories/1
        public IEnumerable<TypeCategorie> GetTypesByIdCategorie(int id)
        {
            var types = _context.TypesCategorie.Where(o => o.CategorieID == id).ToList();
            
            return types;
        }
    }
}
