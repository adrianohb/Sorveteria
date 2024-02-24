using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorveteria
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string ingredientes { get; set; }
        public decimal valor { get; set; }

        // Metodo construtor
        public Produto(string nome, string descricao, string ingredientes, decimal valor, int? id = null)
        {
           
            this.nome = nome;
            this.descricao = descricao;
            this.ingredientes = ingredientes;
            this.valor = valor;

            if (id == null)
                this.id = novoId();
            else
                this.id = (int)id;
        }

        public override string ToString()
        {
            return $"O produto {this.nome} custa R$ {this.valor}";
        }

        private int novoId()
        {
            // Pega a lista de produtos
            List<Produto> listaProdutos = ProcessaJson.CarregaLista();

            // Pega o maior ID da lista de produtos
            int maiorIdProduto = 0;

            foreach (Produto produto in listaProdutos) 
            {
                if (produto.id > maiorIdProduto)
                    maiorIdProduto = produto.id;
            }

            // Retorna o maior ID +1, sendo o próximo ID a ser usado
            return maiorIdProduto + 1;
        }
    }
}
