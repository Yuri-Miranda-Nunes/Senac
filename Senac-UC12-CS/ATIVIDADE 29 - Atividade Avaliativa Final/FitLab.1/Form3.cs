using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT_ACADEMIA
{
    public partial class Form3 : Form
    {
        string conexao = "Server=localhost;Database=academia;User ID=root;Password=;";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ExibirAlunos();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();

        }

        private void ExibirAlunos()
        {
            try
            {
                // Criando a conexão com o banco de dados
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    // Comando SQL para selecionar todos os alunos
                    string comandoSQL = "SELECT id_aluno, nome, endereco, telefone FROM aluno";

                    // Criando o comando
                    using (MySqlCommand cmd = new MySqlCommand(comandoSQL, conn))
                    {
                        // Abrindo a conexão
                        conn.Open();

                        // Criando o DataAdapter para preencher o DataTable
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            // Criando um DataTable para armazenar os dados
                            DataTable dt = new DataTable();

                            // Preenchendo o DataTable com os dados da consulta
                            da.Fill(dt);

                            // Atribuindo o DataTable como fonte de dados para o DataGridView
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibindo mensagem de erro
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
