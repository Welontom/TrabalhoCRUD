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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Trabalho2POO
{
    public partial class FrmCadstrarLivro : Form
    {
        public FrmCadstrarLivro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "INSERT INTO livro(titulo,exemplar,isbn,autor,anoPublicacao,edicao,status,paginas) " +
                    "VALUES" + "(@titulo, @exemplar, @isbn, @autor, @ano, @edicao, 'd', @paginas)";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@titulo", titulo.Text);
                command.Parameters.AddWithValue("@exemplar", exemplar.Text);
                command.Parameters.AddWithValue("@isbn", isbn.Text);
                command.Parameters.AddWithValue("@autor", autor.Text);
                command.Parameters.AddWithValue("@ano", ano.Text);
                command.Parameters.AddWithValue("@edicao", edicao.Text);
                command.Parameters.AddWithValue("@paginas", paginas.Text);

                conexao.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Created Successfully!");
                DBConnection.Instance.FecharConexao();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "delete from livro where exemplar=@exemplar and isbn=@isbn;";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@exemplar", exemplarrm.Text);
                command.Parameters.AddWithValue("@isbn", isbnrm.Text);

                conexao.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Created Successfully!");
                DBConnection.Instance.FecharConexao();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tituloQ = "";
            int exemplarQ=0;
            string isbnQ="";
            string autorQ="";
            int anoQ=0;
            int edicaoQ=0;
            int paginasQ = 0;

            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "update livro set titulo = @titulo,exemplar=@exemplar,isbn=@isbn,autor=@autor,anoPublicacao=@ano," +
                    "edicao=@edicao,paginas=@paginas where idLivro=@id;";
                MySqlCommand command = new MySqlCommand(query, conexao);
                if (titulo.Text == "")
                {
                    
                        string query2 = "select titulo from livro where idLivro=@id;";
                        MySqlCommand command2 = new MySqlCommand(query2, conexao);
                        command2.Parameters.AddWithValue("@id", idLivro.Text);
                        conexao.Open();
                        MySqlDataReader reader = command2.ExecuteReader();

                        while (reader.Read())
                        {
                            tituloQ = reader.GetString("titulo");
                        }
                        command.Parameters.AddWithValue("@titulo", tituloQ);
                        DBConnection.Instance.FecharConexao();
                        conexao.Close();
                }
                else 
                {
                    command.Parameters.AddWithValue("@titulo", titulo.Text);
                }
                if (exemplar.Text == "")
                {
                    string query2 = "select exemplar from livro where idLivro=@id;";
                    MySqlCommand command2 = new MySqlCommand(query2, conexao);
                    command2.Parameters.AddWithValue("@id", idLivro.Text);
                    conexao.Open();
                    MySqlDataReader reader = command2.ExecuteReader();

                    while (reader.Read())
                    {
                        exemplarQ = reader.GetInt16("exemplar");
                    }
                    command.Parameters.AddWithValue("@exemplar", exemplarQ);
                    DBConnection.Instance.FecharConexao();
                    conexao.Close();

                }
                else
                {
                    command.Parameters.AddWithValue("@exemplar", exemplar.Text);
                }
                if (isbn.Text == "")
                {
                    string query2 = "select isbn from livro where idLivro=@id;";
                    MySqlCommand command2 = new MySqlCommand(query2, conexao);
                    command2.Parameters.AddWithValue("@id", idLivro.Text);
                    conexao.Open();
                    MySqlDataReader reader = command2.ExecuteReader();

                    while (reader.Read())
                    {
                        isbnQ = reader.GetString("isbn");
                    }
                    command.Parameters.AddWithValue("@isbn", isbnQ);
                    DBConnection.Instance.FecharConexao();
                    conexao.Close();
                }
                else
                {
                    command.Parameters.AddWithValue("@isbn", isbn.Text);
                }
                if (autor.Text == "")
                {
                    string query2 = "select autor from livro where idLivro=@id;";
                    MySqlCommand command2 = new MySqlCommand(query2, conexao);
                    command2.Parameters.AddWithValue("@id", idLivro.Text);
                    conexao.Open();
                    MySqlDataReader reader = command2.ExecuteReader();

                    while (reader.Read())
                    {
                        autorQ = reader.GetString("autor");
                    }
                    command.Parameters.AddWithValue("@autor", autorQ);
                    DBConnection.Instance.FecharConexao();
                    conexao.Close();
                }
                else
                {
                    command.Parameters.AddWithValue("@autor", autor.Text);
                }
                if (ano.Text == "")
                {
                    string query2 = "select anoPublicacao from livro where idLivro=@id;";
                    MySqlCommand command2 = new MySqlCommand(query2, conexao);
                    command2.Parameters.AddWithValue("@id", idLivro.Text);
                    conexao.Open();
                    MySqlDataReader reader = command2.ExecuteReader();

                    while (reader.Read())
                    {
                        anoQ = reader.GetInt16("anoPublicacao");
                    }
                    command.Parameters.AddWithValue("@ano", anoQ);
                    DBConnection.Instance.FecharConexao();
                    conexao.Close();
                }
                else
                {
                    command.Parameters.AddWithValue("@ano", ano.Text);
                }
                if (edicao.Text == "")
                {
                    string query2 = "select edicao from livro where idLivro=@id;";
                    MySqlCommand command2 = new MySqlCommand(query2, conexao);
                    command2.Parameters.AddWithValue("@id", idLivro.Text);
                    conexao.Open();
                    MySqlDataReader reader = command2.ExecuteReader();

                    while (reader.Read())
                    {
                        edicaoQ = reader.GetInt16("edicao");
                    }
                    command.Parameters.AddWithValue("@edicao", edicaoQ);
                    DBConnection.Instance.FecharConexao();
                    conexao.Close();

                }
                else
                {
                    command.Parameters.AddWithValue("@edicao", edicao.Text);
                }
                if (paginas.Text == "")
                {
                    string query2 = "select paginas from livro where idLivro=@id;";
                    MySqlCommand command2 = new MySqlCommand(query2, conexao);
                    command2.Parameters.AddWithValue("@id", idLivro.Text);
                    conexao.Open();
                    MySqlDataReader reader = command2.ExecuteReader();

                    while (reader.Read())
                    {
                        paginasQ = reader.GetInt16("paginas");
                    }
                    command.Parameters.AddWithValue("@paginas", paginasQ);
                    DBConnection.Instance.FecharConexao();
                    conexao.Close();
                }
                else
                {
                    command.Parameters.AddWithValue("@paginas", paginas.Text);
                }
                
                
                
                
                
                
                
                command.Parameters.AddWithValue("@id", idLivro.Text);


                conexao.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Created Successfully!");
                DBConnection.Instance.FecharConexao();
            }
        }
    }
}
