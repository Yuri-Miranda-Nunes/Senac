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

namespace Oásis_da_Leitura
{
    public partial class Form3 : Form
    {
        string strDeConexaoBD = "Server=localhost;Database=livraria;UserID=root;Password=;";
        public Form3()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            // Pegando os valores das TextBox
            string nome = txtNome.Text;
            string cargo = txtCargo.Text;
            string salario = txtSalario.Text;

            // Verificando se os campos estão preenchidos
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(salario))
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
                    string comandoSQL = "INSERT INTO funcionario (nome, cargo, salario) VALUES (@nome, @cargo, @salario)";

                    // Criando o comando e adicionando os parâmetros
                    using (MySqlCommand cmd = new MySqlCommand(comandoSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@cargo", cargo);
                        cmd.Parameters.AddWithValue("@salario", salario);

                        // Executando o comando
                        cmd.ExecuteNonQuery();
                    }
                }

                // Mensagem de sucesso
                MessageBox.Show("Funcionário cadastrado com sucesso!");

                // Limpando as TextBox após o cadastro
                txtNome.Clear();
                txtCargo.Clear();
                txtSalario.Clear();

                ExibirFuncionario();

            }
            catch (Exception ex)
            {
                // Exibindo mensagens de erro
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ExibirFuncionario();
        }
        private void ExibirFuncionario()
        {
            try
            {
                // Criando a conexão com o banco de dados
                using (MySqlConnection conn = new MySqlConnection(strDeConexaoBD))
                {
                    // Comando SQL para selecionar todos os alunos
                    string comandoSQL = "SELECT id_funcionario, nome, cargo, salario FROM funcionario";

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
                            dgvMostrarFuncionario.DataSource = dt;
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

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            if (dgvMostrarFuncionario.SelectedRows.Count > 0)
            {
                // Obter o Id do registro selecionado
                int idParaExcluir = Convert.ToInt32(dgvMostrarFuncionario.SelectedRows[0].Cells["id_funcionario"].Value); // Substitua "Id" pelo nome correto da coluna

                // Comando SQL para exclusão
                string query = "DELETE FROM funcionario WHERE id_funcionario = @id_funcionario";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(strDeConexaoBD))
                    {
                        conn.Open();

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Definir o valor do parâmetro @id_livro
                            cmd.Parameters.AddWithValue("@id_funcionario", idParaExcluir);

                            // Executar o comando DELETE
                            int linhasAfetadas = cmd.ExecuteNonQuery();

                            // Verificar se a exclusão foi bem-sucedida
                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Registro excluído com sucesso!");
                                // Atualizar o DataGridView após a exclusão
                                ExibirFuncionario();
                            }
                            else
                            {
                                MessageBox.Show("Registro não encontrado.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um registro para excluir.");
            }
        }
    }
}
