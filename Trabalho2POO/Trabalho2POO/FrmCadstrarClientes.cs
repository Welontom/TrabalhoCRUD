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
    public partial class FrmCadstrarClientes : Form
    {
        public FrmCadstrarClientes()
        {
            InitializeComponent();
        }

        private void FrmCadstrarClientes_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "INSERT INTO cliente(nome, sobrenome, cpf, email, telefone) VALUES" +
                    "(@nome, @sobrenome, @cpf, @email, @telefone)";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@nome", nome.Text);
                command.Parameters.AddWithValue("@sobrenome", sobrenome.Text);
                command.Parameters.AddWithValue("@cpf", cpf.Text);
                command.Parameters.AddWithValue("@email", email.Text);
                command.Parameters.AddWithValue("@telefone", telefone.Text);

                conexao.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Created Successfully!");
                DBConnection.Instance.FecharConexao();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var conexao = DBConnection.Instance.ObterConexao())
            {
                string query = "delete from cliente where cpf=@cpf;";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@cpf", cpfrm.Text);

                conexao.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Created Successfully!");
                DBConnection.Instance.FecharConexao();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
