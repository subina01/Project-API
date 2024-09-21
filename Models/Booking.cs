namespace Carrental.WebAPI.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? CNICimgPath { get; set; } 
        public string? Place { get; set; }
        public string? Charges { get; set; }

        public int? VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }

        public string? UserName { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public string? PaidAmount { get; set; }
       
    }
}
