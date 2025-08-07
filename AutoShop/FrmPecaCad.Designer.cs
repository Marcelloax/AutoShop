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
            label2 = new Label();
            label1 = new Label();
            pesquisa = new Label();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Location = new Point(838, 641);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SpringGreen;
            btnSalvar.Location = new Point(975, 641);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // gbCadastro
            // 
            gbCadastro.Controls.Add(label2);
            gbCadastro.Controls.Add(label1);
            gbCadastro.Controls.Add(pesquisa);
            gbCadastro.Controls.Add(richTextBox1);
            gbCadastro.Controls.Add(textBox2);
            gbCadastro.Controls.Add(textBox1);
            gbCadastro.Location = new Point(57, 118);
            gbCadastro.Name = "gbCadastro";
            gbCadastro.Size = new Size(1073, 517);
            gbCadastro.TabIndex = 4;
            gbCadastro.TabStop = false;
            gbCadastro.Text = "gbCadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(76, 382);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 5;
            label2.Text = "Pesquisar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(76, 212);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 4;
            label1.Text = "Pesquisar:";
            // 
            // pesquisa
            // 
            pesquisa.AutoSize = true;
            pesquisa.Font = new Font("Segoe UI", 12F);
            pesquisa.Location = new Point(76, 85);
            pesquisa.Name = "pesquisa";
            pesquisa.Size = new Size(118, 32);
            pesquisa.TabIndex = 3;
            pesquisa.Text = "Pesquisar:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(231, 171);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(349, 144);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(231, 385);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(349, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 31);
            textBox1.TabIndex = 0;
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
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label pesquisa;
    }
}