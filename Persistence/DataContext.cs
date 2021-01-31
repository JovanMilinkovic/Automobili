using System;
using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        { 
        }
        public DbSet<Automobil> Automobili { get; set; }
        public DbSet<Pogon> Pogoni {get; set; }
        public DbSet<Kubikaza> Kubikaze { get; set; }
        public DbSet<Kwks> KonjskeSnage{ get; set; }
        public DbSet<Karoserija> Karoserije { get; set; }
        public DbSet<Oprema> Opreme { get; set; }
        public DbSet<SveOAutomobilu> SveOAutomobilima { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);
            mb.Entity<SveOAutomobilu>(x => x.HasKey(soa => new {soa.KaroserijaId, soa.KubikazaId, soa.KwksId, soa.PogonId, soa.OpremaId}));
            mb.Entity<SveOAutomobilu>()
                .HasOne(s => s.Automobil)
                .WithMany(s => s.SveOAutomobilima)
                .HasForeignKey(s => s.AutomobilId);
            mb.Entity<SveOAutomobilu>()
                .HasOne(s => s.Karoserija)
                .WithMany(s => s.SveOAutomobilima)
                .HasForeignKey(s => s.KaroserijaId);
            mb.Entity<SveOAutomobilu>()
                .HasOne(s => s.Kubikaza)
                .WithMany(s => s.SveOAutomobilima)
                .HasForeignKey(s => s.KubikazaId);
            mb.Entity<SveOAutomobilu>()
                .HasOne(s => s.Kwks)
                .WithMany(s => s.SveOAutomobilima)
                .HasForeignKey(s => s.KwksId);
            mb.Entity<SveOAutomobilu>()
                .HasOne(s => s.Pogon)
                .WithMany(s => s.SveOAutomobilima)
                .HasForeignKey(s => s.PogonId);
            mb.Entity<SveOAutomobilu>()
                .HasOne(s => s.Oprema)
                .WithMany(s => s.SveOAutomobilima)
                .HasForeignKey(s => s.OpremaId);
        }
    }
}
