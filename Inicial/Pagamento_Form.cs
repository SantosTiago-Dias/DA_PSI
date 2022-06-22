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

            carregar_mesas();
            List<MetodoPagamento> metodoPagamentos = restGest.MetodoPagamentoSet.ToList();

            foreach (MetodoPagamento metodoPagamento in metodoPagamentos)
            {
                if (metodoPagamento.Ativo == true)
                {
                    cmbMetedoPagamento.Items.Add(metodoPagamento);
                }

            }

            ler_dados();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (cmbPedido.SelectedItem != null && cmbMetedoPagamento.SelectedItem != null && txtValor.Text != "")
            {
               
                decimal value = Convert.ToDecimal(txtValor.Text);
                Pedido pedido = (Pedido)cmbPedido.SelectedItem;
                MetodoPagamento metodoPagamento = (MetodoPagamento)cmbMetedoPagamento.SelectedItem;
                Pagamento pagamento = new Pagamento();


                if (pedido.ValorTotal >= value)
                {

                    pagamento.PedidoId = pedido.Id;
                    pagamento.MetodoPagamentoId = metodoPagamento.Id;
                    pagamento.Valor = value;

                    restGest.Pagamento.Add(pagamento);
                    restGest.SaveChanges();

                }
                else
                {
                    MessageBox.Show("Valor invalido");
                }

                ler_dados();
                carregar_mesas();
                limpar_txt();
            }
            else
            {
                MessageBox.Show("Insira valores");
            }
           

        }

        public void ler_dados()
        {
            dgPagamento.Rows.Clear();// limpa a tabela 
            dgPagamento.Refresh();// da refresh a tabela
            int i = 0;
            string metedos;
            decimal falta_pagar;
            List<Pagamento> pagamentos = restGest.Pagamento.ToList();
            List<Pedido> pedidos = restGest.Pedido.ToList();

            foreach (var pedido in pedidos)
            {
                falta_pagar = 0;
                metedos = "";
                falta_pagar= pedido.ValorTotal;
                foreach (var pagamento in pagamentos)
                {
                    if (pedido.Id == pagamento.PedidoId)
                    {
                        falta_pagar -= pagamento.Valor;
                        metedos = metedos + " " + pagamento.MetodoPagamento;
                    }
                }

                dgPagamento.Rows.Add();
                dgPagamento.Rows[i].Cells["Nmesa"].Value = pedido.Id;
                dgPagamento.Rows[i].Cells["valor_total"].Value = pedido.ValorTotal;
                dgPagamento.Rows[i].Cells["faltapagar"].Value = falta_pagar;
                dgPagamento.Rows[i].Cells["metedoPagamento"].Value = metedos;
                i++;
            }
        }

        public void carregar_mesas()
        {
            cmbPedido.Items.Clear();
            decimal falta_pagar;
            List<Pedido> pedidos = restGest.Pedido.ToList();
            List<Pagamento> pagamentos = restGest.Pagamento.ToList();

            foreach (var pedido in pedidos)
            {
                falta_pagar = 0;

                falta_pagar = pedido.ValorTotal;
                foreach (var pagamento in pagamentos)
                {
                    if (pedido.Id == pagamento.PedidoId)
                    {
                        falta_pagar -= pagamento.Valor;

                    }



                }
                if (falta_pagar != 0)
                {
                    cmbPedido.Items.Add(pedido);
                }

            }
        }

        public void limpar_txt()
        {
            cmbMetedoPagamento.SelectedIndex = -1;
            cmbPedido.SelectedItem = "";
            txtValor.Text = "";
        }
    }
}
