namespace FitLab
{
    partial class frmTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaInicial));
            lblBoasVindas = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBoasVindas.ForeColor = Color.White;
            lblBoasVindas.Location = new Point(218, 9);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(364, 69);
            lblBoasVindas.TabIndex = 0;
            lblBoasVindas.Text = "Boas vindas a";
            lblBoasVindas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(297, 67);
            label1.Name = "label1";
            label1.Size = new Size(211, 73);
            label1.TabIndex = 1;
            label1.Text = "FitLab";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(352, 240);
            button1.Name = "button1";
            button1.Size = new Size(96, 44);
            button1.TabIndex = 2;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lblBoasVindas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTelaInicial";
            Text = "Tela Inicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBoasVindas;
        private Label label1;
        private Button button1;
    }
}
