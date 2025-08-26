namespace AutoShop
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtusername = new TextBox();
            txtpassword = new TextBox();
            LoginBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnClose = new Button();
            max = new Button();
            min = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.InactiveCaption;
            txtusername.Location = new Point(0, 32);
            txtusername.Margin = new Padding(0);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(218, 31);
            txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.InactiveCaption;
            txtpassword.Location = new Point(3, 105);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(217, 31);
            txtpassword.TabIndex = 1;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.GradientActiveCaption;
            LoginBtn.Location = new Point(3, 148);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(218, 48);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += Btnlogin;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 3;
            label1.Text = "USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 76);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe Script", 10F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(829, 53);
            label3.TabIndex = 5;
            label3.Text = "Automotive Excellence";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.GradientActiveCaption;
            btnClose.Location = new Point(938, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(48, 40);
            btnClose.TabIndex = 6;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose;
            // 
            // max
            // 
            max.BackColor = SystemColors.GradientActiveCaption;
            max.Location = new Point(889, 3);
            max.Name = "max";
            max.Size = new Size(43, 40);
            max.TabIndex = 7;
            max.Text = "[ ]";
            max.UseVisualStyleBackColor = false;
            max.Click += max_Click;
            // 
            // min
            // 
            min.BackColor = SystemColors.GradientActiveCaption;
            min.Location = new Point(838, 3);
            min.Name = "min";
            min.Size = new Size(45, 40);
            min.TabIndex = 8;
            min.Text = "-";
            min.UseVisualStyleBackColor = false;
            min.Click += min_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Controls.Add(btnClose, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(min, 1, 0);
            tableLayoutPanel1.Controls.Add(max, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(989, 53);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(txtpassword, 0, 3);
            tableLayoutPanel2.Controls.Add(LoginBtn, 0, 4);
            tableLayoutPanel2.Controls.Add(txtusername, 0, 1);
            tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel2.Location = new Point(377, 216);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel2.Size = new Size(224, 200);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(989, 552);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtusername;
        private TextBox txtpassword;
        private Button LoginBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnClose;
        private Button max;
        private Button min;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}