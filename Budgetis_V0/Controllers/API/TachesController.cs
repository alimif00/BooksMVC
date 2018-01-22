using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using Budgetis_V0.Models;
using Budgetis_V0.Dtos;
using AutoMapper;

namespace Budgetis_V0.Controllers.API
{
    public class TachesController : ApiController
    {

        private ApplicationDbContext _context;
        public TachesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose(); 
        }





        //GET  /API/Taches
        public IEnumerable<TacheDto> GetTaches()
        {
            return _context.Taches
                .Include(c => c.typeCategorie)
                .ToList()
                .Select(Mapper.Map<Tache,TacheDto>);
        }




        //GET  /API/Taches/1
        public IHttpActionResult GetTache(int id)
        {
            var tache = _context.Taches.SingleOrDefault(o => o.id == id);

            if (tache == null)
                return NotFound();

            return Ok(Mapper.Map<Tache,TacheDto>(tache));
        }





        // POST  /API/Taches
        [HttpPost]
        public IHttpActionResult CreateTache(TacheDto tacheDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var tache = Mapper.Map<TacheDto, Tache>(tacheDto);

            _context.Taches.Add(tache);
            _context.SaveChanges();

            tacheDto.id = tache.id;
            return Created(new Uri(Request.RequestUri+"/"+tache.id), tacheDto);
        }

        // PUT  /API/Taches/1
        [HttpPut]
        public void UpdateTache(int id, TacheDto tacheDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var tacheInDb = _context.Taches.SingleOrDefault(o => o.id == id);

            if (tacheInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(tacheDto, tacheInDb);

            _context.SaveChanges();
        }

        // DELETE  /API/Taches/1
        [HttpDelete]
        public void DeleteTache(int id)
        {
            var tacheInDb = _context.Taches.SingleOrDefault(o => o.id == id);

            if (tacheInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Taches.Remove(tacheInDb);
            _context.SaveChanges();
        }
    }
}
