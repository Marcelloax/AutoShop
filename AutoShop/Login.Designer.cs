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
<<<<<<< HEAD
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
=======
            max = new Button();
            min = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
>>>>>>> b092a0cd944b91bd44a9bd8af41a30790f27e200
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.InactiveCaption;
<<<<<<< HEAD
            txtusername.Location = new Point(414, 191);
=======
            txtusername.Location = new Point(0, 20);
>>>>>>> b092a0cd944b91bd44a9bd8af41a30790f27e200
            txtusername.Margin = new Padding(0);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(154, 23);
            txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.InactiveCaption;
            txtpassword.Location = new Point(2, 80);
            txtpassword.Margin = new Padding(2);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(153, 23);
            txtpassword.TabIndex = 1;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.GradientActiveCaption;
<<<<<<< HEAD
            LoginBtn.BackgroundImageLayout = ImageLayout.Stretch;
            LoginBtn.ForeColor = SystemColors.Highlight;
            LoginBtn.Location = new Point(431, 376);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(128, 51);
=======
            LoginBtn.Location = new Point(2, 106);
            LoginBtn.Margin = new Padding(2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(117, 29);
>>>>>>> b092a0cd944b91bd44a9bd8af41a30790f27e200
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += Btnlogin;
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(402, 157);
=======
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
>>>>>>> b092a0cd944b91bd44a9bd8af41a30790f27e200
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 3;
            label1.Text = "USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(402, 270);
=======
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(2, 59);
            label2.Margin = new Padding(2, 0, 2, 0);
>>>>>>> b092a0cd944b91bd44a9bd8af41a30790f27e200
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
<<<<<<< HEAD
            label3.Font = new Font("Tempus Sans ITC", 20F);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(-2, -7);
=======
            label3.Font = new Font("Segoe Script", 10F);
            label3.Location = new Point(2, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
>>>>>>> b092a0cd944b91bd44a9bd8af41a30790f27e200
            label3.Name = "label3";
            label3.Size = new Size(580, 32);
            label3.TabIndex = 5;
            label3.Text = "Automotive Excellence";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.GradientActiveCaption;
            btnClose.Location = new Point(656, 2);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 24);
            btnClose.TabIndex = 6;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose;
            // 
<<<<<<< HEAD
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(316, 171);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 51);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(316, 291);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 62);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(248, 157);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(501, 283);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
=======
            // max
            // 
            max.BackColor = SystemColors.GradientActiveCaption;
            max.Location = new Point(622, 2);
            max.Margin = new Padding(2);
            max.Name = "max";
            max.Size = new Size(30, 24);
            max.TabIndex = 7;
            max.Text = "[ ]";
            max.UseVisualStyleBackColor = false;
            max.Click += max_Click;
            // 
            // min
            // 
            min.BackColor = SystemColors.GradientActiveCaption;
            min.Location = new Point(586, 2);
            min.Margin = new Padding(2);
            min.Name = "min";
            min.Size = new Size(32, 24);
            min.TabIndex = 8;
            min.Text = "-";
            min.UseVisualStyleBackColor = false;
            min.Click += min_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnClose, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(min, 1, 0);
            tableLayoutPanel1.Controls.Add(max, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(692, 32);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(txtpassword, 0, 3);
            tableLayoutPanel2.Controls.Add(LoginBtn, 0, 4);
            tableLayoutPanel2.Controls.Add(txtusername, 0, 1);
            tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel2.Location = new Point(264, 96);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel2.Size = new Size(157, 137);
            tableLayoutPanel2.TabIndex = 10;
>>>>>>> b092a0cd944b91bd44a9bd8af41a30790f27e200
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(988, 551);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginBtn);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            ForeColor = SystemColors.ActiveCaption;
=======
            BackColor = Color.SkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(692, 331);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
>>>>>>> b092a0cd944b91bd44a9bd8af41a30790f27e200
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
=======
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
>>>>>>> b092a0cd944b91bd44a9bd8af41a30790f27e200
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
<<<<<<< HEAD
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
=======
        private Button max;
        private Button min;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
>>>>>>> b092a0cd944b91bd44a9bd8af41a30790f27e200
    }
}