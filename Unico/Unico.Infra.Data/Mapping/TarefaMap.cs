using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unico.Domain.Entities;

namespace Unico.Infra.Data.Mapping
{
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder) 
        {
            builder.ToTable("Tarefa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("UNIQUEIDENTIFIER")
                .IsRequired();
            builder.Property(x => x.Titulo)
                .HasColumnName("Titulo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("VARCHAR")
                .HasMaxLength(5000)
                .IsRequired();
            builder.Property(x => x.DataVencimento)
                .HasColumnName("DataVencimento")
                .HasColumnType("DATETIME")
                .IsRequired();
        }
    }
}
