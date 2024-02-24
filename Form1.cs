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

        bool dadosValidos = true;

        int? produtoEdicao = null;

        public FormSorveteria()
        {
            InitializeComponent();

            produtos = ProcessaJson.CarregaLista();
        }

        public void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text; ;
            string ingredientes = txtIngredientes.Text;
            decimal valor = numValor.Value;

            validacaoDados();



            if (dadosValidos)
            {
                if (produtoEdicao == null)
                {
                    Produto novoProduto = new Produto(nome, descricao, ingredientes, valor);
                    // Adicona o novo produto criado na lista
                    produtos.Add(novoProduto);

                    // Armazena a lista no arquivo json
                    ProcessaJson.ArmazenaLista("./meuarquivojson.json", produtos);

                    // Limpa as caixas de texto após inserir os dados na lista
                    limparTela();

                    lblQuantCadastros.Text = "Quantidade de produtos cadastrados: " + produtos.Count.ToString();
                }
                if (produtoEdicao != null)
                {
                    Produto editar = produtos[(int)produtoEdicao];

                    editar.nome = nome;
                    editar.descricao = descricao;
                    editar.ingredientes = ingredientes;
                    editar.valor = valor;
                }
            }
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

        private void MenuLista_Click(object sender, EventArgs e)
        {
            if (lstProdutos.Visible == false)
            {
                lstProdutos.Visible = true;
            }
            else if (lstProdutos.Visible == true)
            { 
                lstProdutos.Visible = false;
            }

            // Mostra os botões de apagar e editar
            btnEditar.Visible = true;
            btnApagar.Visible = true;

            carregaLista();
        }

        private void validacaoDados()
        {
            // Validação para evitar que o campo nome fique vazio
            if (txtNome.Text == "")
            {
                MessageBox.Show("O Campo nome deve ser informado");
                dadosValidos = false;
                return;
            }
            // Validação para conferir se nome do produto tem mais de 4 caractetes
            if (txtNome.Text.Length < 5)
            {
                MessageBox.Show("Informar o nome do produto com mais de 4 caracteres");
                dadosValidos = false;
                return;
            }

            if (txtDescricao.Text.Length < 5)
            {
                MessageBox.Show("A descrição deve ser informada com mais de 4 caracteres");
                dadosValidos = false;
                return;
            }

            if (txtIngredientes.Text == "")
            {
                MessageBox.Show("Favor informar os ingredientes!");
                dadosValidos = false;
                return;
            }

            if (numValor.Value == 0)
            {
                MessageBox.Show("O valor do produto deve ser maior que zero");
                dadosValidos = false;
                return;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Confirma se a pessoa quer realmente apagar o produto
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente apagar o produto?",
                "Apagar produto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation
                );

            if (resposta == DialogResult.No)
                return;

            // Pega o index do item selecionado no ListView
            ListView.SelectedIndexCollection itensSelecionados = lstProdutos.SelectedIndices;


            // Remove o item da lista
            foreach (int item in itensSelecionados)
            {
                produtos.RemoveAt(item);
            }

            // Salva a lista no arquivo de texto
            ProcessaJson.ArmazenaLista("./meuarquivojson.json", produtos);

            // Recarrega o ListView
            carregaLista();

        }

        private void carregaLista()
        {
            lstProdutos.Items.Clear();

            foreach (Produto produto in produtos)
            {
                ListViewItem item = new ListViewItem(produto.nome);

                item.SubItems.Add(produto.valor.ToString("c"));

                lstProdutos.Items.Add(item);
            }
        }

        public void btnEditar_Click(object sender, EventArgs e)
        {
            int produtoEdicao = 0;

            // Verifica qual o item foi selecionado
            if (lstProdutos.SelectedIndices.Count > 0)
                produtoEdicao = lstProdutos.SelectedIndices[0];


            Produto produtoSelecionado = produtos[produtoEdicao];


            // Coloca os dados no formulário do produto

            txtNome.Text = produtoSelecionado.nome;
            txtDescricao.Text = produtoSelecionado.descricao;
            txtIngredientes.Text = produtoSelecionado.ingredientes;
            numValor.Value = produtoSelecionado.valor;

        }



    

        public void lstProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int produtoSelecionado = 0;

            produtoSelecionado = lstProdutos.SelectedIndices[0];

    
             Produto _produto = produtos[produtoSelecionado];
                
             FormVerProduto formVerProduto = new FormVerProduto(_produto);

            formVerProduto.ShowDialog();
        }

    }
}


