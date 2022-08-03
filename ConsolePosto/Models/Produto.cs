using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePosto.Models
{
    public class Produto : GeraId
    {


        public string NomeProduto { get; private set; }

        public decimal Preco { get; private set; }

        public int Estoque { get; private set; }

        public Status Status { get; set; }

        public Produto(Guid id, string nomeProduto, decimal preco, int estoque) : base(id)
        {
            NomeProduto = nomeProduto;
            Preco = preco;
            Estoque = estoque;
        }

    }
}
