namespace _26___Leitura_de_solicitação_de_cliente
{
    partial class FrmCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            lblVoltar = new Label();
            txtNomeproduto = new TextBox();
            txtCodigoproduto = new TextBox();
            txtQantidade = new TextBox();
            txtPreco = new TextBox();
            txtDescricao = new TextBox();
            cbnTipo = new ComboBox();
            btnSalvar = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.ForeColor = Color.Chartreuse;
            label1.Location = new Point(-36, 104);
            label1.Name = "label1";
            label1.Padding = new Padding(3670, 150, 359, 150);
            label1.Size = new Size(4029, 315);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 104);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 200, 83);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(175, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 39);
            textBox1.TabIndex = 2;
            textBox1.Text = "Cadastro de Produtos";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblVoltar
            // 
            lblVoltar.Cursor = Cursors.Hand;
            lblVoltar.ForeColor = SystemColors.ButtonHighlight;
            lblVoltar.Image = (Image)resources.GetObject("lblVoltar.Image");
            lblVoltar.Location = new Point(12, 9);
            lblVoltar.Name = "lblVoltar";
            lblVoltar.Padding = new Padding(20);
            lblVoltar.Size = new Size(40, 40);
            lblVoltar.TabIndex = 3;
            lblVoltar.Click += btnVoltar_Click;
            // 
            // txtNomeproduto
            // 
            txtNomeproduto.BackColor = Color.WhiteSmoke;
            txtNomeproduto.Font = new Font("Swis721 Blk BT", 9.75F);
            txtNomeproduto.Location = new Point(12, 118);
            txtNomeproduto.Name = "txtNomeproduto";
            txtNomeproduto.PlaceholderText = "Nome do Produto";
            txtNomeproduto.Size = new Size(718, 23);
            txtNomeproduto.TabIndex = 4;
            // 
            // txtCodigoproduto
            // 
            txtCodigoproduto.BackColor = Color.WhiteSmoke;
            txtCodigoproduto.Font = new Font("Swis721 Blk BT", 9.75F);
            txtCodigoproduto.Location = new Point(12, 147);
            txtCodigoproduto.Name = "txtCodigoproduto";
            txtCodigoproduto.PlaceholderText = "Código do Produto";
            txtCodigoproduto.Size = new Size(718, 23);
            txtCodigoproduto.TabIndex = 5;
            // 
            // txtQantidade
            // 
            txtQantidade.BackColor = Color.WhiteSmoke;
            txtQantidade.Font = new Font("Swis721 Blk BT", 9.75F);
            txtQantidade.Location = new Point(12, 176);
            txtQantidade.Name = "txtQantidade";
            txtQantidade.PlaceholderText = "Quantidade em Estoque";
            txtQantidade.Size = new Size(718, 23);
            txtQantidade.TabIndex = 6;
            // 
            // txtPreco
            // 
            txtPreco.BackColor = Color.WhiteSmoke;
            txtPreco.Font = new Font("Swis721 Blk BT", 9.75F);
            txtPreco.Location = new Point(12, 205);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Preço de Venda";
            txtPreco.Size = new Size(718, 23);
            txtPreco.TabIndex = 7;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.WhiteSmoke;
            txtDescricao.Font = new Font("Swis721 Blk BT", 9.75F);
            txtDescricao.Location = new Point(12, 234);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição do Produto (opcional)";
            txtDescricao.Size = new Size(718, 23);
            txtDescricao.TabIndex = 8;
            // 
            // cbnTipo
            // 
            cbnTipo.BackColor = Color.WhiteSmoke;
            cbnTipo.Font = new Font("Swis721 Blk BT", 9.75F);
            cbnTipo.FormattingEnabled = true;
            cbnTipo.Items.AddRange(new object[] { "Eletrônicos", "Vestuário", "Alimentos" });
            cbnTipo.Location = new Point(12, 263);
            cbnTipo.Name = "cbnTipo";
            cbnTipo.Size = new Size(718, 24);
            cbnTipo.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SpringGreen;
            btnSalvar.Font = new Font("Swis721 Blk BT", 9.75F);
            btnSalvar.Location = new Point(630, 335);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 40);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btn_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.SpringGreen;
            btnLimpar.Font = new Font("Swis721 Blk BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(12, 335);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(100, 40);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += button1_Click;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 200, 83);
            ClientSize = new Size(742, 387);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(cbnTipo);
            Controls.Add(txtDescricao);
            Controls.Add(txtPreco);
            Controls.Add(txtQantidade);
            Controls.Add(txtCodigoproduto);
            Controls.Add(txtNomeproduto);
            Controls.Add(lblVoltar);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCadastro";
            Text = "Tela de Cadastro de Produtos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label lblVoltar;
        private TextBox txtNomeproduto;
        private TextBox txtCodigoproduto;
        private TextBox txtQantidade;
        private TextBox txtPreco;
        private TextBox txtDescricao;
        private ComboBox cbnTipo;
        private Button btnSalvar;
        private Button btnLimpar;
    }
}
