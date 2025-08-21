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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteCad));
            panel1 = new Panel();
            label2 = new Label();
            Fechar = new Button();
            button1 = new Button();
            btnSalvar = new Button();
            gbCadastro = new GroupBox();
            label1 = new Label();
            pesquisa = new Label();
            txtPhone = new TextBox();
            txtNome = new TextBox();
            button5 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            gbCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Fechar);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1193, 136);
            panel1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(28, 27);
            label2.Name = "label2";
            label2.Size = new Size(292, 48);
            label2.TabIndex = 5;
            label2.Text = "User Registration";
            label2.Click += label2_Click;
            // 
            // Fechar
            // 
            Fechar.BackColor = SystemColors.GradientActiveCaption;
            Fechar.BackgroundImage = (Image)resources.GetObject("Fechar.BackgroundImage");
            Fechar.BackgroundImageLayout = ImageLayout.Zoom;
            Fechar.Location = new Point(1132, 3);
            Fechar.Name = "Fechar";
            Fechar.Size = new Size(62, 51);
            Fechar.TabIndex = 4;
            Fechar.UseVisualStyleBackColor = false;
            Fechar.Click += Fechar_Click;
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
            button1.Click += button1_Click;
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
            btnSalvar.Click += btnSalvar_Click;
            // 
            // gbCadastro
            // 
            gbCadastro.BackgroundImage = (Image)resources.GetObject("gbCadastro.BackgroundImage");
            gbCadastro.BackgroundImageLayout = ImageLayout.Stretch;
            gbCadastro.Controls.Add(label1);
            gbCadastro.Controls.Add(pesquisa);
            gbCadastro.Controls.Add(txtPhone);
            gbCadastro.Controls.Add(txtNome);
            gbCadastro.Location = new Point(0, 130);
            gbCadastro.Name = "gbCadastro";
            gbCadastro.Size = new Size(1193, 558);
            gbCadastro.TabIndex = 8;
            gbCadastro.TabStop = false;
            gbCadastro.Text = "gbCadastro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(68, 300);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 4;
            label1.Text = "Phone:";
            // 
            // pesquisa
            // 
            pesquisa.AutoSize = true;
            pesquisa.BackColor = Color.PaleTurquoise;
            pesquisa.Font = new Font("Segoe UI", 12F);
            pesquisa.Location = new Point(72, 147);
            pesquisa.Name = "pesquisa";
            pesquisa.Size = new Size(83, 32);
            pesquisa.TabIndex = 3;
            pesquisa.Text = "Name:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(174, 303);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(349, 31);
            txtPhone.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(195, 150);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(328, 31);
            txtNome.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientActiveCaption;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(996, 3);
            button5.Name = "button5";
            button5.Size = new Size(62, 51);
            button5.TabIndex = 29;
            button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(1064, 3);
            button2.Name = "button2";
            button2.Size = new Size(62, 51);
            button2.TabIndex = 28;
            button2.UseVisualStyleBackColor = false;
            // 
            // FrmClienteCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 687);
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
        private TextBox txtPhone;
        private TextBox txtNome;
        private Label label2;
        private Button button5;
        private Button button2;
    }
}