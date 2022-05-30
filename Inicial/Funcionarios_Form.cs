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
            int tele=Convert.ToInt32(txtTelemovel.Text);
            if (txtTelemovel.Text.Length == 9)
            {
                string salario= txtSalario.Text;
                Morada morada = new Morada();

                morada.Rua = txtRuaFunc.Text;
                morada.Cidade = txtCidadeFunc.Text;
                morada.Cod_Postal = txtCodPostalFunc.Text;

                Pessoa pessoa = new Pessoa();
                Trabalhador trabalhador = new Trabalhador();
                trabalhador.Nome = txtNomeFunc.Text;
                trabalhador.Posicao = txtPosicaoFunc.Text;
                trabalhador.RestauranteId = Convert.ToInt32(lblId.Text);
                trabalhador.Telemovel = Convert.ToInt32(txtTelemovel.Text);
                trabalhador.Salario = Convert.ToDecimal(salario.Replace('.',','));
                
                restGest.Pessoa.Add(trabalhador);

                restGest.SaveChanges();
   
            }


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

        private void dgFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ler_dados()
        {
            dgFuncionario.Rows.Clear();// limpa a tabela 
            dgFuncionario.Refresh();// da refresh a tabela
            int i = 0;

            var query=(from)
            // query para dar join das duas tabelas e as juntar os campos de ambas
            var query = (
                     from Pessoa in restGest.Pessoa
                     join Trabalhador in restGest.Pessoa on Pessoa.Id equals Trabalhador.Id
                     join Morada in restGest.Morada on Trabalhador.MoradaId equals Morada.Id
                     join Restaurante in restGest.Restaurante on Trabalhador.Restaurante.id
                     select new { id = Trabalhador.Id, Nome = Pessoa.Nome, Tele = Pessoa.Telemovel,nome_restaurante=}).ToList();
            //foreach para percorrer os campos do query
            foreach (var res in query)
            {
                dgFuncionario.Rows.Add();
                dgFuncionario.Rows[i].Cells["ID"].Value = res.id;
                dgFuncionario.Rows[i].Cells["nome_Funcinario"].Value = res.Nome;
                dgFuncionario.Rows[i].Cells["tele"].Value = res.Tele;
                dgFuncionario.Rows[i].Cells["morada"].Value = res.Rua;
                
                i++;
            }

        }
    }
}
