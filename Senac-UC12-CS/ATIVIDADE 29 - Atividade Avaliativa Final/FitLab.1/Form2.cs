using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FIT_ACADEMIA
{
    public partial class Form2 : Form
    {
        string conexao = "Server=localhost;Database=academia;User ID=root;Password=;";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();

        }

        private void btn_Click_1(object sender, EventArgs e)
        {
            // Pegando os valores das TextBox
            string nome = txtnome.Text;
            string endereco = txtendereco.Text;
            string telefone = txttelefone.Text;

            // Verificando se os campos estão preenchidos
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco) || string.IsNullOrEmpty(telefone))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            try
            {
                // Criando a conexão com o banco de dados
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    // Abrindo a conexão com o banco
                    conn.Open();

                    // Criando o comando SQL de inserção
                    string comandoSQL = "INSERT INTO aluno (nome, endereco, telefone) VALUES (@nome, @endereco, @telefone)";

                    // Criando o comando e adicionando os parâmetros
                    using (MySqlCommand cmd = new MySqlCommand(comandoSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@telefone", telefone);

                        // Executando o comando
                        cmd.ExecuteNonQuery();
                    }
                }

                // Mensagem de sucesso
                MessageBox.Show("Aluno cadastrado com sucesso!");

                // Limpando as TextBox após o cadastro
                txtnome.Clear();
                txtendereco.Clear();
                txttelefone.Clear();
            }
            catch (Exception ex)
            {
                // Exibindo mensagens de erro
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
       
    }
    }
}
