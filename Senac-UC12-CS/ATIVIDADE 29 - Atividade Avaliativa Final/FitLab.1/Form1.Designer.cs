namespace FIT_ACADEMIA
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
            btn = new Button();
            btn2 = new Button();
            btnsair = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Font = new Font("Candara", 12F, FontStyle.Bold);
            btn.Location = new Point(12, 12);
            btn.Name = "btn";
            btn.Size = new Size(154, 36);
            btn.TabIndex = 0;
            btn.Text = "Cadastar Aluno";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Candara", 12F, FontStyle.Bold);
            btn2.Location = new Point(12, 96);
            btn2.Name = "btn2";
            btn2.Size = new Size(154, 36);
            btn2.TabIndex = 0;
            btn2.Text = "Alunos Cadastrados";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btnsair
            // 
            btnsair.Location = new Point(184, 151);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(121, 23);
            btnsair.TabIndex = 2;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = true;
            btnsair.Click += btnsair_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Candara", 12F, FontStyle.Bold);
            button1.Location = new Point(12, 54);
            button1.Name = "button1";
            button1.Size = new Size(154, 36);
            button1.TabIndex = 3;
            button1.Text = "Cadastrar Instrutor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(395, 28);
            label1.Name = "label1";
            label1.Size = new Size(81, 104);
            label1.TabIndex = 4;
            label1.Text = "Sobre Mim";
            label1.TextAlign = ContentAlignment.BottomCenter;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(488, 186);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnsair);
            Controls.Add(btn2);
            Controls.Add(btn);
            Name = "Form1";
            Text = "FIT ACADEMIA";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn;
        private Button btn2;
        private Button btnsair;
        private Button button1;
        private Button btnCadastrados;
        private Label label1;
    }
}
