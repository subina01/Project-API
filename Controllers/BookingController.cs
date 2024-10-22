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
    public class BookingController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly string _cnicImageDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "cnic-images");

        public BookingController(ApplicationDbContext context)
        {
            _context = context;

            // Ensure the directory exists
            if (!Directory.Exists(_cnicImageDirectory))
            {
                Directory.CreateDirectory(_cnicImageDirectory);
            }
        }

        // Get all Bookings
        [HttpGet]
        [Route("GetBookings")]
        public IActionResult GetBookings()
        {
            return Ok(_context.Bookings.ToList());
        }

        // Get a specific Booking by ID
        [HttpGet]
        [Route("GetBooking/{id}")]
        public IActionResult GetBooking(int id)
        {
            var booking = _context.Bookings.FirstOrDefault(x => x.Id == id);
            if (booking == null)
            {
                return NoContent();
            }
            return Ok(booking);
        }

        // Add a new Booking with CNIC image
        [HttpPost]
        [Route("AddBooking")]
        public async Task<IActionResult> AddBooking([FromForm] Booking booking, IFormFile cnicImageFile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (cnicImageFile != null && cnicImageFile.Length > 0)
            {
                var imagePath = Path.Combine(_cnicImageDirectory, cnicImageFile.FileName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    await cnicImageFile.CopyToAsync(stream);
                }

                booking.CNICimgPath = $"/cnic-images/{cnicImageFile.FileName}";
            }

            _context.Bookings.Add(booking);
            _context.SaveChanges();

            return Ok("Booking added successfully");
        }

        // Update an existing Booking with CNIC image
        [HttpPut]
        [Route("UpdateBooking/{id}")]
        public async Task<IActionResult> UpdateBooking(int id, [FromForm] Booking booking, IFormFile cnicImageFile)
        {
            var existingBooking = _context.Bookings.FirstOrDefault(x => x.Id == id);
            if (existingBooking == null)
            {
                return BadRequest("Booking not found");
            }

            existingBooking.StartTime = booking.StartTime;
            existingBooking.EndTime = booking.EndTime;
            existingBooking.Place = booking.Place;
            existingBooking.Charges = booking.Charges;
            existingBooking.VehicleId = booking.VehicleId;
            existingBooking.UserName = booking.UserName;
            existingBooking.ReturnedDate = booking.ReturnedDate;
            existingBooking.PaidAmount = booking.PaidAmount;
          

            if (cnicImageFile != null && cnicImageFile.Length > 0)
            {
                var imagePath = Path.Combine(_cnicImageDirectory, cnicImageFile.FileName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    await cnicImageFile.CopyToAsync(stream);
                }

                existingBooking.CNICimgPath = $"/cnic-images/{cnicImageFile.FileName}";
            }

            _context.SaveChanges();

            return Ok("Booking updated successfully");
        }

        // Get CNIC Image by Booking ID
        [HttpGet]
        [Route("GetCNICImage/{id}")]
        public IActionResult GetCNICImage(int id)
        {
            var booking = _context.Bookings.FirstOrDefault(x => x.Id == id);
            if (booking == null || string.IsNullOrEmpty(booking.CNICimgPath))
            {
                return NotFound();
            }

            var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", booking.CNICimgPath.TrimStart('/'));

            if (!System.IO.File.Exists(imagePath))
            {
                return NotFound();
            }

            var image = System.IO.File.ReadAllBytes(imagePath);
            return File(image, "image/jpeg");
        }

        // Delete a Booking
        [HttpDelete]
        [Route("DeleteBooking/{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var booking = _context.Bookings.FirstOrDefault(x => x.Id == id);
            if (booking == null)
            {
                return BadRequest("Booking not found");
            }

            // Delete the CNIC image file if it exists
            if (!string.IsNullOrEmpty(booking.CNICimgPath))
            {
                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", booking.CNICimgPath.TrimStart('/'));

                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
            }

            _context.Bookings.Remove(booking);
            _context.SaveChanges();
            _context.ReseedAllTables();

            return Ok("Booking deleted successfully");
        }


    }
}


