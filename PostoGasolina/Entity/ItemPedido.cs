using PostoGasolina.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PostoGasolina.Entity
{
    public class ItemPedido : GeraId
    {
        [ForeignKey("Produto")]
        public Guid IdProduto { get; set; }

        [ForeignKey("Pedido")]
        public Guid IdPedido { get; set; }

        public float Quantidade { get; set; }

        public double ValorUnitario { get; set; }

        [NotMapped]
        [Display(Name = "Valor do Item")]
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
