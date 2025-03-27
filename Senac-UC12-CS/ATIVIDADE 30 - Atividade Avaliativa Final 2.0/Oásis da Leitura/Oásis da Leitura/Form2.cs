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
    public partial class Form2 : Form
    {
        string strDeConexaoBD = "Server=localhost;Database=livraria;UserID=root;Password=;";
        public Form2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            // Pegando os valores das TextBox
            string titulo = txtTitulo.Text;
            string preco = txtPreco.Text;
            string quantidade_estoque = txtQuantidadeEstoque.Text;

            // Verificando se os campos estão preenchidos
            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(preco) || string.IsNullOrEmpty(quantidade_estoque))
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
                    string comandoSQL = "INSERT INTO livro (titulo, preco, quantidade_estoque) VALUES (@titulo, @preco, @quantidade_estoque)";

                    // Criando o comando e adicionando os parâmetros
                    using (MySqlCommand cmd = new MySqlCommand(comandoSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@preco", preco);
                        cmd.Parameters.AddWithValue("@quantidade_estoque", quantidade_estoque);

                        // Executando o comando
                        cmd.ExecuteNonQuery();
                    }
                }

                // Mensagem de sucesso
                MessageBox.Show("Livro cadastrado com sucesso!");

                // Limpando as TextBox após o cadastro
                txtTitulo.Clear();
                txtPreco.Clear();
                txtQuantidadeEstoque.Clear();

                ExibirLivro();

            }
            catch (Exception ex)
            {
                // Exibindo mensagens de erro
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ExibirLivro();
        }
        private void ExibirLivro()
        {
            try
            {
                // Criando a conexão com o banco de dados
                using (MySqlConnection conn = new MySqlConnection(strDeConexaoBD))
                {
                    // Comando SQL para selecionar todos os alunos
                    string comandoSQL = "SELECT id_livro, preco, quantidade_estoque FROM livro";

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
                            dgvMostrarLivros.DataSource = dt;
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvMostrarLivros.SelectedRows.Count > 0)
            {
                // Obter o Id do registro selecionado
                int idParaExcluir = Convert.ToInt32(dgvMostrarLivros.SelectedRows[0].Cells["id_livro"].Value); // Substitua "Id" pelo nome correto da coluna

                // Comando SQL para exclusão
                string query = "DELETE FROM livro WHERE id_livro = @id_livro";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(strDeConexaoBD))
                    {
                        conn.Open();

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Definir o valor do parâmetro @id_livro
                            cmd.Parameters.AddWithValue("@id_livro", idParaExcluir);

                            // Executar o comando DELETE
                            int linhasAfetadas = cmd.ExecuteNonQuery();

                            // Verificar se a exclusão foi bem-sucedida
                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Registro excluído com sucesso!");
                                // Atualizar o DataGridView após a exclusão
                                ExibirLivro();
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
