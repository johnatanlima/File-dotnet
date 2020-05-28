using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Projeto_File.Models.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(45);

            builder.Property(x => x.Sobrenome).HasMaxLength(45).IsRequired();

            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(45);
    
            builder.Ignore(i => i.EmailConfirmed);
            builder.Ignore(i => i.AccessFailedCount);
            builder.Ignore(i => i.LockoutEnabled);
            builder.Ignore(i => i.LockoutEnd);
            builder.Ignore(i => i.PhoneNumber);
            builder.Ignore(i => i.PhoneNumberConfirmed);
            builder.Ignore(i => i.TwoFactorEnabled);

        }
    }
}
