using Encapsulamento.Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Encapsulamento.Demo.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(p => p.Codigo);

            builder.Property(p => p.Codigo)
                .ValueGeneratedNever();

            builder.Property(p => p.Nome)
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(p => p.MotivoDesativacao)
                .HasMaxLength(250)
                .IsUnicode(false);
        }
    }
}