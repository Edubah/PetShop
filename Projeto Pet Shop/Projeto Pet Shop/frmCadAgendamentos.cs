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
    public partial class frmCadAgendamentos : Form
    {
        public frmCadAgendamentos()
        {
            InitializeComponent();
        }

        private void frmCadAgendamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.View_ServicosAgendamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.view_ServicosAgendamentosTableAdapter.Fill(this.petshopDataSet.View_ServicosAgendamentos);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.petshopDataSet.animal);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.agendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.agendamentoTableAdapter.Fill(this.petshopDataSet.agendamento);

        }

        private void ag_dataLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            agendamentoBindingSource.AddNew();
            ag_situacaoComboBox.Text = "Agendado";
            ag_dataMaskedTextBox.Text = DateTime.Now.ToShortDateString();
            ag_horarioMaskedTextBox.Text = DateTime.Now.ToShortTimeString();
            ag_totalTextBox.Text = "00.0";
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            agendamentoBindingSource.CancelEdit();
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
                    agendamentoBindingSource.RemoveCurrent(); // Remove o registro
                    agendamentoTableAdapter.Update(petshopDataSet.agendamento); // Salva
                }
            }
            catch (Exception)
            {
                agendamentoTableAdapter.Fill(petshopDataSet.agendamento);
                MessageBox.Show("Registro não pode ser excluído!");
                groupBox1.Enabled = false;

            }
        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.agendamentoBindingSource.EndEdit();
                agendamentoTableAdapter.Update(petshopDataSet.agendamento);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique as informações!");

            }
        }

       
    }
}
