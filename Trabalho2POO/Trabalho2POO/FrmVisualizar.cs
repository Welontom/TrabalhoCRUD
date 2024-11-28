using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho2POO
{
    public partial class FrmVisualizar : Form
    {
        public FrmVisualizar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "SELECT * FROM cliente;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexao);
                DataTable dt = new DataTable();

                conexao.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                DBConnection.Instance.FecharConexao();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "SELECT * FROM funcionario;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexao);
                DataTable dt = new DataTable();

                conexao.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                DBConnection.Instance.FecharConexao();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "SELECT * FROM livro;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexao);
                DataTable dt = new DataTable();

                conexao.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                DBConnection.Instance.FecharConexao();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "select titulo,exemplar,concat(f.nome, ' ', f.sobrenome) " +
                    "as funcionário,c.nome as cliente,dataEmprestimo as 'data empréstimo'," +
                    "dataDevolucao 'data da devolução' from emprestimo inner join livro on Livro_idLivro = idLivro inner join funcionario " +
                    "f on Funcionario_idFuncionario = f.idFuncionario inner join cliente c on Cliente_idCliente = idCliente;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexao);
                DataTable dt = new DataTable();

                conexao.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                DBConnection.Instance.FecharConexao();
            }
        }
    }
}
