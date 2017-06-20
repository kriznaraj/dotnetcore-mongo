using System;
using test.Models;
using MongoDB.Driver;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

namespace test.Repository
{
    public interface IUserRepository
    {
        Task AddUser(User user);

        Task<IList<User>> GetUsersAsync();
    }

    public class UserMongoRepository : IUserRepository
    {
        private readonly UserDbContext _dbContext;
        public UserMongoRepository(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<User>> GetUsersAsync()
        {
            return await _dbContext.Users.Find(_ => true).ToListAsync();
        }

        public async Task AddUser(User user)
        {
            await _dbContext.Users.InsertOneAsync(user);
        }
    }
}