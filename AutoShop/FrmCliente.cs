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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmPecaCad().ShowDialog();
            BuscarCliente();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (clienteSelect != null)
            {
                var cad = new FrmClienteCad(clienteSelect);
                cad.Show();
                BuscarCliente();
                clienteSelect = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clienteSelect != null)
            {
                using (var bd = new AutoshopDbContext())
                {
                    bd.Clientes.Remove(clienteSelect);
                    bd.SaveChanges();
                }
                MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarCliente();
                clienteSelect = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }
    }
}
