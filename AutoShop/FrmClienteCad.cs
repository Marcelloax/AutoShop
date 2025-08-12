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
    public partial class FrmClienteCad : Form
    {
        private Cliente? _Cliente;
        public FrmClienteCad()
        {
            InitializeComponent();
        }
        public FrmClienteCad(Cliente cliente)
        {
            InitializeComponent();
            _Cliente = cliente;
            CarregarDados();
        }
        private void CarregarDados()
        {
            if (_Cliente != null)
            {
                txtNome.Text = _Cliente.Name;
                txtPhone.Text = _Cliente.Phone;
            }
        }
        private void InserirCliente()
        {
            using (var bd = new AutoshopDbContext())
            {
                var cliente = new Cliente
                {
                    Name = txtNome.Text,
                    Phone = txtPhone.Text
                };
                bd.Clientes.Add(cliente);
                bd.SaveChanges();
            }
            MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void AtualizarCliente()
        {
            if (_Cliente != null)
            {
                using (var bd = new AutoshopDbContext())
                {
                    _Cliente.Name = txtNome.Text;
                    _Cliente.Phone = txtPhone.Text;
                    bd.Clientes.Update(_Cliente);
                    bd.SaveChanges();
                }
                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void gbCadastro_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_Cliente == null)
            {
                InserirCliente();
            }
            else
            {
                AtualizarCliente();
            }
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
