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
    public partial class Funcionarios_Form : Form
    {
        public RestGestContainer restGest;
        public Funcionarios_Form()
        {
            InitializeComponent();
            restGest = new RestGestContainer();
        }

        private void btnaddFunc_Click(object sender, EventArgs e)
        {
            Morada morada = new Morada();

            morada.Rua = txtRuaFunc.Text;
            morada.Cidade = txtCidadeFunc.Text;
            morada.Cod_Postal = txtCodPostalFunc.Text;

            restGest.Morada.Add(morada);
            restGest.SaveChanges();

            /*Restaurante restaurante = new Restaurante();
            restaurante.Nome = txtNome.Text;
            restaurante.MoradaId = morada.Id;

            restGest.Restaurante.Add(restaurante);
            restGest.SaveChanges();



            restaurante.Nome = txtNome.Text;
            morada.Rua = txtRua.Text;
            morada.Cidade = txtCidade.Text;
            morada.Cod_Postal = txtCodPostal.Text;
            restGest.SaveChanges();*/
        }

        private void Funcionarios_Form_Load(object sender, EventArgs e)
        {
            int id_restaurante = Convert.ToInt32(Restaurante_From.id_restaurante);
            string nome_restaurante = (from Restaurante in restGest.Restaurante
                           where Restaurante.Id == id_restaurante
                           select Restaurante.Nome).First().ToString();
            
            lblNomeRestaurante.Text = nome_restaurante.ToString();
            lblId.Text = id_restaurante.ToString();
        }
    }
}
