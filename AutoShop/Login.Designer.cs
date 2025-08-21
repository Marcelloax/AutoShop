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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.InactiveCaption;
            txtusername.Location = new Point(414, 191);
            txtusername.Margin = new Padding(0);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(218, 31);
            txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.InactiveCaption;
            txtpassword.Location = new Point(402, 312);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(218, 31);
            txtpassword.TabIndex = 1;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.GradientActiveCaption;
            LoginBtn.BackgroundImageLayout = ImageLayout.Stretch;
            LoginBtn.ForeColor = SystemColors.Highlight;
            LoginBtn.Location = new Point(431, 376);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(128, 51);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += Btnlogin;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(402, 157);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 3;
            label1.Text = "USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(402, 270);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Tempus Sans ITC", 20F);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(-2, -7);
            label3.Name = "label3";
            label3.Size = new Size(992, 70);
            label3.TabIndex = 5;
            label3.Text = "Automotive Excellence";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.GradientActiveCaption;
            btnClose.Location = new Point(928, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(48, 40);
            btnClose.TabIndex = 6;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose;
            // 
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
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusername;
        private TextBox txtpassword;
        private Button LoginBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnClose;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}