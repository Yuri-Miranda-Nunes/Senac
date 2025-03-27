namespace FitLab
{
    partial class Frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm1));
            pnlHeader = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            ptbHamb = new PictureBox();
            flwSideBar = new FlowLayoutPanel();
            pnlSobre = new Panel();
            btnSobre = new Button();
            pnlSair = new Panel();
            btnSair = new Button();
            pnlConfig = new Panel();
            btnConfig = new Button();
            pnlInstrutores = new Panel();
            btnMostrarInstrutores = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbHamb).BeginInit();
            pnlSobre.SuspendLayout();
            pnlSair.SuspendLayout();
            pnlConfig.SuspendLayout();
            pnlInstrutores.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(nightControlBox1);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(ptbHamb);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 37);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += panel1_Paint;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(661, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(50, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // ptbHamb
            // 
            ptbHamb.BackColor = Color.Transparent;
            ptbHamb.Image = (Image)resources.GetObject("ptbHamb.Image");
            ptbHamb.Location = new Point(3, 3);
            ptbHamb.Name = "ptbHamb";
            ptbHamb.Size = new Size(41, 31);
            ptbHamb.SizeMode = PictureBoxSizeMode.CenterImage;
            ptbHamb.TabIndex = 0;
            ptbHamb.TabStop = false;
            ptbHamb.Click += pictureBox1_Click;
            // 
            // flwSideBar
            // 
            flwSideBar.BackColor = Color.Black;
            flwSideBar.Dock = DockStyle.Left;
            flwSideBar.Location = new Point(0, 37);
            flwSideBar.Name = "flwSideBar";
            flwSideBar.Size = new Size(200, 413);
            flwSideBar.TabIndex = 1;
            flwSideBar.Paint += flwSideBar_Paint;
            // 
            // pnlSobre
            // 
            pnlSobre.Controls.Add(btnSobre);
            pnlSobre.Location = new Point(0, 330);
            pnlSobre.Name = "pnlSobre";
            pnlSobre.Size = new Size(198, 39);
            pnlSobre.TabIndex = 6;
            pnlSobre.Paint += panel5_Paint;
            // 
            // btnSobre
            // 
            btnSobre.BackColor = Color.Black;
            btnSobre.Cursor = Cursors.Hand;
            btnSobre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSobre.ForeColor = Color.White;
            btnSobre.ImageAlign = ContentAlignment.MiddleLeft;
            btnSobre.Location = new Point(-4, -6);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(207, 51);
            btnSobre.TabIndex = 2;
            btnSobre.Text = "Sobre";
            btnSobre.UseVisualStyleBackColor = false;
            // 
            // pnlSair
            // 
            pnlSair.Controls.Add(btnSair);
            pnlSair.Location = new Point(0, 410);
            pnlSair.Name = "pnlSair";
            pnlSair.Size = new Size(198, 39);
            pnlSair.TabIndex = 7;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Black;
            btnSair.Cursor = Cursors.Hand;
            btnSair.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(-4, -6);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(207, 51);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // pnlConfig
            // 
            pnlConfig.Controls.Add(btnConfig);
            pnlConfig.Location = new Point(0, 370);
            pnlConfig.Name = "pnlConfig";
            pnlConfig.Size = new Size(198, 39);
            pnlConfig.TabIndex = 9;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.Black;
            btnConfig.Cursor = Cursors.Hand;
            btnConfig.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfig.ForeColor = Color.White;
            btnConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfig.Location = new Point(-4, -6);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(207, 51);
            btnConfig.TabIndex = 2;
            btnConfig.Text = "Configurações";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // pnlInstrutores
            // 
            pnlInstrutores.Controls.Add(btnMostrarInstrutores);
            pnlInstrutores.Location = new Point(0, 38);
            pnlInstrutores.Name = "pnlInstrutores";
            pnlInstrutores.Size = new Size(198, 39);
            pnlInstrutores.TabIndex = 8;
            // 
            // btnMostrarInstrutores
            // 
            btnMostrarInstrutores.BackColor = Color.Black;
            btnMostrarInstrutores.Cursor = Cursors.Hand;
            btnMostrarInstrutores.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarInstrutores.ForeColor = Color.White;
            btnMostrarInstrutores.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarInstrutores.Location = new Point(-4, -7);
            btnMostrarInstrutores.Name = "btnMostrarInstrutores";
            btnMostrarInstrutores.Size = new Size(207, 51);
            btnMostrarInstrutores.TabIndex = 2;
            btnMostrarInstrutores.Text = "Instrutores";
            btnMostrarInstrutores.UseVisualStyleBackColor = false;
            // 
            // Frm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlConfig);
            Controls.Add(pnlInstrutores);
            Controls.Add(pnlSair);
            Controls.Add(pnlSobre);
            Controls.Add(flwSideBar);
            Controls.Add(pnlHeader);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm1";
            Text = "Form2";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbHamb).EndInit();
            pnlSobre.ResumeLayout(false);
            pnlSair.ResumeLayout(false);
            pnlConfig.ResumeLayout(false);
            pnlInstrutores.ResumeLayout(false);
            ResumeLayout(false);
        }
        // Add this method to the Frm1 class
        private void flwSideBar_Paint(object sender, PaintEventArgs e)
        {
            // Add your custom paint logic here if needed
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox ptbHamb;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel flwSideBar;
        private Panel pnlSobre;
        private Button btnSobre;
        private Panel pnlSair;
        private Button btnSair;
        private Panel pnlConfig;
        private Button btnConfig;
        private Panel pnlInstrutores;
        private Button btnMostrarInstrutores;
    }
}