namespace AutoShop
{
    partial class FrmCliente
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
            panel1 = new Panel();
            Fechar = new Button();
            pesquisa = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            btnSalvar = new Button();
            gbCadastro = new GroupBox();
            btnAdicionar = new Button();
            listaPecas = new DataGridView();
            panel1.SuspendLayout();
            gbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listaPecas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(Fechar);
            panel1.Controls.Add(pesquisa);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(17, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 71);
            panel1.TabIndex = 7;
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
            // pesquisa
            // 
            pesquisa.AutoSize = true;
            pesquisa.Font = new Font("Segoe UI", 12F);
            pesquisa.Location = new Point(62, 18);
            pesquisa.Name = "pesquisa";
            pesquisa.Size = new Size(90, 32);
            pesquisa.TabIndex = 1;
            pesquisa.Text = "Search:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(722, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Location = new Point(795, 608);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SpringGreen;
            btnSalvar.Location = new Point(924, 608);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Edit";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // gbCadastro
            // 
            gbCadastro.Controls.Add(btnAdicionar);
            gbCadastro.Controls.Add(listaPecas);
            gbCadastro.Location = new Point(19, 85);
            gbCadastro.Name = "gbCadastro";
            gbCadastro.Size = new Size(1073, 517);
            gbCadastro.TabIndex = 4;
            gbCadastro.TabStop = false;
            gbCadastro.Text = "Cliente";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.SpringGreen;
            btnAdicionar.Location = new Point(165, 11);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "New User";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listaPecas
            // 
            listaPecas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaPecas.Location = new Point(27, 51);
            listaPecas.Name = "listaPecas";
            listaPecas.RowHeadersWidth = 62;
            listaPecas.Size = new Size(973, 439);
            listaPecas.TabIndex = 0;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 663);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(gbCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gbCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listaPecas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Fechar;
        private Label pesquisa;
        private TextBox textBox1;
        private Button button1;
        private Button btnSalvar;
        private GroupBox gbCadastro;
        private Button btnAdicionar;
        private DataGridView listaPecas;
    }
}