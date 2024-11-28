namespace Trabalho2POO
{
    partial class FrmCadastrarFuncionario
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
            nomeF = new TextBox();
            sobrenomeF = new TextBox();
            cpfF = new TextBox();
            telefoneF = new TextBox();
            criarF = new Button();
            emailF = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            cpfFrm = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // nomeF
            // 
            nomeF.Location = new Point(84, 12);
            nomeF.Name = "nomeF";
            nomeF.Size = new Size(259, 23);
            nomeF.TabIndex = 0;
            // 
            // sobrenomeF
            // 
            sobrenomeF.Location = new Point(84, 41);
            sobrenomeF.Name = "sobrenomeF";
            sobrenomeF.Size = new Size(259, 23);
            sobrenomeF.TabIndex = 1;
            // 
            // cpfF
            // 
            cpfF.Location = new Point(84, 70);
            cpfF.Name = "cpfF";
            cpfF.Size = new Size(259, 23);
            cpfF.TabIndex = 2;
            // 
            // telefoneF
            // 
            telefoneF.Location = new Point(84, 128);
            telefoneF.Name = "telefoneF";
            telefoneF.Size = new Size(259, 23);
            telefoneF.TabIndex = 3;
            // 
            // criarF
            // 
            criarF.Location = new Point(116, 157);
            criarF.Name = "criarF";
            criarF.Size = new Size(156, 23);
            criarF.TabIndex = 4;
            criarF.Text = "Adicionar Funcionário";
            criarF.UseVisualStyleBackColor = true;
            criarF.Click += criarF_Click;
            // 
            // emailF
            // 
            emailF.Location = new Point(84, 99);
            emailF.Name = "emailF";
            emailF.Size = new Size(259, 23);
            emailF.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 131);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 19;
            label5.Text = "Telefone*:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 102);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 18;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 73);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 17;
            label3.Text = "Cpf*:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 44);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 16;
            label2.Text = "Sobrenome*:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 15;
            label1.Text = "Nome*:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 341);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 21;
            label6.Text = "Cpf:";
            // 
            // cpfFrm
            // 
            cpfFrm.Location = new Point(84, 338);
            cpfFrm.Name = "cpfFrm";
            cpfFrm.Size = new Size(225, 23);
            cpfFrm.TabIndex = 20;
            cpfFrm.TextChanged += cpfFrm_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(116, 367);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
            button1.TabIndex = 22;
            button1.Text = "Remover funcionario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmCadastrarFuncionario
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(768, 487);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(cpfFrm);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailF);
            Controls.Add(criarF);
            Controls.Add(telefoneF);
            Controls.Add(cpfF);
            Controls.Add(sobrenomeF);
            Controls.Add(nomeF);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadastrarFuncionario";
            Text = "FrmCadastrarFuncionario";
            Load += FrmCadastrarFuncionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nomeF;
        private TextBox sobrenomeF;
        private TextBox cpfF;
        private TextBox telefoneF;
        private Button criarF;
        private TextBox emailF;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox cpfFrm;
        private Button button1;
    }
}