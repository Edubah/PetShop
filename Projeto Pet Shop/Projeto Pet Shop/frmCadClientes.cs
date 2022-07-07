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
    public partial class frmCadClientes : Form
    {
        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(petshopDataSet.cliente);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique as informações!");
                
            }

        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.petshopDataSet.cliente);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
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
                    clienteBindingSource.RemoveCurrent(); // Remove o registro
                    clienteTableAdapter.Update(petshopDataSet.cliente); // Salva
                }
            }
            catch (Exception)
            {
                clienteTableAdapter.Fill(petshopDataSet.cliente);
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
                    cli_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao carregar o arquivo de imagem",
                    "Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
