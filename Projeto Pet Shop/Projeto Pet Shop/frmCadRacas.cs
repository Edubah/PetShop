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
    public partial class frmCadRacas : Form
    {
        public frmCadRacas()
        {
            InitializeComponent();
        }


        private void racaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.racaBindingSource.EndEdit();
                racaTableAdapter.Update(petshopDataSet.raca);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique as informações!");

            }

        }

        private void frmCadRacas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.petshopDataSet.raca);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            racaBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a exclusão do registro?", "Pet Shop",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    racaBindingSource.RemoveCurrent(); // Remove o registro
                    racaTableAdapter.Update(petshopDataSet.raca); // Salva
                    groupBox1.Enabled = false;
                }
            }
            catch (Exception)
            {
                racaTableAdapter.Fill(petshopDataSet.raca);
                MessageBox.Show("Registro não pode ser excluído!");
                groupBox1.Enabled = false;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            racaBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void raca_codigoLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
