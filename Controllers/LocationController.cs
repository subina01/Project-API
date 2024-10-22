using Carrental.WebAPI.Data;
using Carrental.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carrental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LocationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all Locations
        [HttpGet]
        [Route("GetLocations")]
        public IActionResult GetLocations()
        {
            return Ok(_context.Locations.ToList());
        }

        // Get a specific Location by ID
        [HttpGet]
        [Route("GetLocation/{id}")]
        public IActionResult GetLocation(int id)
        {
            var location = _context.Locations.FirstOrDefault(x => x.Id == id);
            if (location == null)
            {
                return NoContent();
            }
            return Ok(location);
        }

        // Add a new Location
        [HttpPost]
        [Route("AddLocation")]
        public IActionResult AddLocation( Location location)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Locations.Add(location);
            _context.SaveChanges();

            return Ok("Location added successfully");
        }

        // Update a Location
        [HttpPut]
        [Route("UpdateLocation/{id}")]
        public IActionResult UpdateLocation(int id, Location location)
        {
            var existingLocation = _context.Locations.FirstOrDefault(x => x.Id == id);
            if (existingLocation == null)
            {
                return BadRequest("Location not found");
            }

            existingLocation.Place = location.Place;

            _context.SaveChanges();

            return Ok("Location updated successfully");
        }

        // Delete a Location
        [HttpDelete]
        [Route("DeleteLocation/{id}")]
        public IActionResult DeleteLocation(int id)
        {
            var location = _context.Locations.FirstOrDefault(x => x.Id == id);
            if (location == null)
            {
                return BadRequest("Location not found");
            }

            _context.Locations.Remove(location);
            _context.SaveChanges();
            _context.ReseedAllTables();

            return Ok("Location deleted successfully");
        }

    }
}
