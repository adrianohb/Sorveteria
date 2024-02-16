using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Sorveteria
{
    public partial class FormSorveteria : Form
    {
        // Cria uma lista onde serão adicionados os produtos
        List<Produto> produtos;

        public FormSorveteria()
        {
            InitializeComponent();

            produtos = ProcessaJson.CarregaLista();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text; ;
            string ingredientes = txtIngredientes.Text;
            decimal valor = numValor.Value;

            Produto novoProduto = new Produto(nome, descricao, ingredientes, valor);

            // Adicona o novo produto criado na lista
            produtos.Add(novoProduto);

            // Armazena a lista no arquivo json
            ProcessaJson.ArmazenaLista("./meuarquivojson.json", produtos);

            // Limpa as caixas de texto após inserir os dados na lista
            limparTela();



            lblQuantCadastros.Text = "Quantidade de produtos cadastrados: " + produtos.Count.ToString();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (numPesquisar.Value < produtos.Count)
            {
                Produto produto = produtos[(int)numPesquisar.Value];
                txtVisor.Text = produto.ToString();
            }
        }

        private void MenuProduto_Click(object sender, EventArgs e)
        {
            if (painelProdutos.Visible == false)
            {
                painelProdutos.Visible = true;
            }
            else if (painelProdutos.Visible == true)
            {
                painelProdutos.Visible = false;
            }
           
        }

        private void MenuPesquisar_Click(object sender, EventArgs e)
        {
            painelPesquisar.Visible = true;
        }

        private void limparTela()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtIngredientes.Clear();
            numValor.Value = 0;
        }
    }
}
