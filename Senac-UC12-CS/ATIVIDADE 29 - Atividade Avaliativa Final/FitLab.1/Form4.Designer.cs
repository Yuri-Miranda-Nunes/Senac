namespace FIT_ACADEMIA
{
    partial class Form4
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
            lblNome = new Label();
            txtNome = new TextBox();
            txtEspecialidade = new TextBox();
            lblEspecialidade = new Label();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            btnCadastrar = new Button();
            btnVoltar = new Button();
            dgvInstrutores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInstrutores).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(13, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(219, 32);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome (Completo)";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(13, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(373, 29);
            txtNome.TabIndex = 1;
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.Font = new Font("Segoe UI", 12F);
            txtEspecialidade.Location = new Point(13, 111);
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.PlaceholderText = "Musculação, Yoga, etc";
            txtEspecialidade.Size = new Size(374, 29);
            txtEspecialidade.TabIndex = 3;
            // 
            // lblEspecialidade
            // 
            lblEspecialidade.AutoSize = true;
            lblEspecialidade.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblEspecialidade.Location = new Point(13, 76);
            lblEspecialidade.Name = "lblEspecialidade";
            lblEspecialidade.Size = new Size(168, 32);
            lblEspecialidade.TabIndex = 2;
            lblEspecialidade.Text = "Especialidade";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 12F);
            txtTelefone.Location = new Point(13, 178);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(374, 29);
            txtTelefone.TabIndex = 5;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTelefone.Location = new Point(13, 143);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(111, 32);
            lblTelefone.TabIndex = 4;
            lblTelefone.Text = "Telefone";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(12, 213);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(103, 32);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 309);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(103, 32);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dgvInstrutores
            // 
            dgvInstrutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstrutores.Location = new Point(392, 12);
            dgvInstrutores.Name = "dgvInstrutores";
            dgvInstrutores.Size = new Size(439, 329);
            dgvInstrutores.TabIndex = 8;
            dgvInstrutores.CellContentClick += dgvInstrutores_CellContentClick;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 345);
            Controls.Add(dgvInstrutores);
            Controls.Add(btnVoltar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtEspecialidade);
            Controls.Add(lblEspecialidade);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "Form4";
            Text = "Cadastrar Instrutor";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInstrutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtEspecialidade;
        private Label lblEspecialidade;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private Button btnCadastrar;
        private Button btnVoltar;
        private DataGridView dgvInstrutores;
    }
}