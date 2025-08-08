namespace AutoShop
{
    partial class FrmClienteCad
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
            label1 = new Label();
            pesquisa = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            gbCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Fechar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1181, 112);
            panel1.TabIndex = 11;
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
            button1.Location = new Point(926, 641);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SpringGreen;
            btnSalvar.Location = new Point(1065, 641);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Save";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // gbCadastro
            // 
            gbCadastro.Controls.Add(label1);
            gbCadastro.Controls.Add(pesquisa);
            gbCadastro.Controls.Add(textBox2);
            gbCadastro.Controls.Add(textBox1);
            gbCadastro.Location = new Point(25, 145);
            gbCadastro.Name = "gbCadastro";
            gbCadastro.Size = new Size(1152, 490);
            gbCadastro.TabIndex = 8;
            gbCadastro.TabStop = false;
            gbCadastro.Text = "gbCadastro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(72, 300);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 4;
            label1.Text = "Phone:";
            // 
            // pesquisa
            // 
            pesquisa.AutoSize = true;
            pesquisa.Font = new Font("Segoe UI", 12F);
            pesquisa.Location = new Point(72, 147);
            pesquisa.Name = "pesquisa";
            pesquisa.Size = new Size(83, 32);
            pesquisa.TabIndex = 3;
            pesquisa.Text = "Name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 303);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(349, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 31);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(128, 27);
            label2.Name = "label2";
            label2.Size = new Size(292, 48);
            label2.TabIndex = 5;
            label2.Text = "User Registration";
            label2.Click += label2_Click;
            // 
            // FrmClienteCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 687);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(gbCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmClienteCad";
            Text = "FrmClienteCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label1;
        private Label pesquisa;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
    }
}