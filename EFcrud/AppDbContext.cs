using Microsoft.EntityFrameworkCore;
using EFcrud.Model;

namespace EFcrud
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=StudentDB;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<StudentModel> Studenttable { get; set; }

    }
}
