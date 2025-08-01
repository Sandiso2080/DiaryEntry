using DiaryEntry.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryEntry.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<DiaryModel> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryModel>().HasData(
                new DiaryModel{
                  Id = 1,
                  Title = "Went Hiking", 
                  Content = "Went Hiking with Msane", 
                  Created = new DateTime(2025, 08, 01, 12, 00, 00)
                });
        }
    }

}
