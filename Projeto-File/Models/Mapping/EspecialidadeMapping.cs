using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.Data.MySqlClient;
using System;

namespace Projeto_File.Models.Mapping
{
    public class EspecialidadeMapping : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.ToTable("Especialidades");

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(45);
            builder.Property(x => x.Descricao).HasMaxLength(255);
            builder.Property(x => x.DataInclusao).HasColumnType<DateTime>("date");
            builder.HasKey(x => x.EspecialidadeId);

            builder.HasOne(e => e.HospitalVirtual).WithMany(h => h.Especialidades).HasForeignKey(e => e.HospitalId);
        }
    }
}
