using HomeServicesPlatform.Bussiness.DTOs;
using HomeServicesPlatform.Bussiness.Entities;

namespace HomeServicesPlatform.Bussiness.Mapping
{
    public static class DryCleanersMappingExtension
    {
        public static DryCleanersDto ToDryCleanersDto(this DryCleaners dryCleaner)
        {
            if (dryCleaner == null) return null;


            return new DryCleanersDto
            {
                Id = dryCleaner.Id,
                Name = dryCleaner.Name,
                Address = dryCleaner.Address,
                City = dryCleaner.City,
                PhoneNumber = dryCleaner.PhoneNumber,
                ClothingPieces = dryCleaner.ClothingPieces
            };
        }


    }
}
