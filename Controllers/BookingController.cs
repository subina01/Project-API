using Carrental.WebAPI.Data;
using Carrental.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carrental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BookingController(ApplicationDbContext context)
        {
            _context = context;
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
                using (var memoryStream = new MemoryStream())
                {
                    await cnicImageFile.CopyToAsync(memoryStream);
                    booking.CNICimg = memoryStream.ToArray();
                }
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
            existingBooking.SecretCode = booking.SecretCode;
            existingBooking.VerifyCode = booking.VerifyCode;

            if (cnicImageFile != null && cnicImageFile.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await cnicImageFile.CopyToAsync(memoryStream);
                    existingBooking.CNICimg = memoryStream.ToArray();
                }
            }
            else
            {
                existingBooking.CNICimg = booking.CNICimg;
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
            if (booking == null || booking.CNICimg == null)
            {
                return NotFound();
            }

            return File(booking.CNICimg, "image/jpeg"); 
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

            _context.Bookings.Remove(booking);
            _context.SaveChanges();

            return Ok("Booking deleted successfully");
        }
    }
}

