using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePosto.Models
{
    public class ItemPedido : GeraId
    {
        
        public Guid IdProduto { get; set; }

        public Guid IdPedido { get; set; }

        public float Quantidade { get; set; }

        public double ValorUnitario { get; set; }

        
        public double ValorItem
        {
            get
            {
                return Quantidade * ValorUnitario;
            }
        }

        public Pedido Pedido { get; set; }

        public Produto Produto { get; set; }

        public ItemPedido(Guid id) : base(id)
        {

        }


    }
}
