using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Openlayers_backend.Models;
using proje_deneme.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace Openlayers_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly LocationDbContext _context;
        public LocationController(LocationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Location> Get()
        {
            return _context.Locations.ToList();
        }
        [HttpPost]

        public IActionResult AddEntity(Location loc)
        {
            _context.Locations.Add(loc);
            _context.SaveChanges();

            return Ok(loc.id);
        }
        [HttpDelete]
        public IActionResult DeleteEntity(Location loc)
        {

            var value = _context.Locations.Where(p => p.wkt == loc.wkt).FirstOrDefault();
            if (value == null)
            {
                return NotFound();
            }
            _context.Locations.Remove(value);
            _context.SaveChanges();
            return Ok(loc.id);
        }
        [HttpPost]
        [Route("update")]

        public IActionResult UpdateEntity(Location context)
        {
            _context.Locations.Update(context);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
