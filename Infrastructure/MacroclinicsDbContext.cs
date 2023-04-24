using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure
{
    public class MacroclinicsDbContext : DbContext
    {
        public MacroclinicsDbContext(DbContextOptions<MacroclinicsDbContext> options) : base(options) =>
            Database.EnsureCreated();
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<ClinicaUsuario> ClinicasUsuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connection = configuration.GetConnectionString("DefaultConnection");
                var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
                optionsBuilder.UseMySql(connection, serverVersion);
            }
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClinicaUsuario>()
                .HasKey(eu => new { eu.ClinicaId, eu.UsuarioId });

            modelBuilder.Entity<ClinicaUsuario>()
                .HasOne(eu => eu.Clinica)
                .WithMany(e => e.ClinicaUsuarios)
                .HasForeignKey(eu => eu.ClinicaId);

            modelBuilder.Entity<ClinicaUsuario>()
                .HasOne(eu => eu.Usuario)
                .WithMany(u => u.ClinicaUsuarios)
                .HasForeignKey(eu => eu.UsuarioId);
        }
    }
}