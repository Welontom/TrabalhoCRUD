namespace Trabalho2POO
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEmprestimo = new Button();
            btnCadastrarLivro = new Button();
            btnCadastrarFuncionario = new Button();
            btnVisualizar = new Button();
            btnCadastrarCliente = new Button();
            panelPrincipal = new Panel();
            panel2 = new Panel();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // btnEmprestimo
            // 
            btnEmprestimo.Dock = DockStyle.Top;
            btnEmprestimo.FlatAppearance.BorderColor = Color.Indigo;
            btnEmprestimo.FlatAppearance.BorderSize = 0;
            btnEmprestimo.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnEmprestimo.FlatAppearance.MouseOverBackColor = Color.BlueViolet;
            btnEmprestimo.FlatStyle = FlatStyle.Flat;
            btnEmprestimo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEmprestimo.ForeColor = Color.White;
            btnEmprestimo.Location = new Point(0, 171);
            btnEmprestimo.Name = "btnEmprestimo";
            btnEmprestimo.Size = new Size(200, 57);
            btnEmprestimo.TabIndex = 3;
            btnEmprestimo.Text = "Emprestimo";
            btnEmprestimo.TextAlign = ContentAlignment.MiddleLeft;
            btnEmprestimo.UseVisualStyleBackColor = true;
            btnEmprestimo.Click += button1_Click;
            // 
            // btnCadastrarLivro
            // 
            btnCadastrarLivro.Dock = DockStyle.Top;
            btnCadastrarLivro.FlatAppearance.BorderColor = Color.Indigo;
            btnCadastrarLivro.FlatAppearance.BorderSize = 0;
            btnCadastrarLivro.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnCadastrarLivro.FlatAppearance.MouseOverBackColor = Color.BlueViolet;
            btnCadastrarLivro.FlatStyle = FlatStyle.Flat;
            btnCadastrarLivro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCadastrarLivro.ForeColor = Color.White;
            btnCadastrarLivro.Location = new Point(0, 114);
            btnCadastrarLivro.Name = "btnCadastrarLivro";
            btnCadastrarLivro.Size = new Size(200, 57);
            btnCadastrarLivro.TabIndex = 2;
            btnCadastrarLivro.Text = "Cadastrar livro";
            btnCadastrarLivro.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastrarLivro.UseVisualStyleBackColor = true;
            btnCadastrarLivro.Click += btnCadastrarLivro_Click;
            // 
            // btnCadastrarFuncionario
            // 
            btnCadastrarFuncionario.Dock = DockStyle.Top;
            btnCadastrarFuncionario.FlatAppearance.BorderColor = Color.Indigo;
            btnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            btnCadastrarFuncionario.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnCadastrarFuncionario.FlatAppearance.MouseOverBackColor = Color.BlueViolet;
            btnCadastrarFuncionario.FlatStyle = FlatStyle.Flat;
            btnCadastrarFuncionario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCadastrarFuncionario.ForeColor = Color.White;
            btnCadastrarFuncionario.Location = new Point(0, 57);
            btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            btnCadastrarFuncionario.Size = new Size(200, 57);
            btnCadastrarFuncionario.TabIndex = 1;
            btnCadastrarFuncionario.Text = "Cadastrar funcionário";
            btnCadastrarFuncionario.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            btnCadastrarFuncionario.Click += btnCadastrarFuncionario_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Dock = DockStyle.Top;
            btnVisualizar.FlatAppearance.BorderColor = Color.Indigo;
            btnVisualizar.FlatAppearance.BorderSize = 0;
            btnVisualizar.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnVisualizar.FlatAppearance.MouseOverBackColor = Color.BlueViolet;
            btnVisualizar.FlatStyle = FlatStyle.Flat;
            btnVisualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVisualizar.ForeColor = Color.White;
            btnVisualizar.Location = new Point(0, 228);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(200, 57);
            btnVisualizar.TabIndex = 4;
            btnVisualizar.Text = "Visualizar tabelas";
            btnVisualizar.TextAlign = ContentAlignment.MiddleLeft;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += button1_Click_1;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Dock = DockStyle.Top;
            btnCadastrarCliente.FlatAppearance.BorderColor = Color.Indigo;
            btnCadastrarCliente.FlatAppearance.BorderSize = 0;
            btnCadastrarCliente.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnCadastrarCliente.FlatAppearance.MouseOverBackColor = Color.BlueViolet;
            btnCadastrarCliente.FlatStyle = FlatStyle.Flat;
            btnCadastrarCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCadastrarCliente.ForeColor = Color.White;
            btnCadastrarCliente.Location = new Point(0, 0);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(200, 57);
            btnCadastrarCliente.TabIndex = 0;
            btnCadastrarCliente.Text = "Cadastrar cliente";
            btnCadastrarCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += button2_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(0, 0, 100);
            panelPrincipal.Controls.Add(btnVisualizar);
            panelPrincipal.Controls.Add(btnEmprestimo);
            panelPrincipal.Controls.Add(btnCadastrarLivro);
            panelPrincipal.Controls.Add(btnCadastrarFuncionario);
            panelPrincipal.Controls.Add(btnCadastrarCliente);
            panelPrincipal.Dock = DockStyle.Left;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(200, 526);
            panelPrincipal.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 526);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 526);
            Controls.Add(panel2);
            Controls.Add(panelPrincipal);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formPrincipal";
            Load += Form1_Load;
            panelPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPrincipal;
        private Button btnCadastrarCliente;
        private Button btnCadastrarFuncionario;
        private Button btnCadastrarLivro;
        private Button btnEmprestimo;
        private Panel panel2;
        private Button btnVisualizar;
    }
}
