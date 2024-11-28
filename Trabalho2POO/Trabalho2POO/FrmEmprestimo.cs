using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho2POO
{
    public partial class FrmEmprestimo : Form
    {
        public FrmEmprestimo()
        {
            InitializeComponent();
        }

        private void FrmEmprestimo_Load(object sender, EventArgs e)
        {
            using (var conexao = DBConnection.Instance.ObterConexao())
            {

                string query = "Select nome from cliente;";
                MySqlCommand command = new MySqlCommand(query, conexao);
                conexao.Open();
                MySqlDataReader reader = command.ExecuteReader();

                cb_cliente.Items.Clear();

                while (reader.Read())
                {
                    cb_cliente.Items.Add(reader.GetString("nome"));
                }

                DBConnection.Instance.FecharConexao();
            }

            using (var conexao = DBConnection.Instance.ObterConexao())
            {

                string query = "Select titulo from livro where status = 'd';";
                MySqlCommand command = new MySqlCommand(query, conexao);
                conexao.Open();
                MySqlDataReader reader = command.ExecuteReader();

                cb_livro.Items.Clear();

                while (reader.Read())
                {
                    cb_livro.Items.Add(reader.GetString("titulo"));
                }

                DBConnection.Instance.FecharConexao();

            }
            using (var conexao = DBConnection.Instance.ObterConexao())
            {

                string query = "Select concat(nome,sobrenome) as fnome from funcionario;";
                MySqlCommand command = new MySqlCommand(query, conexao);
                conexao.Open();
                MySqlDataReader reader = command.ExecuteReader();

                cb_funcionario.Items.Clear();

                while (reader.Read())
                {
                    cb_funcionario.Items.Add(reader.GetString("fnome"));
                }

                DBConnection.Instance.FecharConexao();

            }
            using (var conexao = DBConnection.Instance.ObterConexao())
            {

                string query = "select * from livro " +
                    "inner join emprestimo on " +
                    "Livro_idLivro = idLivro;";
                MySqlCommand command = new MySqlCommand(query, conexao);
                conexao.Open();
                MySqlDataReader reader = command.ExecuteReader();

                cb_devolucao.Items.Clear();

                while (reader.Read())
                {
                    cb_devolucao.Items.Add(reader.GetString("titulo"));
                }

                DBConnection.Instance.FecharConexao();


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idlivro = 0;
            int idcliente = 0;
            int idfuncionario = 0;
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "select idLivro from livro where titulo=@titulo;";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@titulo", cb_livro.Text);
                conexao.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idlivro = reader.GetInt32("idLivro");
                }

                DBConnection.Instance.FecharConexao();
            }
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "select idCliente from cliente where nome=@nome;";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@nome", cb_cliente.Text);
                conexao.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idcliente = reader.GetInt32("idCliente");
                }


                DBConnection.Instance.FecharConexao();
            }
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "select idFuncionario from funcionario where concat(nome,sobrenome)=@nome;";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@nome", cb_funcionario.Text);
                conexao.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idfuncionario = reader.GetInt32("idFuncionario");
                }

                DBConnection.Instance.FecharConexao();
            }
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "INSERT INTO emprestimo(Livro_idLivro,Cliente_idCliente, Funcionario_idFuncionario, dataEmprestimo) VALUES" +
                    "(@titulo, @cliente, @funcionario, @date)";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@titulo", idlivro);
                command.Parameters.AddWithValue("@cliente", idcliente);
                command.Parameters.AddWithValue("@funcionario", idfuncionario);
                command.Parameters.AddWithValue("@date", DateTime.Now.Date);

                conexao.Open();
                command.ExecuteNonQuery();
                DBConnection.Instance.FecharConexao();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idlivro = 0;
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "select * from livro " +
                    "inner join emprestimo on " +
                    "Livro_idLivro = idLivro " +
                    "where titulo = @titulo;";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@titulo", cb_devolucao.Text);
                conexao.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idlivro = reader.GetInt32("idLivro");
                }

                DBConnection.Instance.FecharConexao();
            }

            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "DELETE FROM emprestimo where Livro_idLivro=@titulo;";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@titulo", idlivro);

                conexao.Open();
                command.ExecuteNonQuery();
                DBConnection.Instance.FecharConexao();
            }
            
        }
    }
}
