namespace Sorveteria
{
    partial class FormSorveteria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.painelProdutos = new System.Windows.Forms.Panel();
            this.lblQuantCadastros = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.painelPesquisar = new System.Windows.Forms.Panel();
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numPesquisar = new System.Windows.Forms.NumericUpDown();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLista = new System.Windows.Forms.ToolStripMenuItem();
            this.lstProdutos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.painelProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.painelPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPesquisar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelProdutos
            // 
            this.painelProdutos.Controls.Add(this.lblQuantCadastros);
            this.painelProdutos.Controls.Add(this.btnCadastrar);
            this.painelProdutos.Controls.Add(this.label4);
            this.painelProdutos.Controls.Add(this.label3);
            this.painelProdutos.Controls.Add(this.label2);
            this.painelProdutos.Controls.Add(this.label1);
            this.painelProdutos.Controls.Add(this.numValor);
            this.painelProdutos.Controls.Add(this.txtIngredientes);
            this.painelProdutos.Controls.Add(this.txtDescricao);
            this.painelProdutos.Controls.Add(this.txtNome);
            this.painelProdutos.Location = new System.Drawing.Point(50, 51);
            this.painelProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.painelProdutos.Name = "painelProdutos";
            this.painelProdutos.Size = new System.Drawing.Size(412, 632);
            this.painelProdutos.TabIndex = 0;
            this.painelProdutos.Visible = false;
            // 
            // lblQuantCadastros
            // 
            this.lblQuantCadastros.AutoSize = true;
            this.lblQuantCadastros.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantCadastros.Location = new System.Drawing.Point(21, 586);
            this.lblQuantCadastros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantCadastros.Name = "lblQuantCadastros";
            this.lblQuantCadastros.Size = new System.Drawing.Size(357, 29);
            this.lblQuantCadastros.TabIndex = 12;
            this.lblQuantCadastros.Text = "Quantidade de produtos cadastrados: 0";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(33, 472);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(344, 89);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar produto";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 351);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingredientes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // numValor
            // 
            this.numValor.DecimalPlaces = 2;
            this.numValor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numValor.Location = new System.Drawing.Point(33, 386);
            this.numValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numValor.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(344, 35);
            this.numValor.TabIndex = 3;
            this.numValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientes.Location = new System.Drawing.Point(33, 280);
            this.txtIngredientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(342, 35);
            this.txtIngredientes.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(33, 174);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(342, 35);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(33, 68);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(342, 35);
            this.txtNome.TabIndex = 0;
            // 
            // painelPesquisar
            // 
            this.painelPesquisar.Controls.Add(this.txtVisor);
            this.painelPesquisar.Controls.Add(this.label5);
            this.painelPesquisar.Controls.Add(this.numPesquisar);
            this.painelPesquisar.Controls.Add(this.btnPesquisar);
            this.painelPesquisar.Location = new System.Drawing.Point(498, 51);
            this.painelPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.painelPesquisar.Name = "painelPesquisar";
            this.painelPesquisar.Size = new System.Drawing.Size(412, 582);
            this.painelPesquisar.TabIndex = 9;
            this.painelPesquisar.Visible = false;
            // 
            // txtVisor
            // 
            this.txtVisor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(33, 174);
            this.txtVisor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVisor.Multiline = true;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(342, 121);
            this.txtVisor.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pesquisar produto:";
            // 
            // numPesquisar
            // 
            this.numPesquisar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPesquisar.Location = new System.Drawing.Point(33, 69);
            this.numPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPesquisar.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numPesquisar.Name = "numPesquisar";
            this.numPesquisar.Size = new System.Drawing.Size(344, 35);
            this.numPesquisar.TabIndex = 1;
            this.numPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(33, 472);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(344, 89);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar produto";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProduto,
            this.MenuPesquisar,
            this.MenuLista});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1333, 36);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuProduto
            // 
            this.MenuProduto.Name = "MenuProduto";
            this.MenuProduto.Size = new System.Drawing.Size(93, 32);
            this.MenuProduto.Text = "Produto";
            this.MenuProduto.Click += new System.EventHandler(this.MenuProduto_Click);
            // 
            // MenuPesquisar
            // 
            this.MenuPesquisar.Name = "MenuPesquisar";
            this.MenuPesquisar.Size = new System.Drawing.Size(102, 32);
            this.MenuPesquisar.Text = "Pesquisar";
            this.MenuPesquisar.Click += new System.EventHandler(this.MenuPesquisar_Click);
            // 
            // MenuLista
            // 
            this.MenuLista.Name = "MenuLista";
            this.MenuLista.Size = new System.Drawing.Size(63, 32);
            this.MenuLista.Text = "Lista";
            this.MenuLista.Click += new System.EventHandler(this.MenuLista_Click);
            // 
            // lstProdutos
            // 
            this.lstProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstProdutos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProdutos.HideSelection = false;
            this.lstProdutos.Location = new System.Drawing.Point(917, 51);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(336, 574);
            this.lstProdutos.TabIndex = 11;
            this.lstProdutos.UseCompatibleStateImageBehavior = false;
            this.lstProdutos.View = System.Windows.Forms.View.Details;
            this.lstProdutos.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Produto";
            this.columnHeader1.Width = 157;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor";
            this.columnHeader2.Width = 173;
            // 
            // FormSorveteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 702);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.painelPesquisar);
            this.Controls.Add(this.painelProdutos);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSorveteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorveteria";
            this.painelProdutos.ResumeLayout(false);
            this.painelProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.painelPesquisar.ResumeLayout(false);
            this.painelPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPesquisar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelProdutos;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel painelPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuProduto;
        private System.Windows.Forms.ToolStripMenuItem MenuPesquisar;
        private System.Windows.Forms.Label lblQuantCadastros;
        private System.Windows.Forms.ListView lstProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuLista;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

