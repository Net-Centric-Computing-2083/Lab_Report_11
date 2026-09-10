using Microsoft.EntityFrameworkCore;
using Lab_Report_11.Models;
namespace Lab_Report_11.Data {
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }
        public DbSet<Student> Students { get; set; } 
    } 
}   