using RepositoryDemo.business.Entities;
using RepositoryDemo.business.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryDemo.business.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> repository;

        public UserService(IRepository<User> repository)
        {
            this.repository = repository;
        }

        public async Task AddAsync(User user)
        {
            await repository.InsertAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(User user)
        {
            await repository.UpdateAsync(user);
        }
    }
}
