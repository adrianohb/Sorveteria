using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorveteria
{
    public partial class FormSorveteria : Form
    {
        // Cria uma lista onde serão adicionados os produtos
        List<Produto> produtos = new List<Produto>();

        public FormSorveteria()
        {
            InitializeComponent();
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
            painelProdutos.Visible = true;
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
