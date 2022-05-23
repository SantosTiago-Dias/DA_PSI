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

        }

        public void ler_dados()
        {
            dgRestaurante.DataSource = restGest.Morada.ToList<Morada>();
        }

        private void dgRestaurante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
