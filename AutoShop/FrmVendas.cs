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
        private void FrmVendas_Load(object sender, EventArgs e)
        {
           BuscarVenda();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarVenda();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmVendasCad().ShowDialog();
            BuscarVenda();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vvenda != null)
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

                listaPecas.DataSource = vendas.Select((e) =>
                    new
                    {
                        Id = e.Id,
                        Cliente = e.Cliente.Name,
                        Telefone = e.Cliente.Phone,
                        Data = e.Data.ToString("dd/MM/yyyy"),
                        Quantidade = e.Quantidade
                    }    
                ).ToList();

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
            using (var bd = new AutoshopDbContext())
            {
                if (e.RowIndex >= 0 && e.RowIndex < listaPecas.Rows.Count)
                {
                    var id = Convert.ToInt32(listaPecas.Rows[e.RowIndex].Cells[0].Value);
                    vvenda = bd.Vendas.Find(id);
                }
            }
        }
    }
}
