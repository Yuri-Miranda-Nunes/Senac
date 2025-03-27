namespace Oásis_da_Leitura
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnCadastrarLivro = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnCadastrarFuncionario = new Button();
            panel3 = new Panel();
            btnSair = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 9);
            label1.Name = "label1";
            label1.Size = new Size(345, 77);
            label1.TabIndex = 0;
            label1.Text = "Tela Inicial";
            // 
            // btnCadastrarLivro
            // 
            btnCadastrarLivro.BackgroundImage = (Image)resources.GetObject("btnCadastrarLivro.BackgroundImage");
            btnCadastrarLivro.Cursor = Cursors.Hand;
            btnCadastrarLivro.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarLivro.Location = new Point(-12, -8);
            btnCadastrarLivro.Name = "btnCadastrarLivro";
            btnCadastrarLivro.Size = new Size(219, 80);
            btnCadastrarLivro.TabIndex = 1;
            btnCadastrarLivro.Text = "Cadastrar Livro";
            btnCadastrarLivro.UseVisualStyleBackColor = true;
            btnCadastrarLivro.Click += btnCadastrarLivro_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCadastrarLivro);
            panel1.Location = new Point(101, 171);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 65);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnCadastrarFuncionario);
            panel2.Location = new Point(101, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 65);
            panel2.TabIndex = 3;
            // 
            // btnCadastrarFuncionario
            // 
            btnCadastrarFuncionario.BackgroundImage = (Image)resources.GetObject("btnCadastrarFuncionario.BackgroundImage");
            btnCadastrarFuncionario.Cursor = Cursors.Hand;
            btnCadastrarFuncionario.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarFuncionario.Location = new Point(-12, -8);
            btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            btnCadastrarFuncionario.Size = new Size(219, 80);
            btnCadastrarFuncionario.TabIndex = 1;
            btnCadastrarFuncionario.Text = "Cadastrar Funcionário";
            btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            btnCadastrarFuncionario.Click += btnCadastrarFuncionario_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnSair);
            panel3.Location = new Point(360, 357);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 65);
            panel3.TabIndex = 4;
            // 
            // btnSair
            // 
            btnSair.BackgroundImage = (Image)resources.GetObject("btnSair.BackgroundImage");
            btnSair.Cursor = Cursors.Hand;
            btnSair.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(-12, -8);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(219, 80);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Maiandra GD", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(683, 164);
            label2.Name = "label2";
            label2.Size = new Size(193, 151);
            label2.TabIndex = 5;
            label2.Text = "Sobre Mim";
            label2.TextAlign = ContentAlignment.BottomCenter;
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 450);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Maiandra GD", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tela Inicial";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCadastrarLivro;
        private Panel panel1;
        private Panel panel2;
        private Button btnCadastrarFuncionario;
        private Panel panel3;
        private Button button1;
        private Button btnSair;
        private Label label2;
    }
}
