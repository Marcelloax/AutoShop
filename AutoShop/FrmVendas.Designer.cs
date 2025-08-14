namespace AutoShop
{
    partial class FrmVendas
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
            btnSalvar = new Button();
            gbCadastro = new GroupBox();
            btnAdicionar = new Button();
            listaPecas = new DataGridView();
            textBox1 = new TextBox();
            pesquisa = new Label();
            Fechar = new Button();
            gbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listaPecas).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Location = new Point(791, 617);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SpringGreen;
            btnSalvar.Location = new Point(922, 617);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Edite";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // gbCadastro
            // 
            gbCadastro.Controls.Add(btnAdicionar);
            gbCadastro.Controls.Add(listaPecas);
            gbCadastro.Location = new Point(36, 94);
            gbCadastro.Name = "gbCadastro";
            gbCadastro.Size = new Size(1038, 517);
            gbCadastro.TabIndex = 8;
            gbCadastro.TabStop = false;
            gbCadastro.Text = "Sells";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.MediumTurquoise;
            btnAdicionar.Location = new Point(126, 11);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(193, 34);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "New work Orde";
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
            listaPecas.CellClick += listaPecas_CellContentClick;
            
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(699, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pesquisa
            // 
            pesquisa.AutoSize = true;
            pesquisa.Font = new Font("Segoe UI", 12F);
            pesquisa.Location = new Point(155, 35);
            pesquisa.Name = "pesquisa";
            pesquisa.Size = new Size(90, 32);
            pesquisa.TabIndex = 1;
            pesquisa.Text = "Search:";
            // 
            // Fechar
            // 
            Fechar.BackColor = Color.Red;
            Fechar.Location = new Point(1036, 20);
            Fechar.Name = "Fechar";
            Fechar.Size = new Size(38, 34);
            Fechar.TabIndex = 4;
            Fechar.Text = "X";
            Fechar.UseVisualStyleBackColor = false;
            Fechar.Click += Fechar_Click;
            // 
            // FrmVendas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 663);
            Controls.Add(Fechar);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(btnSalvar);
            Controls.Add(pesquisa);
            Controls.Add(gbCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVendas";
            Text = "FrmVendas";
            Load += FrmVendas_Load;
            gbCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listaPecas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btnSalvar;
        private GroupBox gbCadastro;
        private Button btnAdicionar;
        private DataGridView listaPecas;
        private Label pesquisa;
        private TextBox textBox1;
        private Button Fechar;
    }
}