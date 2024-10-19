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


        // Get all Vehicles with Images
        [HttpGet]
        [Route("GetVehicles")]
        public IActionResult GetVehicles()
        {
            var vehicles = _context.Vehicles.ToList();

            
            foreach (var vehicle in vehicles)
            {
                if (vehicle.ImagePaths != null)
                {
                    vehicle.ImagePaths = vehicle.ImagePaths.Select(path => $"{Request.Scheme}://{Request.Host}/vehicle-images/{Path.GetFileName(path)}").ToList();
                }
            }

            return Ok(vehicles);
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

            if (vehicle.ImagePaths != null)
            {
                vehicle.ImagePaths = vehicle.ImagePaths.Select(path => $"{Request.Scheme}://{Request.Host}/vehicle-images/{Path.GetFileName(path)}").ToList();
            }

            return Ok(vehicle);
        }



     


        // Add a new Vehicle
        [HttpPost]
        [Route("AddVehicle")]
        public async Task<IActionResult> AddVehicle([FromForm] Vehicle vehicle, List<IFormFile> imageFiles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            vehicle.ImagePaths = new List<string>(); 

            
            foreach (var imageFile in imageFiles)
            {
                if (imageFile != null && imageFile.Length > 0)
                {
                    var fileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
                    var fileExtension = Path.GetExtension(imageFile.FileName);
                    var filePath = Path.Combine(_imageDirectory, $"{fileName}_{DateTime.Now.Ticks}{fileExtension}");

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }

                    vehicle.ImagePaths.Add(filePath); 
                }
            }

            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();

            return Ok("Vehicle added successfully");
        }


        // Update an existing Vehicle
        [HttpPut]
        [Route("UpdateVehicle/{id}")]
        public async Task<IActionResult> UpdateVehicle(int id, [FromForm] Vehicle vehicle, List<IFormFile> imageFiles)
        {
            var existingVehicle = await _context.Vehicles.FindAsync(id);
            if (existingVehicle == null)
            {
                return BadRequest("Vehicle not found");
            }

            existingVehicle.Price = vehicle.Price;
            existingVehicle.Detail = vehicle.Detail;

           
            existingVehicle.ImagePaths = existingVehicle.ImagePaths ?? new List<string>(); 

            foreach (var imageFile in imageFiles)
            {
                if (imageFile != null && imageFile.Length > 0)
                {
                    var fileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
                    var fileExtension = Path.GetExtension(imageFile.FileName);
                    var filePath = Path.Combine(_imageDirectory, $"{fileName}_{DateTime.Now.Ticks}{fileExtension}");

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }

                    existingVehicle.ImagePaths.Add(filePath); 
                }
            }

            existingVehicle.Popular = vehicle.Popular;
            existingVehicle.Damage = vehicle.Damage;
            existingVehicle.Available = vehicle.Available;
            existingVehicle.ModelId = vehicle.ModelId;
            existingVehicle.BrandId = vehicle.BrandId;
            existingVehicle.CategoryId = vehicle.CategoryId;
            existingVehicle.UserName = vehicle.UserName;
            existingVehicle.Remarks = vehicle.Remarks;

            await _context.SaveChangesAsync();

            return Ok("Vehicle updated successfully");
        }


        // Get Image by Vehicle ID (to return all images)
        [HttpGet]
        [Route("GetVehicleImages/{id}")]
        public IActionResult GetVehicleImages(int id)
        {
            var vehicle = _context.Vehicles.FirstOrDefault(x => x.VehicleId == id);
            if (vehicle == null || vehicle.ImagePaths == null || !vehicle.ImagePaths.Any())
            {
                return NotFound();
            }

            var imageUrls = vehicle.ImagePaths.Select(path => $"{Request.Scheme}://{Request.Host}/vehicle-images/{Path.GetFileName(path)}").ToList();
            return Ok(imageUrls);
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

            
            if (vehicle.ImagePaths != null)
            {
                foreach (var imagePath in vehicle.ImagePaths)
                {
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }
            }

            _context.Vehicles.Remove(vehicle);
            _context.SaveChanges();

            return Ok("Vehicle deleted successfully");
        }

        // Get all Vehicles by Category
        [HttpGet]
        [Route("GetVehiclesByCategory/{categoryId}")]
        public IActionResult GetVehiclesByCategory(int categoryId)
        {
            var vehicles = _context.Vehicles
                .Where(v => v.CategoryId == categoryId)
                .ToList();

            
            foreach (var vehicle in vehicles)
            {
                if (vehicle.ImagePaths != null)
                {
                    vehicle.ImagePaths = vehicle.ImagePaths
                        .Select(path => $"{Request.Scheme}://{Request.Host}/vehicle-images/{Path.GetFileName(path)}")
                        .ToList();
                }
            }

            return Ok(vehicles);
        }

        // Get all Popular Vehicles
        [HttpGet]
        [Route("GetPopularVehicles")]
        public IActionResult GetPopularVehicles()
        {
            var vehicles = _context.Vehicles
                .Where(v => v.Popular == "Yes" || v.Popular == "yes")
                .ToList();

            foreach (var vehicle in vehicles)
            {
                if (vehicle.ImagePaths != null)
                {
                    vehicle.ImagePaths = vehicle.ImagePaths
                        .Select(path => $"{Request.Scheme}://{Request.Host}/vehicle-images/{Path.GetFileName(path)}")
                        .ToList();
                }
            }

            return Ok(vehicles);
        }



    }
}
