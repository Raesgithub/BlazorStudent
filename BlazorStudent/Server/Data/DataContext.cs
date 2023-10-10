using BlazorStudent.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorStudent.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
