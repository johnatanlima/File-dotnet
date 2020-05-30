using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_File.Models.Mapping
{
    public class HospitalMapping : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            builder.ToTable("Hospitais");

            builder.HasKey(x => x.HospitalId);
            builder.Property(h => h.Nome).IsRequired().HasMaxLength(255);
            builder.Property(h => h.Diretor).IsRequired().HasMaxLength(45);
            builder.Property(h => h.Cidade).IsRequired().HasMaxLength(45);
            builder.Property(h => h.Foto);
            builder.Property(h => h.Telefone).HasMaxLength(14);

            builder.HasMany(h => h.Especialidades).WithOne(e => e.HospitalVirtual).OnDelete(DeleteBehavior.Cascade);

        }
    }

}
