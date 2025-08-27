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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeca));
            btnSalvar = new Button();
            button1 = new Button();
            panel1 = new Panel();
            Fechar = new Button();
            pesquisa = new Label();
            txtPesquisa = new TextBox();
            listaPecas = new DataGridView();
            btnAdicionar = new Button();
            Pecas = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listaPecas).BeginInit();
            Pecas.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SpringGreen;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSalvar.FlatStyle = FlatStyle.Flat;
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
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
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
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(Fechar);
            panel1.Controls.Add(pesquisa);
            panel1.Controls.Add(txtPesquisa);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 71);
            panel1.TabIndex = 3;
            // 
            // Fechar
            // 
            Fechar.BackColor = Color.Red;
            Fechar.FlatAppearance.MouseOverBackColor = Color.Silver;
            Fechar.FlatStyle = FlatStyle.Flat;
            Fechar.Location = new Point(1045, 0);
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
            pesquisa.BackColor = Color.Transparent;
            pesquisa.Font = new Font("Vladimir Script", 20F);
            pesquisa.Location = new Point(46, 9);
            pesquisa.Name = "pesquisa";
            pesquisa.Size = new Size(118, 48);
            pesquisa.TabIndex = 1;
            pesquisa.Text = "Search:";
            // 
            // txtPesquisa
            // 
            txtPesquisa.BackColor = SystemColors.InactiveCaption;
            txtPesquisa.BorderStyle = BorderStyle.None;
            txtPesquisa.Location = new Point(191, 25);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(722, 24);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // listaPecas
            // 
            listaPecas.BackgroundColor = SystemColors.GradientInactiveCaption;
            listaPecas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaPecas.Location = new Point(46, 51);
            listaPecas.Name = "listaPecas";
            listaPecas.RowHeadersWidth = 62;
            listaPecas.Size = new Size(973, 439);
            listaPecas.TabIndex = 0;
            listaPecas.CellContentClick += listaPecas_CellContentClick;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.SpringGreen;
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Location = new Point(165, 11);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Add Part";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // Pecas
            // 
            Pecas.BackgroundImage = (Image)resources.GetObject("Pecas.BackgroundImage");
            Pecas.Controls.Add(btnAdicionar);
            Pecas.Controls.Add(listaPecas);
            Pecas.Location = new Point(-1, 60);
            Pecas.Name = "Pecas";
            Pecas.Size = new Size(1086, 605);
            Pecas.TabIndex = 0;
            Pecas.TabStop = false;
            Pecas.Text = "Pecas";
            Pecas.Enter += Pecas_Enter;
            // 
            // FrmPeca
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 663);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(Pecas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPeca";
            Text = "FrmPeca";
            Activated += FrmPeca_Activated;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listaPecas).EndInit();
            Pecas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnSalvar;
        private Button button1;
        private Panel panel1;
        private TextBox txtPesquisa;
        private Button Fechar;
        private Label pesquisa;
        private DataGridView listaPecas;
        private Button btnAdicionar;
        private GroupBox Pecas;
    }
}
