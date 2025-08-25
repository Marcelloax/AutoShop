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
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(Fechar);
            panel1.Controls.Add(pesquisa);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 44);
            panel1.TabIndex = 7;
            // 
            // Fechar
            // 
            Fechar.BackColor = Color.DarkRed;
            Fechar.FlatAppearance.MouseOverBackColor = Color.Silver;
            Fechar.FlatStyle = FlatStyle.Flat;
            Fechar.Location = new Point(715, 10);
            Fechar.Margin = new Padding(2, 2, 2, 2);
            Fechar.Name = "Fechar";
            Fechar.Size = new Size(50, 26);
            Fechar.TabIndex = 4;
            Fechar.Text = "X";
            Fechar.UseVisualStyleBackColor = false;
            Fechar.Click += Fechar_Click;
            // 
            // pesquisa
            // 
            pesquisa.AutoSize = true;
            pesquisa.Font = new Font("Vladimir Script", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pesquisa.Location = new Point(39, 5);
            pesquisa.Margin = new Padding(2, 0, 2, 0);
            pesquisa.Name = "pesquisa";
            pesquisa.Size = new Size(81, 32);
            pesquisa.TabIndex = 1;
            pesquisa.Text = "Search:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 13);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(507, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(556, 374);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 22);
            button1.TabIndex = 6;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SpringGreen;
            btnSalvar.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(641, 374);
            btnSalvar.Margin = new Padding(2, 2, 2, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(78, 22);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Edit";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // gbCadastro
            // 
            gbCadastro.BackColor = SystemColors.ActiveCaption;
            gbCadastro.Controls.Add(btnAdicionar);
            gbCadastro.Controls.Add(listaPecas);
            gbCadastro.Location = new Point(13, 51);
            gbCadastro.Margin = new Padding(2, 2, 2, 2);
            gbCadastro.Name = "gbCadastro";
            gbCadastro.Padding = new Padding(2, 2, 2, 2);
            gbCadastro.Size = new Size(751, 319);
            gbCadastro.TabIndex = 4;
            gbCadastro.TabStop = false;
            gbCadastro.Text = "Customer";
            gbCadastro.Enter += gbCadastro_Enter;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.SpringGreen;
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Location = new Point(60, 13);
            btnAdicionar.Margin = new Padding(2, 2, 2, 2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(134, 32);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Add New Customer";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listaPecas
            // 
            listaPecas.BackgroundColor = SystemColors.GradientInactiveCaption;
            listaPecas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaPecas.Location = new Point(25, 49);
            listaPecas.Margin = new Padding(2, 2, 2, 2);
            listaPecas.Name = "listaPecas";
            listaPecas.RowHeadersWidth = 62;
            listaPecas.Size = new Size(681, 257);
            listaPecas.TabIndex = 0;
            listaPecas.CellClick += listaPecas_CellClick;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(773, 407);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(gbCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
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