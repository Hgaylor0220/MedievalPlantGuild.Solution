using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MedievalPlantGuild.Models;
using Microsoft.EntityFrameworkCore;


namespace MedievalPlantGuild.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
        private MedievalPlantGuildContext _db;

        public PlantsController(MedievalPlantGuildContext db)
        {
            _db = db;
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Plant plant)
        {
            plant.PlantId = id;
            _db.Entry(plant).State = EntityState.Modified;
            _db.SaveChanges();
        }
        [HttpGet("{id}")]
        public ActionResult<Plant> Get(int id)
        {
            return _db.Plants.FirstOrDefault(entry => entry.PlantId == id);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var plantToDelete = _db.Plants.FirstOrDefault(entry => entry.PlantId == id);
            _db.Plants.Remove(plantToDelete);
            _db.SaveChanges();
        }

        // GET api/plants
        [HttpGet]
        public ActionResult<IEnumerable<Plant>> Get(string commonname, string latinname, string habitat, string identification, string uses, bool poisonous )
        {
            var query = _db.Plants.AsQueryable();

            if (commonname != null)
            {
                query = query.Where(entry => entry.CommonName.Contains(commonname));
            }

            if (latinname != null)
            {
                query = query.Where(entry => entry.LatinName.Contains(latinname));
            }

            if (habitat != null)
            {
                query = query.Where(entry => entry.Habitat.Contains(habitat));
            }

            if (identification != null)
            {
                query = query.Where(entry => entry.Identification.Contains(identification));
            }

            if (uses != null)
            {
                query = query.Where(entry => entry.Uses.Contains(uses));
            }

            if (poisonous == false)
            {
                query = query.Where(entry => entry.Poisonous == false);
            }
            else if (poisonous == true)
            {
                query = query.Where(entry => entry.Poisonous == true);
            }

        
            return query.ToList();
        }

        // POST api/plants
        [HttpPost]
        public void Post([FromBody] Plant plant)
        {
            _db.Plants.Add(plant);
            _db.SaveChanges();
        }
    }
}