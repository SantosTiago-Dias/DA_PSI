using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inicial
{
    public partial class Item_Menu : Form
    {


        string path = @"C:\Users\tiago\Desktop\Ipl_Escola\Desenvolvimento de aplicações-C#\Trabalho DA v2\Inicial\images"; //caminho
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
            lerdados();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtNome.Text != "" && txtIngredientes.Text != "" && txtPreco.Text!="" && pictureBox.Image != null)
            {
                Categoria cat= (Categoria)cmbCategoria.SelectedItem;
                bool preco = decimal.TryParse(txtPreco.Text.Replace('.', ','), out decimal valor);
                if (preco == true && cat !=null)
                {
                    File.Copy(lblFileName.Text, Path.Combine(path, Path.GetFileName(lblFileName.Text)), true);
                    if (txtID.Text=="")
                    {
                        //File.Copy(lblFileName.Text, Path.Combine(path, Path.GetFileName(lblFileName.Text)), true);
                       

                        ItemMenu itemMenu = new ItemMenu();
                        Restaurante restaurante = restGest.Restaurante.Find(Restaurante_From.id);
                        itemMenu.Nome = txtNome.Text;
                        itemMenu.Ingredientes = txtIngredientes.Text;
                        itemMenu.Preco = valor;
                        itemMenu.Fotografia = Path.Combine(path, Path.GetFileName(lblFileName.Text));
                        itemMenu.CategoriaId = cat.Id;
                        itemMenu.Restaurante.Add(restaurante);
                        restGest.ItemMenu.Add(itemMenu);
                        restGest.SaveChanges();
                    }
                    else
                    {
                        //Editar Restaurante
                        int id = Convert.ToInt32(txtID.Text);
                        ItemMenu itemMenu = restGest.ItemMenu.Find(id);

                        itemMenu.Nome = txtNome.Text;
                        itemMenu.Ingredientes = txtIngredientes.Text;
                        itemMenu.Preco = valor;
                        itemMenu.Fotografia = Path.Combine(path, Path.GetFileName(lblFileName.Text));
                        itemMenu.CategoriaId = cat.Id;
                        

                        restGest.SaveChanges();
                        
                        limpar_txt();
                       
                      
                    }
                    
                }
                else
                {
                    MessageBox.Show("Insira dados Validos");
                }
            }
            else
            {
                MessageBox.Show("Insira os dados todos sff(não se esqueça de inserir a imagem)");
            }
            lerdados();
            

        }
        
        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            //abrir o menu para escolher as imagens
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Tipo Imagem(*.jpg;*.png)|*.jpg;*.png";
            
            if(ofd.ShowDialog()== DialogResult.OK)
                {
                    lblFileName.Text = ofd.FileName;
                    pictureBox.Image = new Bitmap(ofd.FileName);
                }
            
        }

        public void lerdados()
        {
           
            dgItemMenu.Rows.Clear();// limpa a tabela 
            dgItemMenu.Refresh();// da refresh a tabela
            int i = 0;
            Restaurante restaurante = restGest.Restaurante.Find(Restaurante_From.id);
            //ir buscar o id do restaurante para depois comparar
            List<ItemMenu> itemmenu = restGest.ItemMenu.ToList();
            //foreach para percorrer os campos
            foreach (var res in itemmenu)
            {
                if (res.Restaurante.Contains(restaurante) == true)
                {
                    dgItemMenu.Rows.Add();
                    dgItemMenu.Rows[i].Cells["id"].Value = res.Id;
                    dgItemMenu.Rows[i].Cells["name"].Value = res.Nome;
                    dgItemMenu.Rows[i].Cells["ingredientes"].Value = res.Ingredientes;
                    dgItemMenu.Rows[i].Cells["preco"].Value = res.Preco;
                    dgItemMenu.Rows[i].Cells["categoria"].Value = res.Categoria;

                    
                    i++;
                }
                
            }
   
        }

        public void limpar_txt()
        {
            txtNome.Text = "";
            txtPreco.Text = "";
            txtIngredientes.Text = "";
            pictureBox.Image = null;
        }

        private void dgItemMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            limpar_txt();
            btnAdd.Text = "Editar Prato";
            int row = dgItemMenu.CurrentRow.Index;
            int id = Convert.ToInt32(dgItemMenu.Rows[row].Cells["id"].Value);
            ItemMenu itemMenu = restGest.ItemMenu.Find(id);
            txtNome.Text = dgItemMenu.Rows[row].Cells["name"].Value.ToString();
            txtIngredientes.Text = dgItemMenu.Rows[row].Cells["ingredientes"].Value.ToString();
            txtPreco.Text= dgItemMenu.Rows[row].Cells["preco"].Value.ToString();
            cmbCategoria.SelectedItem = dgItemMenu.Rows[row].Cells["categoria"].Value.ToString();
            txtID.Text = id.ToString();
            lblFileName.Text = itemMenu.Fotografia.ToString();
            pictureBox.Image = Image.FromFile(itemMenu.Fotografia);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                DialogResult resposta = MessageBox.Show("Deseja eliminar o prato?", "Pergunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtID.Text);
                    ItemMenu itemMenu = restGest.ItemMenu.Find(id);
                    Restaurante restaurante = restGest.Restaurante.Find(Restaurante_From.id);
                    itemMenu.Restaurante.Remove(restaurante);
                    restGest.ItemMenu.Remove(itemMenu);
                    restGest.SaveChanges();
                    limpar_txt();
                    
                }
            }
            lerdados();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
