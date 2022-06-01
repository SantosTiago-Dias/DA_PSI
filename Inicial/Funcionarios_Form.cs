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
                if (lblIdFunc.Text == "")
                {
                    string salario = txtSalario.Text;
                    Morada morada = new Morada();

                    morada.Rua = txtRuaFunc.Text;
                    morada.Cidade = txtCidadeFunc.Text;
                    morada.Cod_Postal = txtCodPostalFunc.Text;

                    restGest.Morada.Add(morada);
                    restGest.SaveChanges();

                    Trabalhador trabalhador = new Trabalhador();
                    trabalhador.Nome = txtNomeFunc.Text;
                    trabalhador.Posicao = txtPosicaoFunc.Text;
                    trabalhador.RestauranteId = Convert.ToInt32(lblId.Text);
                    trabalhador.Telemovel = Convert.ToInt32(txtTelemovel.Text);
                    trabalhador.Salario = Convert.ToDecimal(salario.Replace('.', ','));
                   

                    restGest.Pessoa.Add(trabalhador);

                    restGest.SaveChanges();
                    
                }
                else
                {
                    string salario = txtSalario.Text;
                    Morada morada = restGest.Morada.Find(Convert.ToInt32(lblIdMorada.Text));
                    Trabalhador trabalhador = (Trabalhador)restGest.Pessoa.Find(Convert.ToInt32(lblIdFunc.Text));
                    morada.Rua = txtRuaFunc.Text;
                    morada.Cidade = txtCidadeFunc.Text;
                    morada.Cod_Postal = txtCodPostalFunc.Text;
                    trabalhador.Nome = txtNomeFunc.Text;
                    trabalhador.Posicao = txtPosicaoFunc.Text;
                    trabalhador.RestauranteId = Convert.ToInt32(lblId.Text);
                    trabalhador.Telemovel = Convert.ToInt32(txtTelemovel.Text);
                    trabalhador.Salario = Convert.ToDecimal(salario.Replace('.', ','));
                    trabalhador.MoradaId = morada.Id;

                    restGest.SaveChanges();
                }

                limpar_txt();
                ler_dados();

            }
            else
            {
                MessageBox.Show("Insira os valores corretos");
            }
            
        }

        private void Funcionarios_Form_Load(object sender, EventArgs e)
        {
            
            List<Restaurante> restaurante = restGest.Restaurante.ToList();

            foreach (var item in restaurante)
            {
                cmbRest.Items.Add(item.Nome);
            }
            cmbRest.SelectedIndex = -1;
            //lblId.Text = id_restaurante.ToString();
            ler_dados();
        }

        private void dgFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            limpar_txt();
            btnaddFunc.Text = "Editar Funcionario";
            int row = dgFuncionario.CurrentRow.Index;
            lblIdFunc.Text = dgFuncionario.Rows[row].Cells["ID"].Value.ToString();
            txtNomeFunc.Text = dgFuncionario.Rows[row].Cells["nome_Funcinario"].Value.ToString();
            txtTelemovel.Text = dgFuncionario.Rows[row].Cells["tele"].Value.ToString();
            txtPosicaoFunc.Text = dgFuncionario.Rows[row].Cells["posicao"].Value.ToString();
            txtSalario.Text= dgFuncionario.Rows[row].Cells["salario"].Value.ToString();
            cmbRest.SelectedItem= dgFuncionario.Rows[row].Cells["nome_restaurante"].Value.ToString();
            txtCidadeFunc.Text = dgFuncionario.Rows[row].Cells["cidade"].Value.ToString();
            txtCodPostalFunc.Text= dgFuncionario.Rows[row].Cells["cod_Postal"].Value.ToString();
            txtRuaFunc.Text = dgFuncionario.Rows[row].Cells["rua"].Value.ToString();
            lblId.Text= dgFuncionario.Rows[row].Cells["id_Rest"].Value.ToString();
            lblIdMorada.Text= dgFuncionario.Rows[row].Cells["id_morada"].Value.ToString();
        }

        public void ler_dados()
        {
            dgFuncionario.Rows.Clear();// limpa a tabela 
            dgFuncionario.Refresh();// da refresh a tabela
            int i = 0;

            var trabalhadores = restGest.Pessoa.OfType<Trabalhador>();
            
            //foreach para percorrer os campos
            foreach (var res in trabalhadores)
            {
                dgFuncionario.Rows.Add();
                dgFuncionario.Rows[i].Cells["ID"].Value = res.Id;
                dgFuncionario.Rows[i].Cells["nome_Funcinario"].Value = res.Nome;
                dgFuncionario.Rows[i].Cells["tele"].Value = res.Telemovel;
                dgFuncionario.Rows[i].Cells["posicao"].Value = res.Posicao;
                dgFuncionario.Rows[i].Cells["salario"].Value = res.Salario;
                dgFuncionario.Rows[i].Cells["nome_restaurante"].Value = res.Restaurante.Nome;
                dgFuncionario.Rows[i].Cells["cidade"].Value = res.Morada.Cidade;
                dgFuncionario.Rows[i].Cells["cod_Postal"].Value = res.Morada.Cod_Postal;
                dgFuncionario.Rows[i].Cells["rua"].Value = res.Morada.Rua;
                dgFuncionario.Rows[i].Cells["id_Rest"].Value = res.RestauranteId;
                dgFuncionario.Rows[i].Cells["id_morada"].Value = res.MoradaId;

                i++;
            }

        }

        private void cmbRest_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblId.Text = (cmbRest.SelectedIndex+1).ToString();
            
        }
         
        private void limpar_txt()
        {
            txtCidadeFunc.Clear();
            txtCodPostalFunc.Clear();
            txtNomeFunc.Clear();
            txtPosicaoFunc.Clear();
            txtRuaFunc.Clear();
            txtSalario.Clear();
            txtTelemovel.Clear();
            lblId.Text = "";
            lblIdFunc.Text = "";
            lblIdMorada.Text = "";
            cmbRest.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar_txt();
            btnaddFunc.Text = "Adicionar Funcionario";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lblIdFunc.Text != "")
            {
                DialogResult resposta = MessageBox.Show("Deseja eliminar o Trabalhador?", "Pergunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblIdFunc.Text);
                    Trabalhador trabalhador = (Trabalhador)restGest.Pessoa.Find(id);
                    Morada morada = restGest.Morada.Find(trabalhador.MoradaId);

                    restGest.Morada.Remove(morada);
                    restGest.Pessoa.Remove(trabalhador);
                    restGest.SaveChanges();
                    limpar_txt();
                    ler_dados();
                }
            }
        }
    }
}
