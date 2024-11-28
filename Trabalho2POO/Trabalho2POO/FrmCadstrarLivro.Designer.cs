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
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Location = new Point(150, 27);
            titulo.Margin = new Padding(3, 4, 3, 4);
            titulo.Name = "titulo";
            titulo.Size = new Size(285, 27);
            titulo.TabIndex = 0;
            // 
            // exemplar
            // 
            exemplar.Location = new Point(150, 65);
            exemplar.Margin = new Padding(3, 4, 3, 4);
            exemplar.Name = "exemplar";
            exemplar.Size = new Size(285, 27);
            exemplar.TabIndex = 1;
            // 
            // isbn
            // 
            isbn.Location = new Point(150, 104);
            isbn.Margin = new Padding(3, 4, 3, 4);
            isbn.Name = "isbn";
            isbn.Size = new Size(285, 27);
            isbn.TabIndex = 2;
            // 
            // autor
            // 
            autor.Location = new Point(150, 143);
            autor.Margin = new Padding(3, 4, 3, 4);
            autor.Name = "autor";
            autor.Size = new Size(285, 27);
            autor.TabIndex = 3;
            // 
            // ano
            // 
            ano.Location = new Point(150, 181);
            ano.Margin = new Padding(3, 4, 3, 4);
            ano.Name = "ano";
            ano.Size = new Size(285, 27);
            ano.TabIndex = 4;
            // 
            // edicao
            // 
            edicao.Location = new Point(150, 220);
            edicao.Margin = new Padding(3, 4, 3, 4);
            edicao.Name = "edicao";
            edicao.Size = new Size(285, 27);
            edicao.TabIndex = 5;
            // 
            // paginas
            // 
            paginas.Location = new Point(150, 259);
            paginas.Margin = new Padding(3, 4, 3, 4);
            paginas.Name = "paginas";
            paginas.Size = new Size(285, 27);
            paginas.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(202, 297);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(157, 31);
            button1.TabIndex = 7;
            button1.Text = "Cadastrar livro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 185);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 24;
            label5.Text = "Ano de publicação:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 147);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 23;
            label4.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 108);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 22;
            label3.Text = "ISBN*:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 69);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 21;
            label2.Text = "Exemplar*:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 31);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 20;
            label1.Text = "Titulo*:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 224);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 25;
            label6.Text = "Número da edição:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 263);
            label7.Name = "label7";
            label7.Size = new Size(143, 20);
            label7.TabIndex = 26;
            label7.Text = "Número de páginas:";
            // 
            // button2
            // 
            button2.Location = new Point(223, 545);
            button2.Name = "button2";
            button2.Size = new Size(136, 29);
            button2.TabIndex = 27;
            button2.Text = "Remover livro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(91, 480);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 31;
            label8.Text = "ISBN*:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 507);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 30;
            label9.Text = "Exemplar*:";
            // 
            // isbnrm
            // 
            isbnrm.Location = new Point(150, 476);
            isbnrm.Margin = new Padding(3, 4, 3, 4);
            isbnrm.Name = "isbnrm";
            isbnrm.Size = new Size(285, 27);
            isbnrm.TabIndex = 29;
            // 
            // exemplarrm
            // 
            exemplarrm.Location = new Point(150, 511);
            exemplarrm.Margin = new Padding(3, 4, 3, 4);
            exemplarrm.Name = "exemplarrm";
            exemplarrm.Size = new Size(285, 27);
            exemplarrm.TabIndex = 28;
            // 
            // FrmCadstrarLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 649);
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
            Margin = new Padding(3, 4, 3, 4);
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
    }
}