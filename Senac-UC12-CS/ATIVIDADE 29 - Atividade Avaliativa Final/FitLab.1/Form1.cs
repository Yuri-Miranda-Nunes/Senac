using System.Diagnostics;

namespace FIT_ACADEMIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();

            this.Hide();

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                // URL que você deseja abrir
                string url = "https://github.com/Yuri-Miranda-Nunes";

                // Abrir o navegador padrão com a URL
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Tratar possíveis erros (ex.: navegador não encontrado)
                MessageBox.Show($"Erro ao abrir o site: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
