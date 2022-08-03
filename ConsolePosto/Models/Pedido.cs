using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePosto.Models
{
    public class Pedido : GeraId
    {

        public double ValorTotal { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }

        public string IdCarrinho { get; set; }

        public Pedido(Guid id) : base(id)
        {

        }

    }
}
