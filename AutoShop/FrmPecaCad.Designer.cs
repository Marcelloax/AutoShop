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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPecaCad));
            panel1 = new Panel();
            Fechar = new Button();
            button1 = new Button();
            btnSalvar = new Button();
            gbCadastro = new GroupBox();
            pictureBox1 = new PictureBox();
            txtStock = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pesquisa = new Label();
            txtPrice = new TextBox();
            txtNome = new TextBox();
            panel1.SuspendLayout();
            gbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(Fechar);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 49);
            panel1.TabIndex = 7;
            // 
            // Fechar
            // 
            Fechar.BackColor = Color.LightGray;
            Fechar.Font = new Font("Castellar", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fechar.Location = new Point(818, 0);
            Fechar.Margin = new Padding(2, 2, 2, 2);
            Fechar.Name = "Fechar";
            Fechar.Size = new Size(27, 20);
            Fechar.TabIndex = 4;
            Fechar.Text = "X";
            Fechar.UseVisualStyleBackColor = false;
            Fechar.Click += Fechar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Location = new Point(664, 315);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 6;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SpringGreen;
            btnSalvar.Location = new Point(746, 315);
            btnSalvar.Margin = new Padding(2, 2, 2, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(78, 20);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Save";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // gbCadastro
            // 
            gbCadastro.BackgroundImage = (Image)resources.GetObject("gbCadastro.BackgroundImage");
            gbCadastro.BackgroundImageLayout = ImageLayout.Stretch;
            gbCadastro.Controls.Add(pictureBox1);
            gbCadastro.Controls.Add(txtStock);
            gbCadastro.Controls.Add(button1);
            gbCadastro.Controls.Add(label2);
            gbCadastro.Controls.Add(btnSalvar);
            gbCadastro.Controls.Add(label1);
            gbCadastro.Controls.Add(pesquisa);
            gbCadastro.Controls.Add(txtPrice);
            gbCadastro.Controls.Add(txtNome);
            gbCadastro.Location = new Point(0, 47);
            gbCadastro.Margin = new Padding(2, 2, 2, 2);
            gbCadastro.Name = "gbCadastro";
            gbCadastro.Padding = new Padding(2, 2, 2, 2);
            gbCadastro.Size = new Size(842, 367);
            gbCadastro.TabIndex = 4;
            gbCadastro.TabStop = false;
            gbCadastro.Text = "gbCadastro";
            gbCadastro.Enter += gbCadastro_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(727, 0);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 77);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(325, 155);
            txtStock.Margin = new Padding(2, 2, 2, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(246, 23);
            txtStock.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(248, 153);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 5;
            label2.Text = "In Stock:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(258, 115);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 4;
            label1.Text = "Price:";
            // 
            // pesquisa
            // 
            pesquisa.AutoSize = true;
            pesquisa.BackColor = SystemColors.ActiveCaption;
            pesquisa.FlatStyle = FlatStyle.Flat;
            pesquisa.Font = new Font("Segoe UI", 12F);
            pesquisa.Location = new Point(248, 67);
            pesquisa.Margin = new Padding(0);
            pesquisa.Name = "pesquisa";
            pesquisa.Size = new Size(55, 21);
            pesquisa.TabIndex = 3;
            pesquisa.Text = "Name:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(318, 116);
            txtPrice.Margin = new Padding(2, 2, 2, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(138, 23);
            txtPrice.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(311, 69);
            txtNome.Margin = new Padding(2, 2, 2, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(246, 23);
            txtNome.TabIndex = 0;
            // 
            // FrmPecaCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 412);
            Controls.Add(panel1);
            Controls.Add(gbCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmPecaCad";
            Text = "FrmPecaCad";
            panel1.ResumeLayout(false);
            gbCadastro.ResumeLayout(false);
            gbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}