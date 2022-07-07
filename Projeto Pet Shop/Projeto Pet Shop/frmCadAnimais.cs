using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Pet_Shop
{
    public partial class frmCadAnimais : Form
    {
        public frmCadAnimais()
        {
            InitializeComponent();
        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                animalTableAdapter.Update(petshopDataSet.animal);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique as informações!");

            }

        }

        private void frmCadAnimais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.petshopDataSet.raca);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.petshopDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.petshopDataSet.animal);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            animalBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            animalBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a exclusão do registro?", "Pet Shop",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    animalBindingSource.RemoveCurrent(); // Remove o registro
                    animalTableAdapter.Update(petshopDataSet.animal); // Salva
                }
            }
            catch (Exception)
            {
                animalTableAdapter.Fill(petshopDataSet.animal);
                MessageBox.Show("Registro não pode ser excluído!");
                groupBox1.Enabled = false;

            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                //Filtro do FileDialog
                openFileDialog1.Filter = "Imagens (*.jpg; *.png;) | *.jpg; *.png";

                //Openfiledialog é uma função para chamar a caixa de diálogo ou de seleção de arquivos
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ani_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao carregar o arquivo de imagem",
                    "Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ani_fotoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
