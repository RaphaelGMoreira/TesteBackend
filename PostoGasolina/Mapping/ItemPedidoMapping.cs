using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostoGasolina.Entity;

namespace PostoGasolina.Mapping
{
    public class ItemPedidoMapping : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.ToTable("ItemPedido");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.IdPedido);

            builder.Property(p => p.IdProduto);

            builder.Property(p => p.Quantidade).HasMaxLength(10);

            builder.Property(p => p.Pedido).HasMaxLength(10);

            builder.Property(p => p.Produto).HasMaxLength(10);

            builder.Property(p => p.ValorUnitario).HasMaxLength(10);
        }

    }
}
