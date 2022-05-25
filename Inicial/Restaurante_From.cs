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
        public Restaurante_From()
        {
            InitializeComponent();
            restGest = new RestGestContainer();
            ler_dados();
        }

        private void btnAddMorada_Click(object sender, EventArgs e)
        {
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

        public void ler_dados()
        {
            int i = 0;
            // query para dar join das duas tabelas e as juntar os campos de ambas
            var innerJoinQuery =(
                     from Restaurante in restGest.Restaurante
                     join Morada in restGest.Morada on Restaurante.MoradaId equals Morada.Id
                     select new { Nome = Restaurante.Nome, Cidade = Morada.Cidade, Rua = Morada.Rua }).ToList();

            MessageBox.Show(innerJoinQuery.Count().ToString());
            Array arr = innerJoinQuery.ToArray();
            foreach (var res in innerJoinQuery)
            {
                dgRestaurante.Rows.Add();
                dgRestaurante.Rows[i].Cells["nome"].Value = res.Nome;
                dgRestaurante.Rows[i].Cells["cidade"].Value = res.Cidade;
                dgRestaurante.Rows[i].Cells["morada"].Value = res.Rua;
               
                i++;
            }
            // for para percorrer as linahs da query
            /*for (int i = 0; i <= innerJoinQuery.Count(); i++)
            {
                //foreach para carregar cada resultado da query
                foreach (var res in innerJoinQuery)
                {
                    dgRestaurante.Rows[i].Cells["nome"].Value = res.Nome[i];
                    dgRestaurante.Rows[i].Cells["cidade"].Value = res.Cidade[i];
                }
                

            }*/
        }

        
        private void dgRestaurante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
