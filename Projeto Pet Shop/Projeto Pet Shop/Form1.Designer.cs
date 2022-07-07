namespace Projeto_Pet_Shop
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelSelecao = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAgendamentos = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnAnimais = new System.Windows.Forms.Button();
            this.btnRacas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.RosyBrown;
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Controls.Add(this.btnMaximizar);
            this.panelSuperior.Controls.Add(this.btnFechar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1070, 46);
            this.panelSuperior.TabIndex = 0;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.MistyRose;
            this.panelLateral.Controls.Add(this.panelSelecao);
            this.panelLateral.Controls.Add(this.btnInicio);
            this.panelLateral.Controls.Add(this.btnAgendamentos);
            this.panelLateral.Controls.Add(this.btnServicos);
            this.panelLateral.Controls.Add(this.btnAnimais);
            this.panelLateral.Controls.Add(this.btnRacas);
            this.panelLateral.Controls.Add(this.btnClientes);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 46);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(2);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(202, 682);
            this.panelLateral.TabIndex = 1;
            // 
            // panelSelecao
            // 
            this.panelSelecao.BackColor = System.Drawing.Color.Salmon;
            this.panelSelecao.Location = new System.Drawing.Point(173, 43);
            this.panelSelecao.Name = "panelSelecao";
            this.panelSelecao.Size = new System.Drawing.Size(13, 57);
            this.panelSelecao.TabIndex = 6;
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Location = new System.Drawing.Point(10, 43);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(155, 57);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAgendamentos
            // 
            this.btnAgendamentos.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamentos.Location = new System.Drawing.Point(10, 397);
            this.btnAgendamentos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgendamentos.Name = "btnAgendamentos";
            this.btnAgendamentos.Size = new System.Drawing.Size(155, 57);
            this.btnAgendamentos.TabIndex = 4;
            this.btnAgendamentos.Text = "Agendamentos";
            this.btnAgendamentos.UseVisualStyleBackColor = true;
            this.btnAgendamentos.Click += new System.EventHandler(this.btnAgendamentos_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Location = new System.Drawing.Point(10, 326);
            this.btnServicos.Margin = new System.Windows.Forms.Padding(2);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(155, 57);
            this.btnServicos.TabIndex = 3;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnAnimais
            // 
            this.btnAnimais.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimais.Location = new System.Drawing.Point(10, 254);
            this.btnAnimais.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Size = new System.Drawing.Size(155, 57);
            this.btnAnimais.TabIndex = 2;
            this.btnAnimais.Text = "Animais";
            this.btnAnimais.UseVisualStyleBackColor = true;
            this.btnAnimais.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnRacas
            // 
            this.btnRacas.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnRacas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRacas.Location = new System.Drawing.Point(10, 182);
            this.btnRacas.Margin = new System.Windows.Forms.Padding(2);
            this.btnRacas.Name = "btnRacas";
            this.btnRacas.Size = new System.Drawing.Size(155, 57);
            this.btnRacas.TabIndex = 1;
            this.btnRacas.Text = "Raças";
            this.btnRacas.UseVisualStyleBackColor = true;
            this.btnRacas.Click += new System.EventHandler(this.btnRaca_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(10, 111);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(155, 57);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.AutoSize = true;
            this.panelCentral.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelCentral.BackgroundImage = global::Projeto_Pet_Shop.Properties.Resources.Pet_Shop_Pata_de_Gato_Moderno_Logotipo;
            this.panelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCentral.Location = new System.Drawing.Point(202, 46);
            this.panelCentral.Margin = new System.Windows.Forms.Padding(2);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(868, 682);
            this.panelCentral.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = global::Projeto_Pet_Shop.Properties.Resources.Minimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(955, 9);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 27);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackgroundImage = global::Projeto_Pet_Shop.Properties.Resources.Maximizar;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(995, 10);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(38, 27);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::Projeto_Pet_Shop.Properties.Resources.Fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1039, 10);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 26);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 728);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelSuperior);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSuperior.ResumeLayout(false);
            this.panelLateral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnAgendamentos;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnAnimais;
        private System.Windows.Forms.Button btnRacas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panelSelecao;
    }
}

