using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorveteria
{
    internal class Produto
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public string ingredientes { get; set; }
        public decimal valor { get; set; }

        // Metodo construtor
        public Produto(string nome, string descricao, string ingredientes, decimal valor)
        { 
            this.nome = nome;
            this.descricao = descricao;
            this.ingredientes = ingredientes;
            this.valor = valor;
        }

        public override string ToString()
        {
            return $"O produto {this.nome} custa R$ {this.valor}";
        }
    }
}
