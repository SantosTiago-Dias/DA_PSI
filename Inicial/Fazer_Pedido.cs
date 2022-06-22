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
    public partial class Fazer_Pedido : Form
    {
        public RestGestContainer restGest;
        
        public Fazer_Pedido()
        {
            InitializeComponent();
            restGest = new RestGestContainer();
        }

        private void Fazer_Pedido_Load(object sender, EventArgs e)
        {
           Restaurante restaurante = restGest.Restaurante.Find(Funcionarios_Form.restaurante_id);
           Trabalhador trabalhador = (Trabalhador)restGest.Pessoa.Find(Funcionarios_Form.funcionario_id);

            lblFuncionario.Text = Funcionarios_Form.funcionario_id.ToString();
            lblIdRestaurante.Text = Funcionarios_Form.restaurante_id.ToString();

            lblNomeFuncionario.Text = trabalhador.Nome;
            lblNomeRestaurante.Text = restaurante.Nome;

            List<ItemMenu> itemmenu = restGest.ItemMenu.ToList();

            //foreach para percorrer os campos
            foreach (var res in itemmenu)
            {
                if (res.Restaurante.Contains(restaurante) == true && res.Ativo==true)
                {
                    
                    cmbPratos.Items.Add(res.Nome);
                }

            }

            ler_dados();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
            if (txtNifCliente.TextLength == 9)
            {
                int numcontribuinte = Convert.ToInt32(txtNifCliente.Text);
                var cliente = restGest.Pessoa.OfType<Cliente>();

                foreach (var res in cliente)
                {
                    if (numcontribuinte == res.NumContribuinte)
                    {
                        lblCliente.Text = res.Nome;
                        lblCLienteId.Text = res.Id.ToString();
                    }
                }
            }
            
           
        }

        private void btnAdionarLista_Click(object sender, EventArgs e)
        {
            decimal valor_total = Convert.ToDecimal(lblValorTotal.Text);
            string nome_prato = cmbPratos.SelectedItem.ToString();

            List<ItemMenu> itemmenu = restGest.ItemMenu.ToList();

            //foreach para percorrer os campos
            foreach (var res in itemmenu)
            {
                if(nome_prato == res.Nome)
                {
                    lblValorTotal.Text = (valor_total + res.Preco).ToString();
                }

            }
            lbPratos.Items.Add(nome_prato);
        }

        private void btnFazerPedido_Click(object sender, EventArgs e)
        {
            if(lblCLienteId.Text !="" && lblFuncionario.Text !="" && lblIdRestaurante.Text !="" && lbPratos.Items.Count != 0)
            {
                Pedido pedido = new Pedido();
                pedido.ClienteId = Convert.ToInt32(lblCLienteId.Text);
                pedido.TrabalhadorId = Convert.ToInt32(lblFuncionario.Text);
                pedido.RestauranteId = Convert.ToInt32(lblIdRestaurante.Text);

                List<ItemMenu> itemmenu = restGest.ItemMenu.ToList();

                foreach (var res in itemmenu)
                {
                    foreach (string nome_prato in lbPratos.Items)
                    {
                        if (nome_prato == res.Nome)
                        {
                            ItemMenu item = restGest.ItemMenu.Find(res.Id);
                            pedido.ItemMenu.Add(item);
                        }
                    }

                }
                pedido.ValorTotal = Convert.ToDecimal(lblValorTotal.Text);
                pedido.EstadoId = 1;
                restGest.Pedido.Add(pedido);
                restGest.SaveChanges();

                ler_dados();
            }
            else
            {
                MessageBox.Show("Insira todos os dados");
            }
            

           
        }

        public void ler_dados()
        {
            dgPedido.Rows.Clear();// limpa a tabela 
            dgPedido.Refresh();// da refresh a tabela
            int i = 0;
            
            List<Pedido> pedidos = restGest.Pedido.ToList();
            List<ItemMenu> itemmenu = restGest.ItemMenu.ToList();
            //foreach para percorrer os campos
            foreach (var res in pedidos)
            {
                string valores_pedido;
                valores_pedido = "";
                if (res.RestauranteId == Convert.ToInt32(lblIdRestaurante.Text))
                {

                    foreach (var nome_prato in itemmenu)
                    {

                        if (res.ItemMenu.Contains(nome_prato) == true)
                        {
                            valores_pedido = valores_pedido + " " + nome_prato.Nome;
                        }
                    }
                   
                    dgPedido.Rows.Add();
                    dgPedido.Rows[i].Cells["nPedido"].Value = res.Id;
                    dgPedido.Rows[i].Cells["cliente"].Value = res.Cliente.Nome;
                    dgPedido.Rows[i].Cells["funcionario"].Value = res.Trabalhador.Nome;
                    dgPedido.Rows[i].Cells["pedido"].Value = valores_pedido;
                    dgPedido.Rows[i].Cells["valortotal"].Value = Convert.ToDecimal(res.ValorTotal);
                    dgPedido.Rows[i].Cells["estado"].Value = res.Estado.State;


                    i++;
                }

            }
        }
    }
}
