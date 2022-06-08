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
    public partial class Item_Menu : Form
    {
        public RestGestContainer restGest;
        public Item_Menu()
        {
            InitializeComponent();
            restGest = new RestGestContainer();
        }

        private void Item_Menu_Load(object sender, EventArgs e)
        {
            Restaurante restaurante = restGest.Restaurante.Find(Restaurante_From.id);
            lblRestaurante.Text = restaurante.Nome;

            List<Categoria> categoria = restGest.Categoria.ToList();

            foreach (var item in categoria)
            {
                if (item.Ativo == true)
                {
                    cmbCategoria.Items.Add(item);
                }
                
            }
            cmbCategoria.SelectedIndex = -1;
            //lblId.Text = id_restaurante.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtIngredientes.Text != "" && txtPreco.Text!="")
            {
                Categoria cat= (Categoria)cmbCategoria.SelectedItem;
                bool preco = decimal.TryParse(txtPreco.Text.Replace('.', ','), out decimal valor);
                if (preco == true)
                {
                    ItemMenu ItemMenu = new ItemMenu();
                    ItemMenu.Nome = txtNome.Text;
                    ItemMenu.Ingredientes = txtIngredientes.Text;
                    ItemMenu.Preco = valor;
                    ItemMenu.Fotografia = txtfotografia.Text;
                    ItemMenu.CategoriaId = cat.Id;
                    
                          
                    /*MessageBox.Show(cat.Id.ToString());*/
                }
                else
                {
                    MessageBox.Show("Insira dados Validos");
                }
            }
            

        }
    }
}
