using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorveteria
{
    public class Pedido
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string cpf { get; set; }

        public DateTime data_pedido { get; set; }

        public decimal valor_total { get; set; }

        public string status { get; set; }

        public decimal total { get; set; }


        // METODO CONSTRUTOR
        public Pedido(int id, string nome, string cpf, DateTime data_pedido, decimal valor_total, string status, decimal total)
        { 
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.data_pedido = data_pedido;
            this.valor_total = valor_total;
            this.status = status;
            this.total = total;
        }

    }

     

}
