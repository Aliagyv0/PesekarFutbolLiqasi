using Microsoft.EntityFrameworkCore;
using PeşəkarFutbolLiqası.DAL.Models;
using PesekarFutbolLiqasi.DAL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PesekarFutbolLiqasi.DAL.Context
{
    public class FutbolDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(CustomSQLConnection.ConnnectionString);
      
        }
        public DbSet<Futbolcu> Futbolcular { get; set; }
        public DbSet<Komanda> Komandalar { get; set; }
        public DbSet<Oyun> Oyunlar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }
    }
}
