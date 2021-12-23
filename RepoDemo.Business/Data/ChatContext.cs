using Microsoft.EntityFrameworkCore;
using RepoDemo.Business.Data;
using RepositoryDemo.business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDemo.business.Data
{
    public class ChatContext: DbContext
    {
        public ChatContext(DbContextOptions<ChatContext> options) :base(options)
        {
        }
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
