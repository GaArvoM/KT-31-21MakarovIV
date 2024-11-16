using KT_31_21MakarovIV.database.Configurations;
using KT_31_21MakarovIV.Models;
using Microsoft.EntityFrameworkCore;


namespace KT_31_21MakarovIV.database

{
    public class StudentDBContext: DbContext
    {
        DbSet<Students> Students { get; set; }
        DbSet<Groups> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());

        }

            public StudentDBContext(DbContextOptions<StudentDBContext> options):base(options)
        {

        } 
    }
}
