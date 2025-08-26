using System.Data;

namespace AutoShop
{
    public partial class FrmPeca : Form
    {
        Peca? pecaselectct;
        public FrmPeca()
        {
            InitializeComponent();
        }

        private void FrmPeca_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pecaselectct != null)
            {
                using (var bd = new AutoshopDbContext())
                {
                    bd.Pecas.Remove(pecaselectct);
                    bd.SaveChanges();
                }
                MessageBox.Show("Peça excluida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarPeca();
                pecaselectct = null;
            }

        }
        private void BuscarPeca()
        {
            using (var bd = new AutoshopDbContext())
            {
                var pecas = bd.Pecas.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    pecas = pecas.Where(p => p.Name.Contains(txtPesquisa.Text));
                }
                listaPecas.DataSource = pecas.ToList();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (pecaselectct != null)
            {
                var pcad = new FrmPecaCad(pecaselectct);
                pcad.Show();
                BuscarPeca();
                pecaselectct = null;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmPecaCad().ShowDialog();
            BuscarPeca();
        }

        private void listaPecas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                pecaselectct = listaPecas.Rows[e.RowIndex].DataBoundItem as Peca;
                btnSalvar.Enabled = true;
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPeca_Activated(object sender, EventArgs e)
        {
            BuscarPeca();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarPeca();
        }

        private void Pecas_Enter(object sender, EventArgs e)
        {

        }
    }
}
