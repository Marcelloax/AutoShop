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
    public partial class FrmPecaCad : Form
    {
        private Peca _pecas;
        public FrmPecaCad()
        {
            InitializeComponent();
        }

        public FrmPecaCad(Peca pecaselectct)
        {
            _pecas = pecaselectct;
            InitializeComponent();
            CarregarDados();
        }
        private void CarregarDados()
        {
            if (_pecas == null)
            {
                txtNome.Text = _pecas.Name;
                txtPrice.Text = _pecas.Price.ToString("F2");
                txtStock.Text = _pecas.Stock.ToString();
            }
        }


        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (_pecas == null)
            {
                InserirPeca();
            }
            else
            {
                AtualizarPeca();
            }
        }
        private void InserirPeca()
        {
            using (var bd = new AutoshopDbContext())
            {
                var peca = new Peca
                {
                    Name = txtNome.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Stock = int.Parse(txtStock.Text)
                };
                bd.Pecas.Add(peca);
                bd.SaveChanges();
            }
            MessageBox.Show("Peça cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void AtualizarPeca()
        {
            using (var bd = new AutoshopDbContext())
            {
                string nome = txtNome.Text;
                decimal preco = decimal.Parse(txtPrice.Text);
                int estoque = int.Parse(txtStock.Text);
                var peca = bd.Pecas.First(x => x.Id == _pecas.Id);
                peca.Name = nome;
                peca.Price = preco;
                peca.Stock = estoque;
                bd.SaveChanges();
            }
            MessageBox.Show("Peça atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}