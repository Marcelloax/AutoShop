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
    public partial class FrmVendasCad : Form
    {
        private Venda? vvenda;

        public FrmVendasCad()
        {
            InitializeComponent();

            using (var bd = new AutoshopDbContext())
            {
                var itens = bd.Pecas.ToList();
                var Clientes = bd.Clientes.ToList();
                cbxpart.DataSource = itens;
                cbxpart.DisplayMember = "Nome";
                cbxpart.ValueMember = "Id";
                cbxclient.DataSource = Clientes;
                cbxclient.DisplayMember = "Name";
                cbxclient.ValueMember = "Id";

            }
        }
        public FrmVendasCad(Venda venda)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmVendasCad_Load(object sender, EventArgs e)
        {

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (vvenda == null)
            {
                InserirVenda();
            }
            else
            {
                AtualizarVenda();
            }
        }
        private void InserirVenda()
        {
            using (var bd = new AutoshopDbContext())
            {
                string ClienteId = cbxclient.ToString();
                string PecaId = cbxpart.ToString();
                var venda = new Venda
                {
                    ClienteId = int.Parse(ClienteId),
                    PecaId = int.Parse(PecaId),
                    Quantidade = int.Parse(txtquant.Text)
                };
                bd.Vendas.Add(venda);
                bd.SaveChanges();
            }
            MessageBox.Show("Venda inserida com sucesso!");

        }
        private void AtualizarVenda()
        {
            using (var bd = new AutoshopDbContext())
            {
                string ClienteId = cbxclient.ToString();
                string PecaId = cbxpart.ToString();
                vvenda.ClienteId = int.Parse(ClienteId);
                vvenda.PecaId = int.Parse(PecaId);
                vvenda.Quantidade = int.Parse(txtquant.Text);
                bd.Vendas.Update(vvenda);
                bd.SaveChanges();
            }
            MessageBox.Show("Venda atualizada com sucesso!");
        }
    }
}
