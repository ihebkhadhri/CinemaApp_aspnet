using Cinema.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acteur_Film>().HasKey(am => new
            {
                am.ActeurId,
                am.FilmId
            });

            modelBuilder.Entity<Acteur_Film>().HasOne(m => m.Film).WithMany(am => am.Acteur_Films).HasForeignKey(m => m.FilmId);
            modelBuilder.Entity<Acteur_Film>().HasOne(m => m.Acteur).WithMany(am => am.Acteur_Films).HasForeignKey(m => m.ActeurId);


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Acteur> Actors { get; set; }
        public DbSet<Film> Movies { get; set; }
        public DbSet<Acteur_Film> Actors_Movies { get; set; }
        public DbSet<Cinemaa> Cinemas { get; set; }
        public DbSet<Producteur> Producers { get; set; }
    }
}
