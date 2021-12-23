using Microsoft.EntityFrameworkCore;
using RepositoryDemo.business.Entities;

namespace RepoDemo.Business.Data
{
    internal static class DbInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, Name = "Sarah", Email = "sarah@example.com", PhoneNumber = 0635578892 },
                new User() { Id = 2, Name = "Burt", Email = "burt@example.com", PhoneNumber = 0635578893 },
                new User() { Id = 3, Name = "Devon", Email = "devon@example.com", PhoneNumber = 0635578894 },
                new User() { Id = 4, Name = "Oprah", Email = "oprah@example.com", PhoneNumber = 0635578895 }
                );
        }
    }

}
