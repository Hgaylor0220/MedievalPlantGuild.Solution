using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MedievalPlantGuild.Models;

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