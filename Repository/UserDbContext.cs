using Microsoft.Extensions.Options;
using MongoDB.Driver;
using test.Models;

namespace test.Repository
{
    public class UserDbContext
    {
        private readonly IMongoDatabase _database = null;
        public UserDbContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<User> Users
        {
            get
            {
                return _database.GetCollection<User>("User");
            }
        }
    }
}