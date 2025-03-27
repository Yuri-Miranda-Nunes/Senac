namespace Oásis_da_Leitura
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            btnVoltar = new Button();
            btnCadastrarLivro = new Button();
            txtQuantidadeEstoque = new TextBox();
            lblQuantidadeEstoque = new Label();
            txtPreco = new TextBox();
            lblPreco = new Label();
            txtTitulo = new TextBox();
            lblTitulo = new Label();
            panel2 = new Panel();
            btnExcluir = new Button();
            dgvMostrarLivros = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMostrarLivros).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(btnCadastrarLivro);
            panel1.Controls.Add(txtQuantidadeEstoque);
            panel1.Controls.Add(lblQuantidadeEstoque);
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(lblPreco);
            panel1.Controls.Add(txtTitulo);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 450);
            panel1.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Font = new Font("Maiandra GD", 18F, FontStyle.Bold);
            btnVoltar.Location = new Point(12, 391);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(351, 47);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCadastrarLivro
            // 
            btnCadastrarLivro.Cursor = Cursors.Hand;
            btnCadastrarLivro.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarLivro.Location = new Point(12, 279);
            btnCadastrarLivro.Name = "btnCadastrarLivro";
            btnCadastrarLivro.Size = new Size(351, 48);
            btnCadastrarLivro.TabIndex = 6;
            btnCadastrarLivro.Text = "Cadastrar Livro";
            btnCadastrarLivro.UseVisualStyleBackColor = true;
            btnCadastrarLivro.Click += btnCadastrarLivro_Click;
            // 
            // txtQuantidadeEstoque
            // 
            txtQuantidadeEstoque.Cursor = Cursors.IBeam;
            txtQuantidadeEstoque.Font = new Font("Maiandra GD", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantidadeEstoque.Location = new Point(12, 229);
            txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            txtQuantidadeEstoque.PlaceholderText = "Ex: 2";
            txtQuantidadeEstoque.Size = new Size(351, 33);
            txtQuantidadeEstoque.TabIndex = 5;
            txtQuantidadeEstoque.TextAlign = HorizontalAlignment.Center;
            // 
            // lblQuantidadeEstoque
            // 
            lblQuantidadeEstoque.AutoSize = true;
            lblQuantidadeEstoque.Font = new Font("Maiandra GD", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidadeEstoque.Location = new Point(17, 191);
            lblQuantidadeEstoque.Name = "lblQuantidadeEstoque";
            lblQuantidadeEstoque.Size = new Size(340, 35);
            lblQuantidadeEstoque.TabIndex = 4;
            lblQuantidadeEstoque.Text = "Quantidade em Estoque";
            // 
            // txtPreco
            // 
            txtPreco.Cursor = Cursors.IBeam;
            txtPreco.Font = new Font("Maiandra GD", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreco.Location = new Point(12, 146);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Ex: 10";
            txtPreco.Size = new Size(351, 33);
            txtPreco.TabIndex = 3;
            txtPreco.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Maiandra GD", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(139, 108);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(89, 35);
            lblPreco.TabIndex = 2;
            lblPreco.Text = "Preço";
            // 
            // txtTitulo
            // 
            txtTitulo.Cursor = Cursors.IBeam;
            txtTitulo.Font = new Font("Maiandra GD", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(12, 63);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Ex: O Pequeno Principe";
            txtTitulo.Size = new Size(351, 33);
            txtTitulo.TabIndex = 1;
            txtTitulo.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Maiandra GD", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(139, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(96, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(dgvMostrarLivros);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(381, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 450);
            panel2.TabIndex = 1;
            // 
            // btnExcluir
            // 
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(34, 391);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(351, 48);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir Livro";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvMostrarLivros
            // 
            dgvMostrarLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarLivros.Location = new Point(0, 0);
            dgvMostrarLivros.Name = "dgvMostrarLivros";
            dgvMostrarLivros.Size = new Size(419, 378);
            dgvMostrarLivros.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Cadastrar ou Consultar Livro";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMostrarLivros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private TextBox txtQuantidadeEstoque;
        private Label lblQuantidadeEstoque;
        private TextBox txtPreco;
        private Label lblPreco;
        private Button btnVoltar;
        private Button btnCadastrarLivro;
        private Button btnExcluir;
        private DataGridView dgvMostrarLivros;
    }
}