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
    public partial class FrmHome : Form
    {
        public FrmHome(string nome, string senha)
        {
            InitializeComponent();
            label1.Text = $"Bem-vindo, {nome}!";
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btninventory(object sender, EventArgs e)
        {
            var inventory = new FrmPeca();
            inventory.ShowDialog();
        }

        private void Btncustomers(object sender, EventArgs e)
        {
            var customers = new FrmCliente();
            customers.ShowDialog();
        }

        private void Btnworkorder(object sender, EventArgs e)
        {
            var workOrder = new FrmVendas();
            workOrder.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            var login = new Login();
            login.ShowDialog();
        }
    }
}
