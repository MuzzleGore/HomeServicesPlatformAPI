using HomeServicesPlatform.Bussiness.Enums;
namespace HomeServicesPlatform.Bussiness.DTOs
{
    public class DryCleanersDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public Dictionary<ClothingPieces, decimal> ClothingPieces { get; set; }
    }
}
