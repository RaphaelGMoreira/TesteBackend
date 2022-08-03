using PostoGasolina.Contex;
using PostoGasolina.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostoGasolina.Repositories
{
    public class ItemPedidoRepository : RepositoryBase<ItemPedido>
    {
        public ItemPedidoRepository(PostoContext postoContext) : base(postoContext)
        {

        }
    }
}
