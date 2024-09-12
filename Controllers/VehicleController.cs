using Carrental.WebAPI.Data;
using Carrental.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carrental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VehicleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all Vehicles
        [HttpGet]
        [Route("GetVehicles")]
        public IActionResult GetVehicles()
        {
            return Ok(_context.Vehicles.ToList());
        }

        // Get a specific Vehicle by ID
        [HttpGet]
        [Route("GetVehicle/{id}")]
        public IActionResult GetVehicle(int id)
        {
            var vehicle = _context.Vehicles.FirstOrDefault(x => x.VehicleId == id);
            if (vehicle == null)
            {
                return NoContent();
            }
            return Ok(vehicle);
        }

        // Add a new Vehicle
        [HttpPost]
        [Route("AddVehicle")]
        public async Task<IActionResult> AddVehicle([FromForm] Vehicle vehicle, IFormFile imageFile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (imageFile != null && imageFile.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await imageFile.CopyToAsync(memoryStream);
                    vehicle.Image = memoryStream.ToArray();
                }
            }

            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();

            return Ok("Vehicle added successfully");
        }

        // Update an existing Vehicle
        [HttpPut]
        [Route("UpdateVehicle/{id}")]
        public async Task<IActionResult> UpdateVehicle(int id, [FromForm] Vehicle vehicle, IFormFile imageFile)
        {
            var existingVehicle = _context.Vehicles.FirstOrDefault(x => x.VehicleId == id);
            if (existingVehicle == null)
            {
                return BadRequest("Vehicle not found");
            }

            existingVehicle.Price = vehicle.Price;
            existingVehicle.Detail = vehicle.Detail;

            if (imageFile != null && imageFile.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await imageFile.CopyToAsync(memoryStream);
                    existingVehicle.Image = memoryStream.ToArray();
                }
            }
            else
            {
                existingVehicle.Image = vehicle.Image;
            }

            existingVehicle.Popular = vehicle.Popular;
            existingVehicle.Damage = vehicle.Damage;
            existingVehicle.Available = vehicle.Available;
            existingVehicle.ModelId = vehicle.ModelId;
            existingVehicle.BrandId = vehicle.BrandId;
            existingVehicle.CategoryId = vehicle.CategoryId;
            existingVehicle.UserName = vehicle.UserName;
            existingVehicle.Remarks = vehicle.Remarks;

            _context.SaveChanges();

            return Ok("Vehicle updated successfully");
        }

        // Get Image by Vehicle ID
        [HttpGet]
        [Route("GetVehicleImage/{id}")]
        public IActionResult GetVehicleImage(int id)
        {
            var vehicle = _context.Vehicles.FirstOrDefault(x => x.VehicleId == id);
            if (vehicle == null || vehicle.Image == null)
            {
                return NotFound();
            }

            return File(vehicle.Image, "image/jpeg"); 
        }

        // Delete a Vehicle
        [HttpDelete]
        [Route("DeleteVehicle/{id}")]
        public IActionResult DeleteVehicle(int id)
        {
            var vehicle = _context.Vehicles.FirstOrDefault(x => x.VehicleId == id);
            if (vehicle == null)
            {
                return BadRequest("Vehicle not found");
            }

            _context.Vehicles.Remove(vehicle);
            _context.SaveChanges();

            return Ok("Vehicle deleted successfully");
        }

    }
}
