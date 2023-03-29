using System.Configuration;
using HomeServicesPlatform.Bussiness;
using HomeServicesPlatform.Bussiness.Entities;
using LiteDB;

namespace HomeServicesPlatform.DataAccess.DataAccessLayer
{
    internal class LiteDbDryCleanersRepository : IDryCleanersRepository
    {
        private readonly string connectionString;

        public LiteDbDryCleanersRepository(string connectionString)
        {
            this.connectionString = connectionString;
            
        }

        public void AddDryCleaner(DryCleaners dryCleaner)
        {
            using (var database = new LiteDatabase(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString))
            {
                var dryCleaners = database.GetCollection<DryCleaners>("DryCleaners");
                dryCleaners.Insert(dryCleaner);
            }
        }

        public DryCleaners GetById(int id)
        {

            using (var database = new LiteDatabase(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString))
            {
                var dryCleaners = database.GetCollection<DryCleaners>("DryCleaners");
                return dryCleaners.FindOne(cleaner => cleaner.Id == id);


            }
        }

        public IEnumerable<DryCleaners> GetAll()
        {
            using (var database =
                   new LiteDatabase(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString))
            {
                var dryCleaners = database.GetCollection<DryCleaners>("DryCleaners");
                return dryCleaners.FindAll();
            }
        }

        public void EditCleanersName(int cleanerId, string newName)
        {
            using (var database =
                   new LiteDatabase(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString))
            {
                var dryCleaners = database.GetCollection<DryCleaners>("DryCleaners");
                var cleaner = dryCleaners.FindOne(cleaner => cleaner.Id == cleanerId);
                cleaner.Name = newName;
                dryCleaners.Update(cleaner);
            }
        }

        public void DeleteCleaner(int id)
        {
            using (var database =
                   new LiteDatabase(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString))
            {
                var dryCleaners = database.GetCollection<DryCleaners>("DryCleaners");
                dryCleaners.Delete(id);
            }
        }
    }
}
