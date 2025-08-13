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
    public partial class FrmVendas : Form
    {
        Venda? vvenda;
        public FrmVendas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarVenda();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmVendasCad().ShowDialog();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vvenda == null)
            {
                using (var bd = new AutoshopDbContext())
                {
                    bd.Vendas.Remove(vvenda);
                    bd.SaveChanges();
                }
                MessageBox.Show("Venda excluída com sucesso!");
                BuscarVenda();
                vvenda = null;
            }
        }
        private void BuscarVenda()
        {
            using (var bd = new AutoshopDbContext())
            {
                var vendas = bd.Vendas.AsQueryable();
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    vendas = vendas.Where(v => v.Cliente.Name.Contains(textBox1.Text));
                }
                listaPecas.DataSource = vendas.ToList();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (vvenda != null)
            {
                var v = new FrmVendasCad(vvenda);
                v.Show();
                BuscarVenda();
                vvenda = null;
            }
        }

        private void listaPecas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                vvenda = listaPecas.Rows[e.RowIndex].DataBoundItem as Venda;
                btnSalvar.Enabled = true;
            }
        }
    }
}
