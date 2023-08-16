using Imenik.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure;


namespace Imenik.data
{
    public class ImenikDbContext : DbContext
    {
        public ImenikDbContext(DbContextOptions<ImenikDbContext> options) : base(options)
        {
        }

        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Drzava> Drzave { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drzava>().HasKey(d => d.Id);
            modelBuilder.Entity<Grad>().HasKey(g => g.Id);
            modelBuilder.Entity<Osoba>().HasKey(o => o.Id);

            modelBuilder.Entity<Grad>()
                .HasOne(g => g.Drzava)
                .WithMany(d => d.Gradovi)
                .HasForeignKey(g => g.DrzavaId);

            modelBuilder.Entity<Osoba>()
                .HasOne(o => o.Grad)
                .WithMany(g => g.Osobe)
                .HasForeignKey(o => o.GradId);

            modelBuilder.Entity<Osoba>()
              .HasOne(o => o.Drzava)
              .WithMany(d => d.Osobe)
              .HasForeignKey(o => o.DrzavaId);

            modelBuilder.Entity<Drzava>()
                .Property(d => d.Naziv)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Grad>()
                .Property(g => g.Naziv)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Osoba>()
                .Property(o => o.Ime)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Osoba>()
                .Property(o => o.Prezime)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Osoba>()
                .Property(o => o.BrojTelefona)
                .HasMaxLength(20);

            modelBuilder.Entity<Osoba>()
                .Property(o => o.Email)
                .HasMaxLength(100);

            modelBuilder.Entity<Osoba>()
                .Property(o => o.Pol)
                .HasMaxLength(10);

            modelBuilder.Entity<Osoba>()
                .Property(o => o.DatumRodjenja);
        }
    }
}

