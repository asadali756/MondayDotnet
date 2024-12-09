using Microsoft.EntityFrameworkCore;
using project.Models;

namespace friday.Models
{
    public class Connection : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.;Database=student;User Id=sa;Password=aptech;TrustserverCertificate=True");
        }

        public DbSet<Student> students { get; set; }
    }
}