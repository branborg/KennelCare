using Kennel.Database.Interfaces;
using KennelCare.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Kennel.Database.Implementations
{
    public class KennelContext : DbContext, IKennelContext
    {
        public string DbPath { get; init; }  //this will come from an app config later.
        public DbSet<Pet>? Pets { get; init; } //references are no longer defaulted to nullable thanks c# 8.0 => see the ?
        public DbSet<Medicine>? Medicines { get; init; }

        public KennelContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Kennel.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        { 
           options.UseSqlite($"Data Source={DbPath}");
        }
    }
}