namespace Trabalho2POO
{
    partial class FrmEmprestimo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cb_cliente = new ComboBox();
            cb_livro = new ComboBox();
            cb_funcionario = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            cb_devolucao = new ComboBox();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // cb_cliente
            // 
            cb_cliente.FormattingEnabled = true;
            cb_cliente.Location = new Point(517, 46);
            cb_cliente.Name = "cb_cliente";
            cb_cliente.Size = new Size(177, 23);
            cb_cliente.TabIndex = 0;
            // 
            // cb_livro
            // 
            cb_livro.FormattingEnabled = true;
            cb_livro.Location = new Point(517, 75);
            cb_livro.Name = "cb_livro";
            cb_livro.Size = new Size(177, 23);
            cb_livro.TabIndex = 1;
            // 
            // cb_funcionario
            // 
            cb_funcionario.FormattingEnabled = true;
            cb_funcionario.Location = new Point(517, 104);
            cb_funcionario.Name = "cb_funcionario";
            cb_funcionario.Size = new Size(177, 23);
            cb_funcionario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(464, 49);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Cliente:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 78);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Livro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 107);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 5;
            label3.Text = "Funcionario:";
            // 
            // button1
            // 
            button1.Location = new Point(537, 133);
            button1.Name = "button1";
            button1.Size = new Size(143, 23);
            button1.TabIndex = 6;
            button1.Text = "Registrar empréstimo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cb_devolucao
            // 
            cb_devolucao.FormattingEnabled = true;
            cb_devolucao.Location = new Point(76, 78);
            cb_devolucao.Name = "cb_devolucao";
            cb_devolucao.Size = new Size(177, 23);
            cb_devolucao.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 81);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Livro:";
            // 
            // button2
            // 
            button2.Location = new Point(99, 107);
            button2.Name = "button2";
            button2.Size = new Size(130, 23);
            button2.TabIndex = 9;
            button2.Text = "Devolver livro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 487);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(cb_devolucao);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_funcionario);
            Controls.Add(cb_livro);
            Controls.Add(cb_cliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmprestimo";
            Text = "FrmEmprestimo";
            Load += FrmEmprestimo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_cliente;
        private ComboBox cb_livro;
        private ComboBox cb_funcionario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ComboBox cb_devolucao;
        private Label label4;
        private Button button2;
    }
}