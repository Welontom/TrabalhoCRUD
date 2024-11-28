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
    }
}
