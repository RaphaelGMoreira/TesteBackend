using Microsoft.EntityFrameworkCore;
using PostoGasolina.Entity;
using PostoGasolina.Mapping;

namespace PostoGasolina.Contex
{
    public class PostoContext : DbContext
    {
        public PostoContext(DbContextOptions<PostoContext> options) : base(options)
        {
        }


        public DbSet<Produto> Produtos { get; set; }

        public DbSet<ItemPedido> ItemPedidos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }


        
        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);

            Builder.Entity<Produto>(new ProdutoMapping().Configure);

            Builder.Entity<ItemPedido>(new ItemPedidoMapping().Configure);

            Builder.Entity<Pedido>(new PedidoMapping().Configure);

        }

    }
}
