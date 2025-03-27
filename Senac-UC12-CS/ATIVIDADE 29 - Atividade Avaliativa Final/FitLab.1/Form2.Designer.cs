namespace FIT_ACADEMIA
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
            lblnome = new Label();
            lblendereco = new Label();
            lbltelefone = new Label();
            txtnome = new TextBox();
            txtendereco = new TextBox();
            txttelefone = new TextBox();
            btn = new Button();
            btnvoltar = new Button();
            SuspendLayout();
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(94, 60);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(40, 15);
            lblnome.TabIndex = 0;
            lblnome.Text = "Nome";
            // 
            // lblendereco
            // 
            lblendereco.AutoSize = true;
            lblendereco.Location = new Point(94, 116);
            lblendereco.Name = "lblendereco";
            lblendereco.Size = new Size(56, 15);
            lblendereco.TabIndex = 1;
            lblendereco.Text = "Endereço";
            // 
            // lbltelefone
            // 
            lbltelefone.AutoSize = true;
            lbltelefone.Location = new Point(94, 169);
            lbltelefone.Name = "lbltelefone";
            lbltelefone.Size = new Size(51, 15);
            lbltelefone.TabIndex = 2;
            lbltelefone.Text = "Telefone";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(94, 78);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(168, 23);
            txtnome.TabIndex = 3;
            // 
            // txtendereco
            // 
            txtendereco.Location = new Point(94, 134);
            txtendereco.Name = "txtendereco";
            txtendereco.Size = new Size(169, 23);
            txtendereco.TabIndex = 4;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(94, 187);
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(167, 23);
            txttelefone.TabIndex = 5;
            // 
            // btn
            // 
            btn.Location = new Point(92, 236);
            btn.Name = "btn";
            btn.Size = new Size(169, 23);
            btn.TabIndex = 6;
            btn.Text = "cadastrar";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click_1;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(94, 282);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(167, 23);
            btnvoltar.TabIndex = 7;
            btnvoltar.Text = "Página Inicial";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 450);
            Controls.Add(btnvoltar);
            Controls.Add(btn);
            Controls.Add(txttelefone);
            Controls.Add(txtendereco);
            Controls.Add(txtnome);
            Controls.Add(lbltelefone);
            Controls.Add(lblendereco);
            Controls.Add(lblnome);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnome;
        private Label lblendereco;
        private Label lbltelefone;
        private TextBox txtnome;
        private TextBox txtendereco;
        private TextBox txttelefone;
        private Button btn;
        private Button btnvoltar;
    }
}