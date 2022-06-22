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
    public partial class MetedoPagamento : Form
    {
        public RestGestContainer restGest;
        public MetedoPagamento()
        {
            InitializeComponent();
            restGest = new RestGestContainer();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            bool estado = false;
            if (txtID.Text == "")
            {
                MetodoPagamento metodoPagamento = new MetodoPagamento();
                if (rbtSim.Checked == true)
                {
                    estado = true;
                }

                if (rbtNao.Checked == true)
                {
                    estado = false;
                }

                metodoPagamento.MetPagamento = txtMetodoPagamento.Text;
                metodoPagamento.Ativo = estado;

                restGest.MetodoPagamentoSet.Add(metodoPagamento);
                restGest.SaveChanges();
                

            }
            else
            {

                int id = Convert.ToInt32(txtID.Text);
                MetodoPagamento metodoPagamento = restGest.MetodoPagamentoSet.Find(id);


                if (rbtSim.Checked == true)
                {
                    estado = true;
                }

                if (rbtNao.Checked == true)
                {
                    estado = false;
                }

                metodoPagamento.MetPagamento = txtMetodoPagamento.Text;
                metodoPagamento.Ativo = estado;

               
                restGest.SaveChanges();

            }
            ler_dados();
        }

        public void ler_dados()
        {
            dgvCategorias.Rows.Clear();// limpa a tabela 
            dgvCategorias.Refresh();// da refresh a tabela

            int i = 0;
            // query para dar join das duas tabelas e as juntar os campos de ambas
            List<MetodoPagamento> metodoPagamentos = restGest.MetodoPagamentoSet.ToList();


            //  Array arr = tabela.ToArray();
            foreach (var metodoPagamento in metodoPagamentos)
            {
                dgvCategorias.Rows.Add();

                dgvCategorias.Rows[i].Cells["ID"].Value = metodoPagamento.Id;
                dgvCategorias.Rows[i].Cells["metodoPagamento"].Value = metodoPagamento.MetPagamento;
                if (metodoPagamento.Ativo == true)
                {
                    dgvCategorias.Rows[i].Cells["Estado"].Value = "Ativo";
                    dgvCategorias.Rows[i].Cells["Estado"].Style.BackColor = Color.DarkGreen;
                    dgvCategorias.Rows[i].Cells["Estado"].Style.ForeColor = Color.White;
                }
                else
                {
                    dgvCategorias.Rows[i].Cells["Estado"].Value = "Desativo";
                    dgvCategorias.Rows[i].Cells["Estado"].Style.BackColor = Color.DarkRed;
                    dgvCategorias.Rows[i].Cells["Estado"].Style.ForeColor = Color.White;
                }
                i++;
            }
        }

        private void MetedoPagamento_Load(object sender, EventArgs e)
        {
            ler_dados();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.CurrentRow.Index != 1)
            {
               
                int row = dgvCategorias.CurrentRow.Index;

                txtID.Text = dgvCategorias.Rows[row].Cells["ID"].Value.ToString();
                txtMetodoPagamento.Text = dgvCategorias.Rows[row].Cells["metodoPagamento"].Value.ToString();
               


                if (dgvCategorias.Rows[row].Cells["Estado"].Value.ToString() == "Ativo")
                {
                    rbtSim.Checked = true;

                }
                if (dgvCategorias.Rows[row].Cells["Estado"].Value.ToString() == "Desativo")
                {
                    rbtNao.Checked = true;

                }

            }
        }
    }
}
