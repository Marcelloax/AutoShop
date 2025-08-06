namespace AutoShop
{
    partial class FrmPeca
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
            gbCadastro = new GroupBox();
            listaPecas = new DataGridView();
            btnSalvar = new Button();
            button1 = new Button();
            btnAdicionar = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            pesquisa = new Label();
            Fechar = new Button();
            gbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listaPecas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gbCadastro
            // 
            gbCadastro.Controls.Add(btnAdicionar);
            gbCadastro.Controls.Add(listaPecas);
            gbCadastro.Location = new Point(12, 89);
            gbCadastro.Name = "gbCadastro";
            gbCadastro.Size = new Size(1073, 517);
            gbCadastro.TabIndex = 0;
            gbCadastro.TabStop = false;
            gbCadastro.Text = "gbCadastro";
            // 
            // listaPecas
            // 
            listaPecas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaPecas.Location = new Point(46, 51);
            listaPecas.Name = "listaPecas";
            listaPecas.RowHeadersWidth = 62;
            listaPecas.Size = new Size(973, 439);
            listaPecas.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SpringGreen;
            btnSalvar.Location = new Point(919, 617);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Location = new Point(790, 617);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.SpringGreen;
            btnAdicionar.Location = new Point(165, 11);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(Fechar);
            panel1.Controls.Add(pesquisa);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 71);
            panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(722, 31);
            textBox1.TabIndex = 0;
            // 
            // pesquisa
            // 
            pesquisa.AutoSize = true;
            pesquisa.Font = new Font("Segoe UI", 12F);
            pesquisa.Location = new Point(62, 18);
            pesquisa.Name = "pesquisa";
            pesquisa.Size = new Size(118, 32);
            pesquisa.TabIndex = 1;
            pesquisa.Text = "Pesquisar:";
            // 
            // Fechar
            // 
            Fechar.BackColor = Color.Red;
            Fechar.Location = new Point(1022, 16);
            Fechar.Name = "Fechar";
            Fechar.Size = new Size(38, 34);
            Fechar.TabIndex = 4;
            Fechar.Text = "X";
            Fechar.UseVisualStyleBackColor = false;
            // 
            // FrmPeca
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 663);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(gbCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPeca";
            Text = "FrmPeca";
            gbCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listaPecas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCadastro;
        private Button btnAdicionar;
        private DataGridView listaPecas;
        private Button btnSalvar;
        private Button button1;
        private Panel panel1;
        private TextBox textBox1;
        private Button Fechar;
        private Label pesquisa;
    }
}
