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
    public partial class FormVerProduto : Form
    {
        Produto produto;
        public FormVerProduto(Produto _produto)
        {
            InitializeComponent();
            this.produto = _produto;
        }

        private void FormVerProduto_Load(object sender, EventArgs e)
        {
            txtNome.Text = produto.nome;
            txtDescricao.Text = produto.descricao;
            txtIngredientes.Text = produto.ingredientes;
            numValor.Value = produto.valor;
        }
    }
}
