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
        Cliente? clienteSelect = null;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            BuscarCliente();
        }
        private void BuscarCliente()
        {
            using (var bd = new AutoshopDbContext())
            {
                var clientes = bd.Clientes.AsQueryable();
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    clientes = clientes.Where(c => c.Name.Contains(textBox1.Text));
                }
                listaPecas.DataSource = clientes.ToList();

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmClienteCad().ShowDialog();
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

        private void gbCadastro_Enter(object sender, EventArgs e)
        {

        }

        private void listaPecas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var bd = new AutoshopDbContext())
            {
                if (e.RowIndex >= 0 && e.RowIndex < listaPecas.Rows.Count)
                {
                    var id = Convert.ToInt32(listaPecas.Rows[e.RowIndex].Cells[0].Value);
                    clienteSelect = bd.Clientes.Find(id);
                }
            }
        }
        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}