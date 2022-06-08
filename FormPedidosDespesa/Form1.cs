using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPedidosDespesa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double ValorTotalPedidos = 0;
        double ValorTotalDespesas = 0;
        double Saldo = 0;

        /* Função que calcula o saldo da empresa com base nos valores das variáveis públicas*/
        private void CalcularSaldo()
        {
            this.Saldo = this.ValorTotalPedidos - this.ValorTotalDespesas;
            lblSaldo.Text = this.Saldo.ToString("C");
            if (this.Saldo >= 0)            
                lblSaldo.ForeColor = Color.Blue;
            else
                lblSaldo.ForeColor = Color.Red;
            
        }

        /* Função que insere um pedido na List View*/
        private void btnInserirPedido_Click(object sender, EventArgs e)
        {
            ListViewItem ItemPedidos = new ListViewItem(txtPedido.Text);

            ItemPedidos.SubItems.Add(txtCliente.Text);
            ItemPedidos.SubItems.Add(txtValorPedido.Text);

            listPedidos.Items.Add(ItemPedidos);

            this.ValorTotalPedidos += double.Parse(txtValorPedido.Text);
            lblTotalPedidos.Text = this.ValorTotalPedidos.ToString("C");

            CalcularSaldo();
            LimparPedido();
        }

        /* Função que insere uma despesa na List View*/
        private void btnInserirDespesa_Click(object sender, EventArgs e)
        {
            ListViewItem ItemDespesas = new ListViewItem(txtDespesa.Text);

            ItemDespesas.SubItems.Add(txtValorDespesa.Text);          

            listDespesas.Items.Add(ItemDespesas);

            this.ValorTotalDespesas += double.Parse(txtValorDespesa.Text);
            lblTotalDespesa.Text = this.ValorTotalDespesas.ToString("C");

            CalcularSaldo();
            LimparDespesa();
        }

        /* Função que limpa o TextBox das Despesas*/
        private void LimparDespesa()
        {
            txtDespesa.Text = "";
            txtValorDespesa.Text = "";
            txtDespesa.Focus();
        }

        /* Função que limpa o TextBox dos Pedidos*/
        private void LimparPedido()
        {
            txtPedido.Text = "";
            txtCliente.Text = "";
            txtValorPedido.Text = "";
            txtPedido.Focus();
        }

        /* Função que limpa todos os campos e variáveis públicas*/
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparDespesa();
            LimparPedido();
            this.Saldo = 0;
            this.ValorTotalDespesas = 0;
            this.ValorTotalPedidos = 0;
            txtValorDespesa.Text = "";
            txtValorDespesa.Text = "";
            listDespesas.Items.Clear();
            listPedidos.Items.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
