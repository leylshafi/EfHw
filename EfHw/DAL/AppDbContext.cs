using EfHw.Models;
using Microsoft.EntityFrameworkCore;

namespace EfHw.DAL;

public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Data Source=LEILASHAFI;Initial Catalog=StudentsDb;Integrated Security=True;Encrypt=False;");
    }

    public DbSet<Student> Students { get; set; }
}
