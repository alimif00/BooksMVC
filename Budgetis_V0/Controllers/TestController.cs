using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Budgetis_V0.Models;
using Budgetis_V0.ViewModel;

namespace Budgetis_V0.Controllers
{

    
    public class TestController : Controller
    {
        private ApplicationDbContext _context;

        public TestController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            
            var listUsers = getUsers();

           
            return View(listUsers);
        }

        public ActionResult Edit(int? id)
        {
            var socialStatus = getStatus();
            var listUsers = getUsers();

            var user = listUsers.SingleOrDefault(m => m.Id == id);

            var viewModel = new UserStatusViewModel
            {
                userM = user,
                socialStatusTypes = socialStatus

            };
            return View(viewModel);
        }

        public ActionResult Save(UserStatusViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                var viewModel2 = new UserStatusViewModel
                {
                    userM = viewModel.userM,
                    socialStatusTypes = _context.SocialStatusTypes.ToList()

                };
            return View("Edit", viewModel2);
            }

            var userModel = viewModel.userM;
            if (userModel.Id == 0)
                _context.UsersTest.Add(userModel);
            else
            {
                var userToUpdate = _context.UsersTest.Single(m => m.Id == userModel.Id);

                userToUpdate.IsMember = userModel.IsMember;
                userToUpdate.LastName = userModel.LastName;
                userToUpdate.Name = userModel.Name;
                userToUpdate.DateNaissance = userModel.DateNaissance;
                userToUpdate.SocialStatusTypeId = userModel.SocialStatusTypeId;
                
            }
            _context.SaveChanges();

            return RedirectToAction("List");
        }



        public ActionResult Create()
        {
            var viewModel = new UserStatusViewModel() { socialStatusTypes = getStatus() };
         
            return View("Edit", viewModel);
        }

        public ActionResult Delete(int id)
        {
            var userToDelete = _context.UsersTest.Single(m => m.Id == id);

            _context.UsersTest.Remove(userToDelete);
            _context.SaveChanges();

            return RedirectToAction("List");
        }











        public List<UserTest> getUsers()
        {
           var nl= new List<UserTest>();
            nl= _context.UsersTest.ToList();
            return nl;
            //return new List<UserTest>
            //{
            //    new UserTest { Id= 1 , Name="Ali", LastName="Mifdal" , DateNaissance=DateTime.Parse("07/08/1993") , SocialStatusTypeId=1 },
            //     new UserTest { Id= 2 , Name="Salah", LastName="Mifdal" , DateNaissance=DateTime.Parse("03/02/1992") , SocialStatusTypeId=2 },
            //      new UserTest { Id= 3 , Name="Syf", LastName="OIHI" , DateNaissance=DateTime.Parse("05/12/1992") , SocialStatusTypeId=3 }
            //};

        }
        public List<SocialStatusType> getStatus()
        {
            var nl = new List<SocialStatusType>();
            nl = _context.SocialStatusTypes.ToList();
            return nl;
            //return new List<SocialStatusType>
            //{
            //    new SocialStatusType { Id=1,description="In Relation",libelle="In Relation", tax= 20},

            //    new SocialStatusType { Id=2,description="Married",libelle="Married", tax= 10 },
            //    new SocialStatusType { Id=3,description="Alone",libelle="Alone", tax= 30 }
            //};

        }

    }
}