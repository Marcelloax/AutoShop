namespace AutoShop
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            label2 = new Label();
            label1 = new Label();
            btnworkorders = new Button();
            button2 = new Button();
            button3 = new Button();
            btncostumers = new Button();
            Maximazin = new Button();
            button5 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Vivaldi", 30F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(437, 71);
            label2.TabIndex = 10;
            label2.Text = "The Missing Part";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(391, 135);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 9;
            label1.Click += label1_Click;
            // 
            // btnworkorders
            // 
            btnworkorders.BackColor = SystemColors.GradientActiveCaption;
            btnworkorders.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnworkorders.FlatStyle = FlatStyle.Flat;
            btnworkorders.Location = new Point(894, 3);
            btnworkorders.Name = "btnworkorders";
            btnworkorders.Size = new Size(201, 107);
            btnworkorders.TabIndex = 14;
            btnworkorders.Text = "Work Orders";
            btnworkorders.UseVisualStyleBackColor = false;
            btnworkorders.Click += Btnworkorder;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1035, 3);
            button2.Name = "button2";
            button2.Size = new Size(60, 51);
            button2.TabIndex = 18;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(894, 135);
            button3.Name = "button3";
            button3.Size = new Size(201, 105);
            button3.TabIndex = 19;
            button3.Text = "Inventory";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Btninventory;
            // 
            // btncostumers
            // 
            btncostumers.BackColor = SystemColors.GradientActiveCaption;
            btncostumers.FlatAppearance.MouseOverBackColor = Color.Silver;
            btncostumers.FlatStyle = FlatStyle.Flat;
            btncostumers.Location = new Point(894, 259);
            btncostumers.Name = "btncostumers";
            btncostumers.Size = new Size(201, 99);
            btncostumers.TabIndex = 21;
            btncostumers.Text = "Customers";
            btncostumers.UseVisualStyleBackColor = false;
            btncostumers.Click += Btncustomers;
            // 
            // Maximazin
            // 
            Maximazin.BackColor = SystemColors.GradientActiveCaption;
            Maximazin.BackgroundImage = (Image)resources.GetObject("Maximazin.BackgroundImage");
            Maximazin.BackgroundImageLayout = ImageLayout.Stretch;
            Maximazin.FlatAppearance.MouseOverBackColor = Color.Silver;
            Maximazin.FlatStyle = FlatStyle.Flat;
            Maximazin.Location = new Point(971, 3);
            Maximazin.Name = "Maximazin";
            Maximazin.Size = new Size(58, 51);
            Maximazin.TabIndex = 26;
            Maximazin.UseVisualStyleBackColor = false;
            Maximazin.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientActiveCaption;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.MouseOverBackColor = Color.Silver;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(907, 3);
            button5.Name = "button5";
            button5.Size = new Size(58, 51);
            button5.TabIndex = 27;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.Controls.Add(button2, 3, 0);
            tableLayoutPanel1.Controls.Add(button5, 1, 0);
            tableLayoutPanel1.Controls.Add(Maximazin, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1098, 160);
            tableLayoutPanel1.TabIndex = 28;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe Script", 15F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 75);
            label3.Name = "label3";
            label3.Size = new Size(898, 85);
            label3.TabIndex = 36;
            label3.Text = "Automotive Excellence";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(3, 259);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(136, 103);
            pictureBox6.TabIndex = 34;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(136, 99);
            pictureBox5.TabIndex = 33;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(3, 135);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(136, 99);
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 207F));
            tableLayoutPanel3.Controls.Add(btncostumers, 1, 2);
            tableLayoutPanel3.Controls.Add(pictureBox4, 0, 1);
            tableLayoutPanel3.Controls.Add(button3, 1, 1);
            tableLayoutPanel3.Controls.Add(pictureBox6, 0, 2);
            tableLayoutPanel3.Controls.Add(btnworkorders, 1, 0);
            tableLayoutPanel3.Controls.Add(pictureBox5, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 253);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 124F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 109F));
            tableLayoutPanel3.Size = new Size(1098, 365);
            tableLayoutPanel3.TabIndex = 35;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1098, 618);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHome";
            Text = "]";
            WindowState = FormWindowState.Maximized;
            MaximizedBoundsChanged += FrmHome_Load;
            MaximumSizeChanged += FrmHome_Load;
            Load += FrmHome_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button btnworkorders;
        private Button button2;
        private Button button3;
        private Button btncostumers;
        private Button Maximazin;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
    }
}