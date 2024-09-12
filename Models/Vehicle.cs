namespace Carrental.WebAPI.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string? Price { get; set; }
        public string? Detail { get; set; }
        public byte[]? Image { get; set; }
        public string? Popular { get; set; }
        public string? Damage { get; set; }
        public string? Available { get; set; }

        public int? ModelId { get; set; }
        public VehicleModel? Model { get; set; }

        public int? BrandId { get; set; }
        public VehicleBrand? Brand { get; set; }

        public int? CategoryId { get; set; }
        public VehicleCategory? Category { get; set; }

        public string? UserName { get; set; }
        public string? Remarks { get; set; }
    }
}
