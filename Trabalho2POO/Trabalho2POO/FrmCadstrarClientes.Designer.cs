namespace Trabalho2POO
{
    partial class FrmCadstrarClientes
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
            button1 = new Button();
            telefone = new TextBox();
            cpf = new TextBox();
            nome = new TextBox();
            sobrenome = new TextBox();
            email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            label6 = new Label();
            cpfrm = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(165, 196);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(200, 29);
            button1.TabIndex = 7;
            button1.Text = "Adicionar cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // telefone
            // 
            telefone.Location = new Point(108, 160);
            telefone.Margin = new Padding(4);
            telefone.Name = "telefone";
            telefone.Size = new Size(346, 27);
            telefone.TabIndex = 6;
            // 
            // cpf
            // 
            cpf.Location = new Point(108, 88);
            cpf.Margin = new Padding(4);
            cpf.Name = "cpf";
            cpf.Size = new Size(346, 27);
            cpf.TabIndex = 5;
            // 
            // nome
            // 
            nome.Location = new Point(108, 15);
            nome.Margin = new Padding(4);
            nome.Name = "nome";
            nome.Size = new Size(346, 27);
            nome.TabIndex = 4;
            // 
            // sobrenome
            // 
            sobrenome.Location = new Point(108, 51);
            sobrenome.Margin = new Padding(4);
            sobrenome.Name = "sobrenome";
            sobrenome.Size = new Size(346, 27);
            sobrenome.TabIndex = 8;
            // 
            // email
            // 
            email.Location = new Point(108, 124);
            email.Margin = new Padding(4);
            email.Name = "email";
            email.Size = new Size(346, 27);
            email.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 10;
            label1.Text = "Nome*:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 55);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 11;
            label2.Text = "Sobrenome:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 91);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 12;
            label3.Text = "Cpf*:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 128);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 13;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 164);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 14;
            label5.Text = "Telefone*:";
            // 
            // button2
            // 
            button2.Location = new Point(193, 455);
            button2.Name = "button2";
            button2.Size = new Size(135, 29);
            button2.TabIndex = 15;
            button2.Text = "Remover cliente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 424);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 17;
            label6.Text = "Cpf:";
            label6.Click += label6_Click;
            // 
            // cpfrm
            // 
            cpfrm.Location = new Point(108, 421);
            cpfrm.Margin = new Padding(4);
            cpfrm.Name = "cpfrm";
            cpfrm.Size = new Size(346, 27);
            cpfrm.TabIndex = 16;
            // 
            // FrmCadstrarClientes
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(980, 658);
            Controls.Add(label6);
            Controls.Add(cpfrm);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(email);
            Controls.Add(sobrenome);
            Controls.Add(button1);
            Controls.Add(telefone);
            Controls.Add(cpf);
            Controls.Add(nome);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmCadstrarClientes";
            Text = "FrmCadstrarClientes";
            Load += FrmCadstrarClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox telefone;
        private TextBox cpf;
        private TextBox nome;
        private TextBox sobrenome;
        private TextBox email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Label label6;
        private TextBox cpfrm;
    }
}