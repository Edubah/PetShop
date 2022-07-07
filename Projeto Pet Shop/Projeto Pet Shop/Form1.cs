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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCadClientes Clientes = new frmCadClientes(); //Formulário Instanciado
            Clientes.TopLevel = false; //Para que este não fique acima dos formulários
            Clientes.Dock = DockStyle.Fill; //Fará o formulário preencher o PANEL Central
            panelCentral.Controls.Clear(); //Limpa o Panel antes
            panelCentral.Controls.Add(Clientes); //Mostra o formulário no PANE CENTRAL
            Clientes.Show(); //Manda ele aparecer

            //Aplica a posição do eixo X do botão ao panelSelecao
            panelSelecao.Top = btnClientes.Top;

        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            frmCadAnimais Animais = new frmCadAnimais();
            Animais.TopLevel = false;
            Animais.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(Animais);
            Animais.Show();

            panelSelecao.Top = btnAnimais.Top;
        }

        private void btnRaca_Click(object sender, EventArgs e)
        {
            frmCadRacas Raca = new frmCadRacas();
            Raca.TopLevel = false;
            Raca.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(Raca);
            Raca.Show();

            panelSelecao.Top = btnRacas.Top; 
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            frmCadServicos Servicos = new frmCadServicos();
            Servicos.TopLevel = false;
            Servicos.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(Servicos);
            Servicos.Show();

            panelSelecao.Top = btnServicos.Top;
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            frmCadAgendamentos Agendamentos = new frmCadAgendamentos();
            Agendamentos.TopLevel = false;
            Agendamentos.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(Agendamentos);
            Agendamentos.Show();

            panelSelecao.Top = btnAgendamentos.Top;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //MessageBox = Caixa de Mensagem; MessageBoxButtons = Botões (Sim/Não); MessageBoxicons = Ícone da Mensagem
            if (MessageBox.Show("Deseja mesmo sair?","PetShop", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Fechar
                Application.Exit();
            }
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear();
            panelSelecao.Top = btnInicio.Top;
        }
    }
}
