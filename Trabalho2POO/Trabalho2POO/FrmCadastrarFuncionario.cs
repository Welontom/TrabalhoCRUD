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

namespace Trabalho2POO
{
    public partial class FrmCadastrarFuncionario : Form
    {
        public FrmCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void FrmCadastrarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void criarF_Click(object sender, EventArgs e)
        {
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "INSERT INTO funcionario(nome, sobrenome, cpf,email, telefone) VALUES" +
                    "(@nome,@sobrenome, @cpf,@email, @telefone)";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@nome", nomeF.Text);
                command.Parameters.AddWithValue("@sobrenome", sobrenomeF.Text);
                command.Parameters.AddWithValue("@cpf", cpfF.Text);
                command.Parameters.AddWithValue("@email", emailF.Text);
                command.Parameters.AddWithValue("@telefone", telefoneF.Text);

                conexao.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Created Successfully!");
                DBConnection.Instance.FecharConexao();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cpfFrm_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "delete from funcionario where cpf=@cpf;";
                MySqlCommand command = new MySqlCommand(query, conexao);

                command.Parameters.AddWithValue("@cpf", cpfFrm.Text);


                conexao.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Created Successfully!");
                DBConnection.Instance.FecharConexao();
            }

        }
    }
}
