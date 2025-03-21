namespace Tela_do_banco_de_dados_biblioteca
{
    partial class frmendereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmendereco));
            button1 = new Button();
            label1 = new Label();
            lblTitulo = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(246, 279);
            button1.Name = "button1";
            button1.Size = new Size(103, 36);
            button1.TabIndex = 18;
            button1.Text = "Proximo";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(175, 91);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 11;
            label1.Text = "CEP";
            label1.Click += label1_Click_1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(175, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(254, 33);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Tela de Cadastro";
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(175, 221);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Insira sua senha";
            textBox3.Size = new Size(254, 23);
            textBox3.TabIndex = 16;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(172, 203);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 15;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(175, 149);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 167);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Insira seu email";
            textBox2.Size = new Size(254, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 109);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Insira seu Nome";
            textBox1.Size = new Size(254, 23);
            textBox1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(150, 30);
            label5.Name = "label5";
            label5.Padding = new Padding(150);
            label5.Size = new Size(300, 315);
            label5.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(175, 149);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 19;
            label4.Text = "Rua";
            label4.Click += label4_Click;
            // 
            // frmendereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(624, 391);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmendereco";
            Text = "Tela de Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label lblTitulo;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
    }
}