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
        public ActionResult<IEnumerable<Plant>> Get()
        {
            return _db.Plants.ToList();
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