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
    public partial class frmCadServicos : Form
    {
        public frmCadServicos()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.servicoBindingSource.EndEdit();
                servicoTableAdapter.Update(petshopDataSet.servico);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique as informações!");

            }

        }

        private void frmCadServicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.petshopDataSet.servico);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            servicoBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            servicoBindingSource.CancelEdit();
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
                    servicoBindingSource.RemoveCurrent(); // Remove o registro
                    servicoTableAdapter.Update(petshopDataSet.servico); // Salva
                }
            }
            catch (Exception)
            {
                servicoTableAdapter.Fill(petshopDataSet.servico);
                MessageBox.Show("Registro não pode ser excluído!");
                groupBox1.Enabled = false;

            }
        }

        private void serv_codigoLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
