using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Nvm_Lesson12.Models;

namespace Nvm_Lesson12.Entities
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<NvmProduct> Products { get; set; }
    }
}
