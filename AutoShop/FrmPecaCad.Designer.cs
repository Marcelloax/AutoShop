namespace AutoShop
{
    partial class FrmPecaCad
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
            button1 = new Button();
            btnSalvar = new Button();
            gbCadastro = new GroupBox();
            txtStock = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pesquisa = new Label();
            txtPrice = new TextBox();
            txtNome = new TextBox();
            panel1.SuspendLayout();
            gbCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(Fechar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1181, 83);
            panel1.TabIndex = 7;
            // 
            // Fechar
            // 
            Fechar.BackColor = Color.Red;
            Fechar.Location = new Point(1111, 27);
            Fechar.Name = "Fechar";
            Fechar.Size = new Size(38, 34);
            Fechar.TabIndex = 4;
            Fechar.Text = "X";
            Fechar.UseVisualStyleBackColor = false;
            Fechar.Click += Fechar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Location = new Point(824, 629);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SpringGreen;
            btnSalvar.Location = new Point(968, 629);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Save";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // gbCadastro
            // 
            gbCadastro.Controls.Add(txtStock);
            gbCadastro.Controls.Add(label2);
            gbCadastro.Controls.Add(label1);
            gbCadastro.Controls.Add(pesquisa);
            gbCadastro.Controls.Add(txtPrice);
            gbCadastro.Controls.Add(txtNome);
            gbCadastro.Location = new Point(57, 118);
            gbCadastro.Name = "gbCadastro";
            gbCadastro.Size = new Size(1073, 495);
            gbCadastro.TabIndex = 4;
            gbCadastro.TabStop = false;
            gbCadastro.Text = "gbCadastro";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(231, 326);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(349, 31);
            txtStock.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(76, 323);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 5;
            label2.Text = "In Stock:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(76, 212);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 4;
            label1.Text = "Price:";
            // 
            // pesquisa
            // 
            pesquisa.AutoSize = true;
            pesquisa.Font = new Font("Segoe UI", 12F);
            pesquisa.Location = new Point(76, 85);
            pesquisa.Name = "pesquisa";
            pesquisa.Size = new Size(83, 32);
            pesquisa.TabIndex = 3;
            pesquisa.Text = "Name:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(231, 215);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(349, 31);
            txtPrice.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(231, 88);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(349, 31);
            txtNome.TabIndex = 0;
            // 
            // FrmPecaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 687);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(gbCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPecaCad";
            Text = "FrmPecaCad";
            panel1.ResumeLayout(false);
            gbCadastro.ResumeLayout(false);
            gbCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Fechar;
        private Button button1;
        private Button btnSalvar;
        private GroupBox gbCadastro;
        private TextBox txtPrice;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private Label pesquisa;
        private TextBox txtStock;
    }
}