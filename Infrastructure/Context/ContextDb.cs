using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions options) : base(options) { }

        public DbSet<Login> Login { get; set; }
        public DbSet<AuthUser> AuthUser { get; set; }
    }
}