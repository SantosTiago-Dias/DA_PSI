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
    public partial class Restaurante_From : Form
    {
        public RestGestContainer restGest;
        public static int id_restaurante;//vai enviar o id do restaurante para o menu

        public Restaurante_From()
        {
            InitializeComponent();
            restGest = new RestGestContainer();
            ler_dados();
        }

       

        public void ler_dados()
        {
            dgRestaurante.Rows.Clear();
            dgRestaurante.Refresh();
            int i = 0;
            // query para dar join das duas tabelas e as juntar os campos de ambas
            var query =(
                     from Restaurante in restGest.Restaurante
                     join Morada in restGest.Morada on Restaurante.MoradaId equals Morada.Id
                     select new { id=Restaurante.Id, Nome = Restaurante.Nome, Cidade = Morada.Cidade, Rua = Morada.Rua, Cod_Postal= Morada.Cod_Postal }).ToList();
            //foreach para percorrer os campos do query
            foreach (var res in query)
            {
                dgRestaurante.Rows.Add();
                dgRestaurante.Rows[i].Cells["ID"].Value = res.id;
                dgRestaurante.Rows[i].Cells["nome"].Value = res.Nome;
                dgRestaurante.Rows[i].Cells["cidade"].Value = res.Cidade;
                dgRestaurante.Rows[i].Cells["morada"].Value = res.Rua;
                dgRestaurante.Rows[i].Cells["Cod_Postal"].Value = res.Cod_Postal;
                i++;
            }
            
        }

        
        private void dgRestaurante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            limpar_txt();
            btnaddRestaurante.Text = "Editar Restaurante";
            int row = dgRestaurante.CurrentRow.Index;
            txtId.Text = dgRestaurante.Rows[row].Cells["ID"].Value.ToString();
            txtNome.Text = dgRestaurante.Rows[row].Cells["nome"].Value.ToString();
            txtCidade.Text = dgRestaurante.Rows[row].Cells["cidade"].Value.ToString();
            txtRua.Text = dgRestaurante.Rows[row].Cells["morada"].Value.ToString();
            txtCodPostal.Text = dgRestaurante.Rows[row].Cells["Cod_Postal"].Value.ToString();

            
        }

        private void btnaddRestaurante_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtRua.Text != "" && txtCodPostal.Text != "" && txtCidade.Text != "")
            {
                if(txtId.Text=="")
                {
                    //Adicionar Restaurante
                    Morada morada = new Morada();

                    morada.Rua = txtRua.Text;
                    morada.Cidade = txtCidade.Text;
                    morada.Cod_Postal = txtCodPostal.Text;

                    restGest.Morada.Add(morada);
                    restGest.SaveChanges();
                    Restaurante restaurante = new Restaurante();
                    restaurante.Nome = txtNome.Text;
                    restaurante.MoradaId = morada.Id;

                    restGest.Restaurante.Add(restaurante);
                    restGest.SaveChanges();
                   
                }
                else
                {
                    //Editar Restaurante
                    int id = Convert.ToInt32(txtId.Text);
                    Restaurante restaurante = restGest.Restaurante.Find(id);
                    Morada morada = restGest.Morada.Find(restaurante.MoradaId);

                    restaurante.Nome = txtNome.Text;
                    morada.Rua = txtRua.Text;
                    morada.Cidade = txtCidade.Text;
                    morada.Cod_Postal = txtCodPostal.Text;

                    
                    restGest.SaveChanges();
                    limpar_txt();
                    ler_dados();
                    btnAddFunc.Text = "Adiconar Restaurante";
                }

                
            }
            else
            {
                MessageBox.Show("Tem de preencher os campos todos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ler_dados();
            limpar_txt();
        }

        public void limpar_txt()
        {
            txtId.Text = "";
            txtCidade.Text = "";
            txtCodPostal.Text = "";
            txtNome.Text = "";
            txtRua.Text = "";
            
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Restaurante_From_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar_txt();
            btnaddRestaurante.Text = "Adicionar Restaurante";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "") 
            {
                DialogResult resposta = MessageBox.Show("Deseja eliminar o Restaurante?", "Pergunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    Restaurante restaurante = restGest.Restaurante.Find(id);
                    Morada morada = restGest.Morada.Find(restaurante.MoradaId);

                    restGest.Morada.Remove(morada);
                    restGest.Restaurante.Remove(restaurante);
                    restGest.SaveChanges();
                    limpar_txt();
                    ler_dados();
                }
            }
            
            
        }

        private void btnAddFunc_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                id_restaurante = Convert.ToInt32(txtId.Text);
                Funcionarios_Form funcionarios = new Funcionarios_Form();
                funcionarios.Show();
            }
            else
            {
                MessageBox.Show("Selecione um restaurante");
            }
           
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                id_restaurante = Convert.ToInt32(txtId.Text);
                Item_Menu itemMenu = new Item_Menu();
                itemMenu.Show();
            }
            else
            {
                MessageBox.Show("Selecione um restaurante");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtId.Text != "")
            {
                id_restaurante = Convert.ToInt32(txtId.Text);
                MetedoPagamento metodoPagamento = new MetedoPagamento();
                metodoPagamento.Show();
            }
            else
            {
                MessageBox.Show("Selecione um restaurante");
            }
        }
    }
}
