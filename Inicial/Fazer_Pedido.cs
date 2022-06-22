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
                MessageBox.Show("O pedido foi recebido");
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

                    //Recebido
                    if (res.EstadoId == 1)
                    {
                        dgPedido.Rows[i].Cells["estado"].Value = res.Estado.State;
                        dgPedido.Rows[i].Cells["Estado"].Style.BackColor = Color.Orange;
                        dgPedido.Rows[i].Cells["Estado"].Style.ForeColor = Color.White;
                    }
                    //Em processo
                    else if (res.EstadoId == 2)
                    {
                        dgPedido.Rows[i].Cells["estado"].Value = res.Estado.State;
                        dgPedido.Rows[i].Cells["Estado"].Style.BackColor = Color.YellowGreen;
                        dgPedido.Rows[i].Cells["Estado"].Style.ForeColor = Color.White;
                    }
                    //Concluido
                    else if (res.EstadoId == 3)
                    {
                        dgPedido.Rows[i].Cells["estado"].Value = res.Estado.State;
                        dgPedido.Rows[i].Cells["Estado"].Style.BackColor = Color.Green;
                        dgPedido.Rows[i].Cells["Estado"].Style.ForeColor = Color.White;
                    }
                    //Cancelado
                    else if (res.EstadoId == 4)
                    {
                        dgPedido.Rows[i].Cells["estado"].Value = res.Estado.State;
                        dgPedido.Rows[i].Cells["Estado"].Style.BackColor = Color.DarkRed;
                        dgPedido.Rows[i].Cells["Estado"].Style.ForeColor = Color.White;
                    }




                    i++;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = dgPedido.CurrentRow.Index;
            if (row != null)
            {
                int id = Convert.ToInt32(dgPedido.Rows[row].Cells["nPedido"].Value);
                string estado = dgPedido.Rows[row].Cells["estado"].Value.ToString();
                Pedido pedido = restGest.Pedido.Find(id);
                if (estado != "Concluido")
                {
                    DialogResult resposta = MessageBox.Show("Deseja eliminar o Pedido nº"+id+" ?", "Pergunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (resposta == DialogResult.Yes)
                    {
                        pedido.EstadoId = 4;
                        MessageBox.Show("O pedido nº "+ id+" foi eliminado com sucesso");
                        restGest.SaveChanges();
                       
                    }
                    
                }
                else
                {
                    MessageBox.Show("O pedido ja foi concluido");
                }

            }
            ler_dados();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            int row = dgPedido.CurrentRow.Index;
            if (row != null)
            {
                int id = Convert.ToInt32(dgPedido.Rows[row].Cells["nPedido"].Value);
                string estado= dgPedido.Rows[row].Cells["estado"].Value.ToString();
                Pedido pedido = restGest.Pedido.Find(id);
                if (estado != "Cancelado")
                {
                    if (estado == "Recebido")
                    {
                        pedido.EstadoId = 2;
                        MessageBox.Show("O pedido esta em Processo");
                    }
                    else if (estado == "Em Processo")
                    {
                        pedido.EstadoId = 3;
                        MessageBox.Show("O pedido foi Concluido com sucesso");
                    }
                    else if (estado == "Concluido")
                    {
                        MessageBox.Show("O pedido ja foi Concluido");
                    }

                    restGest.SaveChanges();
                    
                }
                else
                {
                    MessageBox.Show("O pedido foi cancelado");
                }
                   
            }
            ler_dados();
        }
    }
}
