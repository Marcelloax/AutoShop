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
            Pecas = new GroupBox();
            btnAdicionar = new Button();
            listaPecas = new DataGridView();
            btnSalvar = new Button();
            button1 = new Button();
            panel1 = new Panel();
            Fechar = new Button();
            pesquisa = new Label();
            txtPesquisa = new TextBox();
            Pecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listaPecas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Pecas
            // 
            Pecas.Controls.Add(btnAdicionar);
            Pecas.Controls.Add(listaPecas);
            Pecas.Location = new Point(12, 89);
            Pecas.Name = "Pecas";
            Pecas.Size = new Size(1073, 517);
            Pecas.TabIndex = 0;
            Pecas.TabStop = false;
            Pecas.Text = "Pecas";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.SpringGreen;
            btnAdicionar.Location = new Point(165, 11);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Add Part";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listaPecas
            // 
            listaPecas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaPecas.Location = new Point(46, 51);
            listaPecas.Name = "listaPecas";
            listaPecas.RowHeadersWidth = 62;
            listaPecas.Size = new Size(973, 439);
            listaPecas.TabIndex = 0;
            listaPecas.CellContentClick += listaPecas_CellContentClick;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SpringGreen;
            btnSalvar.Location = new Point(919, 617);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Edit";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Location = new Point(790, 617);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(Fechar);
            panel1.Controls.Add(pesquisa);
            panel1.Controls.Add(txtPesquisa);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 71);
            panel1.TabIndex = 3;
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
            Fechar.Click += Fechar_Click;
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
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(206, 21);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(722, 31);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // FrmPeca
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 663);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(Pecas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPeca";
            Text = "FrmPeca";
            Activated += FrmPeca_Activated;
            Pecas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listaPecas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Pecas;
        private Button btnAdicionar;
        private DataGridView listaPecas;
        private Button btnSalvar;
        private Button button1;
        private Panel panel1;
        private TextBox txtPesquisa;
        private Button Fechar;
        private Label pesquisa;
    }
}
