using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Data;
using System.Data.Common;
using System.Xml.Linq;
using System.Drawing;

namespace Trabalho2POO
{
    public partial class FormPrincipal : Form
    {
        private Form frmAtivo;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }
        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelPrincipal.Controls)
                ctrl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Red;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(btnCadastrarCliente);
            FormShow(new FrmCadstrarClientes());

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            ActiveButton(btnCadastrarFuncionario);
            FormShow(new FrmCadastrarFuncionario());
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            ActiveButton(btnCadastrarLivro);
            FormShow(new FrmCadstrarLivro());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(btnEmprestimo);
            FormShow(new FrmEmprestimo());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActiveButton(btnVisualizar);
            FormShow(new FrmVisualizar());
        }
    }
    public class DBConnection 
    {
        private static DBConnection _instance;
        private MySqlConnection _conexao;
        private static readonly object _lock = new object();
        private string _connectionString = "server=localhost;user=root;password='123456';database=projeto;" +
            "sslmode=none;port='3307';";
        private DBConnection()
        {
            _conexao = new MySqlConnection(_connectionString);
        }
        public static DBConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DBConnection();
                        }
                    }
                }
                return _instance;
            }
        }
        public MySqlConnection ObterConexao()
        {
            return _conexao;
        }
        public void FecharConexao()
        {
            if (_conexao.State == System.Data.ConnectionState.Open)
            {
                _conexao.Close();
                _instance = null;
            }
        }

    }
}
