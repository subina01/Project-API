using Carrental.WebAPI.Data;
using Carrental.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace Carrental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly string _imageDirectory = "wwwroot/vehicle-images"; 

        public VehicleController(ApplicationDbContext context)
        {
            _context = context;

            if (!Directory.Exists(_imageDirectory))
            {
                Directory.CreateDirectory(_imageDirectory);
            }
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

            // Handle image file
            if (imageFile != null && imageFile.Length > 0)
            {
                var fileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
                var fileExtension = Path.GetExtension(imageFile.FileName);
                var filePath = Path.Combine(_imageDirectory, $"{fileName}_{DateTime.Now.Ticks}{fileExtension}");

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                vehicle.ImagePath = filePath; // Save the file path to the database
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

            // Handle image file update
            if (imageFile != null && imageFile.Length > 0)
            {
                var fileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
                var fileExtension = Path.GetExtension(imageFile.FileName);
                var filePath = Path.Combine(_imageDirectory, $"{fileName}_{DateTime.Now.Ticks}{fileExtension}");

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                existingVehicle.ImagePath = filePath;
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
            if (vehicle == null || string.IsNullOrEmpty(vehicle.ImagePath))
            {
                return NotFound();
            }

            var image = System.IO.File.OpenRead(vehicle.ImagePath);
            return File(image, "image/jpeg");
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

            // Delete the associated image file
            if (!string.IsNullOrEmpty(vehicle.ImagePath) && System.IO.File.Exists(vehicle.ImagePath))
            {
                System.IO.File.Delete(vehicle.ImagePath);
            }

            _context.Vehicles.Remove(vehicle);
            _context.SaveChanges();

            return Ok("Vehicle deleted successfully");
        }
    }
}
