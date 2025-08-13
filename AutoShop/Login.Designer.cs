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
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.InactiveCaption;
            txtusername.Location = new Point(402, 199);
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
            LoginBtn.Location = new Point(419, 400);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(167, 51);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += Btnlogin;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(479, 140);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 3;
            label1.Text = "USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(465, 263);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe Script", 10F);
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
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(988, 551);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginBtn);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
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
    }
}