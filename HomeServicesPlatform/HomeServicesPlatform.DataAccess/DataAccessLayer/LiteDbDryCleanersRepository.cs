using System.Configuration;
using HomeServicesPlatform.Bussiness;
using HomeServicesPlatform.Bussiness.Entities;
using HomeServicesPlatform.Bussiness.Enums;
using LiteDB;

namespace HomeServicesPlatform.DataAccess.DataAccessLayer
{
    public class LiteDbDryCleanersRepository : IDryCleanersRepository
    {
        private LiteDatabase database;
        public LiteDbDryCleanersRepository()
        {
            database = new LiteDatabase("Filename=DryCleaners.db;connection=shared");
        }

        public void AddDryCleaner(DryCleaners dryCleaner)
        {
            var dryCleaners = database.GetCollection<DryCleaners>("DryCleaners");
            dryCleaners.Insert(dryCleaner);
        }

        public DryCleaners GetById(int id)
        {
            var dryCleaners = database.GetCollection<DryCleaners>("DryCleaners");
            return dryCleaners.FindOne(cleaner => cleaner.Id == id);

        }

        public IEnumerable<DryCleaners> GetAll()
        {
            var dryCleaners = database.GetCollection<DryCleaners>("DryCleaners");
            return dryCleaners.FindAll();
        }

        public void EditCleanersName(int cleanerId, string newName)
        {
            var dryCleaners = database.GetCollection<DryCleaners>("DryCleaners");
            var cleaner = dryCleaners.FindOne(cleaner => cleaner.Id == cleanerId);
            cleaner.Name = newName;
            dryCleaners.Update(cleaner);
        }

        public void DeleteCleaner(int id)
        {
            var dryCleaners = database.GetCollection<DryCleaners>("DryCleaners");
            dryCleaners.Delete(id);
        }
    }
}
