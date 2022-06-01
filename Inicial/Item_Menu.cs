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
        }
    }
}
