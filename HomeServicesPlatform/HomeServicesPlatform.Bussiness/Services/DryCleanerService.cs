using HomeServicesPlatform.Bussiness.DTOs;
using HomeServicesPlatform.Bussiness.Entities;
using HomeServicesPlatform.Bussiness.Mapping;

namespace HomeServicesPlatform.Bussiness.Services
{
    public class DryCleanerService
    {
        private readonly IDryCleanersRepository dryCleanersRepository;

        public DryCleanerService(IDryCleanersRepository dryCleanersRepository)
        {
            this.dryCleanersRepository = dryCleanersRepository;
        }

        public void AddDryCleaner(DryCleaners dryCleaner)
        {
            dryCleanersRepository.AddDryCleaner(dryCleaner);
        }

        public DryCleanersDto GetById(int id)
        {
            DryCleaners dryCleaners =  dryCleanersRepository.GetById(id);
            return dryCleaners.ToDryCleanersDto();
        }

        public IEnumerable<DryCleaners> GetAll()
        {
            return dryCleanersRepository.GetAll();
        }

        public void EditCleanersName(int cleanerId, string newName)
        {
            dryCleanersRepository.EditCleanersName(cleanerId, newName);
        }

        public void DeleteCleaner(int id)
        {
            dryCleanersRepository.DeleteCleaner(id);
        }
    }
}
