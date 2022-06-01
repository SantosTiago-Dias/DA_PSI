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
    public partial class ItemMenu_Form : Form
    {
        public RestGestContainer restGest;
        public ItemMenu_Form()
        {
            InitializeComponent();
            restGest = new RestGestContainer();
        }

        private void ItemMenu_Form_Load(object sender, EventArgs e)
        {
            Restaurante restaurante = restGest.Restaurante.Find(Restaurante_From.id_rest);
            //recebe o id que vem do outro form
            lblNomeRest.Text = restaurante.Nome;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            
            ItemMenu itemMenu = new ItemMenu();

            itemMenu.Nome = txtNomePrato.Text;
            itemMenu.Ingredientes = txtIngredientes.Text;
            itemMenu.Preco= Convert.ToDecimal(txtPreco.Text.Replace('.', ','));

        }
    }
}
