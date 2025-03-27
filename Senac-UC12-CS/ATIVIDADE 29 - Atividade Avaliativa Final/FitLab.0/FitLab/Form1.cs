namespace FitLab
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma instância do Form2
            Frm1 form2 = new Frm1();

            // Exibe o Form2
            form2.Show();

            // Opcional: Esconde o Form1 (se desejar que ele desapareça)
            this.Hide();
        }
    }
}
