namespace Trabalho2POO
{
    partial class FrmCadstrarLivro
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
            titulo = new TextBox();
            exemplar = new TextBox();
            isbn = new TextBox();
            autor = new TextBox();
            ano = new TextBox();
            edicao = new TextBox();
            paginas = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            isbnrm = new TextBox();
            exemplarrm = new TextBox();
            button3 = new Button();
            idLivro = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Location = new Point(131, 20);
            titulo.Name = "titulo";
            titulo.Size = new Size(250, 23);
            titulo.TabIndex = 0;
            // 
            // exemplar
            // 
            exemplar.Location = new Point(131, 49);
            exemplar.Name = "exemplar";
            exemplar.Size = new Size(250, 23);
            exemplar.TabIndex = 1;
            // 
            // isbn
            // 
            isbn.Location = new Point(131, 78);
            isbn.Name = "isbn";
            isbn.Size = new Size(250, 23);
            isbn.TabIndex = 2;
            // 
            // autor
            // 
            autor.Location = new Point(131, 107);
            autor.Name = "autor";
            autor.Size = new Size(250, 23);
            autor.TabIndex = 3;
            // 
            // ano
            // 
            ano.Location = new Point(131, 136);
            ano.Name = "ano";
            ano.Size = new Size(250, 23);
            ano.TabIndex = 4;
            // 
            // edicao
            // 
            edicao.Location = new Point(131, 165);
            edicao.Name = "edicao";
            edicao.Size = new Size(250, 23);
            edicao.TabIndex = 5;
            // 
            // paginas
            // 
            paginas.Location = new Point(131, 194);
            paginas.Name = "paginas";
            paginas.Size = new Size(250, 23);
            paginas.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(131, 223);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 7;
            button1.Text = "Cadastrar livro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 139);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 24;
            label5.Text = "Ano de publicação:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 110);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 23;
            label4.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 81);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 22;
            label3.Text = "ISBN*:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 52);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 21;
            label2.Text = "Exemplar*:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 23);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 20;
            label1.Text = "Titulo*:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 168);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 25;
            label6.Text = "Número da edição:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 197);
            label7.Name = "label7";
            label7.Size = new Size(114, 15);
            label7.TabIndex = 26;
            label7.Text = "Número de páginas:";
            // 
            // button2
            // 
            button2.Location = new Point(195, 409);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(119, 22);
            button2.TabIndex = 27;
            button2.Text = "Remover livro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(85, 360);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 31;
            label8.Text = "ISBN*:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(61, 380);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 30;
            label9.Text = "Exemplar*:";
            // 
            // isbnrm
            // 
            isbnrm.Location = new Point(131, 357);
            isbnrm.Name = "isbnrm";
            isbnrm.Size = new Size(250, 23);
            isbnrm.TabIndex = 29;
            // 
            // exemplarrm
            // 
            exemplarrm.Location = new Point(131, 383);
            exemplarrm.Name = "exemplarrm";
            exemplarrm.Size = new Size(250, 23);
            exemplarrm.TabIndex = 28;
            // 
            // button3
            // 
            button3.Location = new Point(275, 223);
            button3.Name = "button3";
            button3.Size = new Size(106, 23);
            button3.TabIndex = 32;
            button3.Text = "Atualizar livro";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // idLivro
            // 
            idLivro.Location = new Point(275, 252);
            idLivro.Name = "idLivro";
            idLivro.Size = new Size(106, 23);
            idLivro.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(222, 255);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 34;
            label10.Text = "ID livro:";
            // 
            // FrmCadstrarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 487);
            Controls.Add(label10);
            Controls.Add(idLivro);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(isbnrm);
            Controls.Add(exemplarrm);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(paginas);
            Controls.Add(edicao);
            Controls.Add(ano);
            Controls.Add(autor);
            Controls.Add(isbn);
            Controls.Add(exemplar);
            Controls.Add(titulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadstrarLivro";
            Text = "FrmCadstrarLivro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titulo;
        private TextBox exemplar;
        private TextBox isbn;
        private TextBox autor;
        private TextBox ano;
        private TextBox edicao;
        private TextBox paginas;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Button button2;
        private Label label8;
        private Label label9;
        private TextBox isbnrm;
        private TextBox exemplarrm;
        private Button button3;
        private TextBox idLivro;
        private Label label10;
    }
}