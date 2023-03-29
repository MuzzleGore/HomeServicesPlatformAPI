using HomeServicesPlatform.Bussiness.Entities;

namespace HomeServicesPlatform.Bussiness
{
    public interface IDryCleanersRepository
    {
        void AddDryCleaner(DryCleaners dryCleaner);
        DryCleaners GetById(int id);
        IEnumerable<DryCleaners> GetAll();
        void EditCleanersName(int cleanerId, string newName);
        void DeleteCleaner(int id);
    }
}
