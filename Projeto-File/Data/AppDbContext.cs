using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projeto_File.Models;
using Projeto_File.Models.Mapping;

namespace Projeto_File.Data
{
    public class AppDbContext : IdentityDbContext<Usuario>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<NivelAcesso> NiveisAcessos { get; set; }

        public DbSet<Hospital> Hospitais { get; set; }

        public DbSet<Especialidade> Especialidades { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UsuarioMapping());
            //builder.ApplyConfiguration(new NivelAcessoMapping());
            builder.ApplyConfiguration(new EspecialidadeMapping());
            builder.ApplyConfiguration(new HospitalMapping());
        }
    }
}
