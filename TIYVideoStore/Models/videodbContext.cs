using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TIYVideoStore.Models;

namespace TIYVideoStore.Models
{
    public partial class videodbContext : DbContext
    {
        public DbSet<CustomersModel> Customers { get; set; }
        public DbSet<GenresModel> Genres { get; set; }
        public DbSet<MoviesModel> Movies { get; set; }
        public DbSet<RentalRecordModel> RentalRecords { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql(@"Host=localhost;Database=videodb;Username=dev;Password=brit1336");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
