namespace Oásis_da_Leitura
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel2 = new Panel();
            btnExcluirFuncionario = new Button();
            dgvMostrarFuncionario = new DataGridView();
            panel1 = new Panel();
            btnVoltar = new Button();
            btnCadastrarFuncionario = new Button();
            txtSalario = new TextBox();
            lblSalario = new Label();
            txtCargo = new TextBox();
            lblCargo = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMostrarFuncionario).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExcluirFuncionario);
            panel2.Controls.Add(dgvMostrarFuncionario);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(381, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 450);
            panel2.TabIndex = 3;
            // 
            // btnExcluirFuncionario
            // 
            btnExcluirFuncionario.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirFuncionario.Location = new Point(34, 391);
            btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            btnExcluirFuncionario.Size = new Size(351, 48);
            btnExcluirFuncionario.TabIndex = 7;
            btnExcluirFuncionario.Text = "Excluir Funcionário";
            btnExcluirFuncionario.UseVisualStyleBackColor = true;
            btnExcluirFuncionario.Click += btnExcluirFuncionario_Click;
            // 
            // dgvMostrarFuncionario
            // 
            dgvMostrarFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarFuncionario.Location = new Point(0, 0);
            dgvMostrarFuncionario.Name = "dgvMostrarFuncionario";
            dgvMostrarFuncionario.Size = new Size(419, 378);
            dgvMostrarFuncionario.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(btnCadastrarFuncionario);
            panel1.Controls.Add(txtSalario);
            panel1.Controls.Add(lblSalario);
            panel1.Controls.Add(txtCargo);
            panel1.Controls.Add(lblCargo);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblNome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 450);
            panel1.TabIndex = 2;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Maiandra GD", 18F, FontStyle.Bold);
            btnVoltar.Location = new Point(12, 391);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(351, 47);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCadastrarFuncionario
            // 
            btnCadastrarFuncionario.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarFuncionario.Location = new Point(12, 279);
            btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            btnCadastrarFuncionario.Size = new Size(351, 48);
            btnCadastrarFuncionario.TabIndex = 6;
            btnCadastrarFuncionario.Text = "Cadastrar Funcionário";
            btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            btnCadastrarFuncionario.Click += btnCadastrarFuncionario_Click;
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Maiandra GD", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSalario.Location = new Point(12, 229);
            txtSalario.Name = "txtSalario";
            txtSalario.PlaceholderText = "Ex: 1200";
            txtSalario.Size = new Size(351, 33);
            txtSalario.TabIndex = 5;
            txtSalario.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Maiandra GD", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalario.Location = new Point(135, 191);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(105, 35);
            lblSalario.TabIndex = 4;
            lblSalario.Text = "Salario";
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Maiandra GD", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCargo.Location = new Point(12, 146);
            txtCargo.Name = "txtCargo";
            txtCargo.PlaceholderText = "Ex: Assistente de Blibiotecario";
            txtCargo.Size = new Size(351, 33);
            txtCargo.TabIndex = 3;
            txtCargo.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Maiandra GD", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCargo.Location = new Point(139, 108);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(95, 35);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Cargo";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Maiandra GD", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(12, 63);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Ex: Roberto Gomes da Silva";
            txtNome.Size = new Size(351, 33);
            txtNome.TabIndex = 1;
            txtNome.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Maiandra GD", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(139, 25);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(98, 35);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Cadastrar ou Consultar Funcionário";
            Load += Form3_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMostrarFuncionario).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnExcluirFuncionario;
        private DataGridView dgvMostrarFuncionario;
        private Panel panel1;
        private Button btnVoltar;
        private Button btnCadastrarFuncionario;
        private TextBox txtSalario;
        private Label lblSalario;
        private TextBox txtCargo;
        private Label lblCargo;
        private TextBox txtNome;
        private Label lblNome;
    }
}