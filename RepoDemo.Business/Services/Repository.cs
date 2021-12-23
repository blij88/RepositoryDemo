using Microsoft.EntityFrameworkCore;
using RepositoryDemo.business.Data;
using RepositoryDemo.business.Interfaces;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryDemo.business.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ChatContext context;

        public Repository(ChatContext context)
        {
            this.context = context;
        }

        public async Task DeleteAsync(int id)
        {

            var entity = await GetByIdAsync(id);
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task InsertAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        //
        public async Task UpdateAsync(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
