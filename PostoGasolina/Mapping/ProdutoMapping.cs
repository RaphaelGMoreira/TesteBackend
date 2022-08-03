using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostoGasolina.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostoGasolina.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.NomeProduto).HasMaxLength(50);

            builder.Property(p => p.Preco).HasMaxLength(10);

            builder.Property(p => p.Status).HasMaxLength(2);

            builder.Property(p => p.Estoque).HasMaxLength(10);
        }
    }
}
