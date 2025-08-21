using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Ensure the picture box stays behind other controls
            pictureBox4.SendToBack();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Btnlogin(object sender, EventArgs e)
        {
            bool loginSuccess = ValidateLogin(txtusername.Text, txtpassword.Text);
            if (loginSuccess)
            {
                this.Hide();
                var login = new FrmHome(txtusername.Text, txtpassword.Text);
                login.ShowDialog();
            }
        }

        private bool ValidateLogin(string text1, string text2)
        {
            // Dummy validation logic for demonstration purposes
            return text1 == "Legends" && text2 == "123";
        }

        private void BtnClose(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Optional: also allow sending to back when clicked
            pictureBox4.SendToBack();
        }
    }
}
