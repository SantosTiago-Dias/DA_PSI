using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicial
{
    public partial class Pagamento_Form : Form
    {
        public RestGestContainer restGest;
        public Pagamento_Form()
        {
            InitializeComponent();
            restGest = new RestGestContainer();
        }

        private void Pagamento_Form_Load(object sender, EventArgs e)
        {
            Pedidos_cmb();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {

        }

        public void Pedidos_cmb()
        {
            cmbPedido.Items.Clear();
            List<Pedido> pedidos = restGest.Pedido.ToList();

            foreach (var pedido in pedidos)
            {
                cmbPedido.Items.Add(pedido.Id);
            }
        }

        public void MetodosPagamento_cmb()
        {
            cmbMetedoPagamento.Items.Clear();
            List<MetodoPagamento> metodoPagamentos = restGest.MetodoPagamentoSet.ToList();

            foreach (var metodoPagamento in metodoPagamentos)
            {
                if (metodoPagamento.Ativo== true)
                {
                    cmbMetedoPagamento.Items.Add(metodoPagamento.MetPagamento);
                }
               
            }
        }
    }
}
