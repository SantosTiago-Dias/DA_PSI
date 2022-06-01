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
    public partial class Cliente_Form : Form
    {
        public RestGestContainer restGest;

        public Cliente_Form()
        {
            InitializeComponent();
            restGest = new RestGestContainer();
            ler_dados();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void ler_dados()
        {
            dgCliente.Rows.Clear();// limpa a tabela 
            dgCliente.Refresh();// da refresh a tabela
            int i = 0;

            var cliente = restGest.Pessoa.OfType<Cliente>();

            //foreach para percorrer os campos
            foreach (var res in cliente)
            {
                dgCliente.Rows.Add();
                dgCliente.Rows[i].Cells["id"].Value = res.Id;
                dgCliente.Rows[i].Cells["nome"].Value = res.Nome;
                dgCliente.Rows[i].Cells["telemovel"].Value = res.Telemovel;
                dgCliente.Rows[i].Cells["cidade"].Value = res.Morada.Cidade;
                dgCliente.Rows[i].Cells["cod_Postal"].Value = res.Morada.Cod_Postal;
                dgCliente.Rows[i].Cells["rua"].Value = res.Morada.Rua;
                dgCliente.Rows[i].Cells["contribuinte"].Value = res.NumContribuinte;
                dgCliente.Rows[i].Cells["id_morada"].Value = res.MoradaId;

                i++;
            }

        }

        public void limpar_dados()
        {
            txtCidade.Clear();
            txtCodPostal.Clear();
            txtContribuinte.Clear();
            txtNome.Clear();
            txtRua.Clear();
            txtTelemovel.Clear();
        }

        private void btnaddFunc_Click(object sender, EventArgs e)
        {
            
            bool tele = int.TryParse(txtTelemovel.Text, out int telemovel);
            bool contribuinte = int.TryParse(txtContribuinte.Text, out int contri);
            if (tele==true && contribuinte==true && txtTelemovel.Text.Length == 9 && txtContribuinte.Text.Length == 9)
            {
                if (lblID.Text == "")
                {
                    Morada morada = new Morada();

                    morada.Rua = txtRua.Text;
                    morada.Cidade = txtCidade.Text;
                    morada.Cod_Postal = txtCodPostal.Text;

                    restGest.Morada.Add(morada);
                    restGest.SaveChanges();

                    Cliente cliente = new Cliente();
                    cliente.Nome = txtNome.Text;
                    cliente.Telemovel = telemovel;
                    cliente.TotalGasto = 0;
                    cliente.NumContribuinte = contri;
                    cliente.MoradaId = morada.Id;

                    restGest.Pessoa.Add(cliente);

                    restGest.SaveChanges();

                }
                else
                {
                    Cliente cliente = (Cliente)restGest.Pessoa.Find(Convert.ToInt32(lblID.Text));
                    Morada morada = restGest.Morada.Find(cliente.MoradaId);
                    
                    morada.Rua = txtRua.Text;
                    morada.Cidade = txtCidade.Text;
                    morada.Cod_Postal = txtCodPostal.Text;
                    cliente.Nome = txtNome.Text;
                    cliente.Telemovel = telemovel;
                    cliente.NumContribuinte = contri;

                    restGest.SaveChanges();
                }
                ler_dados();
                limpar_dados();

            }
            else
            {
                MessageBox.Show("Insira os valores corretos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "")
            {
                DialogResult resposta = MessageBox.Show("Deseja eliminar o Cliente?", "Pergunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblID.Text);
                    Cliente cliente = (Cliente)restGest.Pessoa.Find(id);
                    Morada morada = restGest.Morada.Find(cliente.MoradaId);

                    restGest.Morada.Remove(morada);
                    restGest.Pessoa.Remove(cliente);
                    restGest.SaveChanges();
                    limpar_dados();
                    ler_dados();
                }
            }
            else
            {
                MessageBox.Show("Selecione primeiro um cliente");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar_dados();
            btnadd.Text = "Adiconar Cliente";
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            limpar_dados();
            btnadd.Text = "Editar Cliente";
            int row = dgCliente.CurrentRow.Index;
            lblID.Text = dgCliente.Rows[row].Cells["id"].Value.ToString();
            txtNome.Text = dgCliente.Rows[row].Cells["nome"].Value.ToString();
            txtTelemovel.Text = dgCliente.Rows[row].Cells["telemovel"].Value.ToString();
            txtCidade.Text = dgCliente.Rows[row].Cells["cidade"].Value.ToString();
            txtCodPostal.Text = dgCliente.Rows[row].Cells["cod_Postal"].Value.ToString();
            txtRua.Text = dgCliente.Rows[row].Cells["rua"].Value.ToString();
            txtContribuinte.Text = dgCliente.Rows[row].Cells["contribuinte"].Value.ToString();

        }
    }
}
