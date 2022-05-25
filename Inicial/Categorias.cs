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
    public partial class Categorias : Form
    {
        public RestGestContainer restGest;
        public Categorias()
        {
            InitializeComponent();
            restGest = new RestGestContainer();
            ler_dados();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            Categoria categoria = new Categoria();

            bool estado =false ;


            if(txtID.Text =="")
            {
                if (rbtSim.Checked == true)
                {
                    estado = true;
                    //label3.Text = estado.ToString();
                }

                if (rbtNao.Checked == true)
                {
                    estado = false;

                    //label3.Text =estado.ToString();

                }

                categoria.Nome = txtNome.Text;
                categoria.Ativo = estado;

                restGest.Categoria.Add(categoria);
                restGest.SaveChanges();
          
            }
            else {

                int id = Convert.ToInt32(txtID.Text);
                categoria=restGest.Categoria.Find(id);


                if (rbtSim.Checked == true)
                {
                    estado = true;
                    //label3.Text = estado.ToString();
                }

                if (rbtNao.Checked == true)
                {
                    estado = false;

                    //label3.Text =estado.ToString();

                }

                categoria.Nome = txtNome.Text;
                categoria.Ativo = estado;

               // restGest.Categoria.Add(categoria);
                restGest.SaveChanges();

            }


        }

        public void ler_dados() 
        {

            int i = 0;
            // query para dar join das duas tabelas e as juntar os campos de ambas
            var tabela =
                     from dados in restGest.Categoria
                     select new
                     {
                         idCat=dados.Id,
                         nomeCat = dados.Nome,
                         estadoDV=dados.Ativo
                     };
           
            MessageBox.Show(tabela.Count().ToString());
          //  Array arr = tabela.ToArray();
            foreach (var cat in tabela)
            {
                dgvCategorias.Rows.Add();

                dgvCategorias.Rows[i].Cells["ID"].Value = cat.idCat;
                dgvCategorias.Rows[i].Cells["Categoria"].Value = cat.nomeCat;
                dgvCategorias.Rows[i].Cells["Estado"].Value = cat.estadoDV;
           

                i++;
            }
        }

 

        private void dgvCategorias_DoubleClick(object sender, EventArgs e)
        {
            string aux = "";
            
            if (dgvCategorias.CurrentRow.Index != 1)
            {
                int row = dgvCategorias.CurrentRow.Index;

                txtID.Text = dgvCategorias.Rows[row].Cells["ID"].Value.ToString();
                txtNome.Text = dgvCategorias.Rows[row].Cells["Categoria"].Value.ToString();
                aux = dgvCategorias.Rows[row].Cells["Estado"].Value.ToString();


                if (aux == "True")
                {
                    rbtSim.Checked = true;

                }
                if(aux=="False")
                {
                    rbtNao.Checked = true;

                }

            }
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            ler_dados();
        }
    }
}
