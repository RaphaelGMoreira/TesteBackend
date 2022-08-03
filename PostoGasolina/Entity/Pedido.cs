﻿using PostoGasolina.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostoGasolina.Entity
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
