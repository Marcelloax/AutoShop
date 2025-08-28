namespace AutoShop
{
    partial class FrmVendasCad
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
            groupBox1 = new GroupBox();
            cbxclient = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cbxpart = new ComboBox();
            groupBox2 = new GroupBox();
            txtquant = new TextBox();
            label3 = new Label();
            button1 = new Button();
            btnSalvar = new Button();
            panel1 = new Panel();
            Fechar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxclient);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbxpart);
            groupBox1.Location = new Point(130, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 197);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbxclient
            // 
            cbxclient.FormattingEnabled = true;
            cbxclient.Location = new Point(171, 65);
            cbxclient.Name = "cbxclient";
            cbxclient.Size = new Size(220, 33);
            cbxclient.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(25, 126);
            label2.Name = "label2";
            label2.Size = new Size(59, 32);
            label2.TabIndex = 4;
            label2.Text = "Part:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(25, 65);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 3;
            label1.Text = "Customer:";
            // 
            // cbxpart
            // 
            cbxpart.FormattingEnabled = true;
            cbxpart.Location = new Point(175, 129);
            cbxpart.Name = "cbxpart";
            cbxpart.Size = new Size(220, 33);
            cbxpart.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtquant);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(130, 435);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(486, 105);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Qty";
            // 
            // txtquant
            // 
            txtquant.Location = new Point(169, 44);
            txtquant.Name = "txtquant";
            txtquant.Size = new Size(226, 31);
            txtquant.TabIndex = 5;
            txtquant.TextChanged += txtquant_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(66, 44);
            label3.Name = "label3";
            label3.Size = new Size(57, 32);
            label3.TabIndex = 4;
            label3.Text = "Qty:";
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(771, 608);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SpringGreen;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(915, 608);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Save";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(Fechar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 83);
            panel1.TabIndex = 9;
            // 
            // Fechar
            // 
            Fechar.BackColor = Color.Red;
            Fechar.FlatAppearance.MouseOverBackColor = Color.Silver;
            Fechar.FlatStyle = FlatStyle.Flat;
            Fechar.Location = new Point(1011, 23);
            Fechar.Name = "Fechar";
            Fechar.Size = new Size(38, 34);
            Fechar.TabIndex = 4;
            Fechar.Text = "X";
            Fechar.UseVisualStyleBackColor = false;
            Fechar.Click += Fechar_Click;
            // 
            // FrmVendasCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 663);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVendasCad";
            Text = "FrmVendasCad";
            Load += FrmVendasCad_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbxpart;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button btnSalvar;
        private Panel panel1;
        private Button Fechar;
        private ComboBox cbxclient;
        private TextBox txtquant;
    }
}