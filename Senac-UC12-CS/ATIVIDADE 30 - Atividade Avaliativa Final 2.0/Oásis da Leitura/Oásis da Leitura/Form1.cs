using System.Diagnostics;

namespace Oásis_da_Leitura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
