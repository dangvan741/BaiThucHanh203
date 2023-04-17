using BaiThucHanh203.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiThucHanh203.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Faculty> Faculty { get; set; } 
    }
}