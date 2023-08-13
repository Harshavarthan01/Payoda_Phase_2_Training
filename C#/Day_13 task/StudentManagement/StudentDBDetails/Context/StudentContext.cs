using Microsoft.EntityFrameworkCore;
using StudentDBDetails.Models;

namespace StudentDBDetails.Context
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        
    }
}
