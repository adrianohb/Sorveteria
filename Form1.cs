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

            txtNome.Text = "";
            txtDescricao.Text = "";
            txtIngredientes.Text = "";
            numValor.Value = 0;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (numPesquisar.Value < produtos.Count)
            {
                Produto produto = produtos[(int)numPesquisar.Value];
                txtVisor.Text = produto.ToString();
            }
        }

    }
}
