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
    public partial class Form4 : Form
    {
        string strDeConexaoBD = "Server=localhost;Database=academia;UserID=root;Password=;";
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Pegando os valores das TextBox
            string nome = txtNome.Text;
            string especialidade = txtEspecialidade.Text;
            string telefone = txtTelefone.Text;

            // Verificando se os campos estão preenchidos
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(especialidade) || string.IsNullOrEmpty(telefone))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            try
            {
                // Criando a conexão com o banco de dados
                using (MySqlConnection conn = new MySqlConnection(strDeConexaoBD))
                {
                    // Abrindo a conexão com o banco
                    conn.Open();

                    // Criando o comando SQL de inserção
                    string comandoSQL = "INSERT INTO instrutor (nome, especialidade, telefone) VALUES (@nome, @especialidade, @telefone)";

                    // Criando o comando e adicionando os parâmetros
                    using (MySqlCommand cmd = new MySqlCommand(comandoSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@especialidade", especialidade);
                        cmd.Parameters.AddWithValue("@telefone", telefone);

                        // Executando o comando
                        cmd.ExecuteNonQuery();
                    }
                }

                // Mensagem de sucesso
                MessageBox.Show("Aluno cadastrado com sucesso!");

                // Limpando as TextBox após o cadastro
                txtNome.Clear();
                txtEspecialidade.Clear();
                txtTelefone.Clear();

                ExibirInstrutores();

            }
            catch (Exception ex)
            {
                // Exibindo mensagens de erro
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }

            

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ExibirInstrutores();
        }
        private void ExibirInstrutores()
        {
            try
            {
                // Criando a conexão com o banco de dados
                using (MySqlConnection conn = new MySqlConnection(strDeConexaoBD))
                {
                    // Comando SQL para selecionar todos os alunos
                    string comandoSQL = "SELECT id_instrutor, nome, especialidade, telefone FROM instrutor";

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
                            dgvInstrutores.DataSource = dt;
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }

        private void dgvInstrutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
