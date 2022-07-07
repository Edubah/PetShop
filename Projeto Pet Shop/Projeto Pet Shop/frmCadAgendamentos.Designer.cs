namespace Projeto_Pet_Shop
{
    partial class frmCadAgendamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ag_codigoLabel;
            System.Windows.Forms.Label ag_dataLabel;
            System.Windows.Forms.Label ag_horarioLabel;
            System.Windows.Forms.Label ag_situacaoLabel;
            System.Windows.Forms.Label ag_animalLabel;
            System.Windows.Forms.Label ag_totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadAgendamentos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ag_codigoTextBox = new System.Windows.Forms.TextBox();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petshopDataSet = new Projeto_Pet_Shop.petshopDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ag_horarioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ag_dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ag_situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.ag_animalComboBox = new System.Windows.Forms.ComboBox();
            this.ag_totalTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.view_ServicosAgendamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoTableAdapter = new Projeto_Pet_Shop.petshopDataSetTableAdapters.agendamentoTableAdapter();
            this.tableAdapterManager = new Projeto_Pet_Shop.petshopDataSetTableAdapters.TableAdapterManager();
            this.animalTableAdapter = new Projeto_Pet_Shop.petshopDataSetTableAdapters.animalTableAdapter();
            this.animalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.animalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            ag_codigoLabel = new System.Windows.Forms.Label();
            ag_dataLabel = new System.Windows.Forms.Label();
            ag_horarioLabel = new System.Windows.Forms.Label();
            ag_situacaoLabel = new System.Windows.Forms.Label();
            ag_animalLabel = new System.Windows.Forms.Label();
            ag_totalLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicosAgendamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).BeginInit();
            this.animalBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ag_codigoLabel
            // 
            ag_codigoLabel.AutoSize = true;
            ag_codigoLabel.Location = new System.Drawing.Point(15, 36);
            ag_codigoLabel.Name = "ag_codigoLabel";
            ag_codigoLabel.Size = new System.Drawing.Size(111, 22);
            ag_codigoLabel.TabIndex = 0;
            ag_codigoLabel.Text = "ag codigo:";
            // 
            // ag_dataLabel
            // 
            ag_dataLabel.AutoSize = true;
            ag_dataLabel.Location = new System.Drawing.Point(154, 36);
            ag_dataLabel.Name = "ag_dataLabel";
            ag_dataLabel.Size = new System.Drawing.Size(92, 22);
            ag_dataLabel.TabIndex = 2;
            ag_dataLabel.Text = "ag data:";
            ag_dataLabel.Click += new System.EventHandler(this.ag_dataLabel_Click);
            // 
            // ag_horarioLabel
            // 
            ag_horarioLabel.AutoSize = true;
            ag_horarioLabel.Location = new System.Drawing.Point(282, 36);
            ag_horarioLabel.Name = "ag_horarioLabel";
            ag_horarioLabel.Size = new System.Drawing.Size(110, 22);
            ag_horarioLabel.TabIndex = 4;
            ag_horarioLabel.Text = "ag horario:";
            // 
            // ag_situacaoLabel
            // 
            ag_situacaoLabel.AutoSize = true;
            ag_situacaoLabel.Location = new System.Drawing.Point(434, 36);
            ag_situacaoLabel.Name = "ag_situacaoLabel";
            ag_situacaoLabel.Size = new System.Drawing.Size(125, 22);
            ag_situacaoLabel.TabIndex = 6;
            ag_situacaoLabel.Text = "ag situacao:";
            // 
            // ag_animalLabel
            // 
            ag_animalLabel.AutoSize = true;
            ag_animalLabel.Location = new System.Drawing.Point(15, 146);
            ag_animalLabel.Name = "ag_animalLabel";
            ag_animalLabel.Size = new System.Drawing.Size(107, 22);
            ag_animalLabel.TabIndex = 8;
            ag_animalLabel.Text = "ag animal:";
            // 
            // ag_totalLabel
            // 
            ag_totalLabel.AutoSize = true;
            ag_totalLabel.Location = new System.Drawing.Point(695, 36);
            ag_totalLabel.Name = "ag_totalLabel";
            ag_totalLabel.Size = new System.Drawing.Size(88, 22);
            ag_totalLabel.TabIndex = 10;
            ag_totalLabel.Text = "ag total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ag_codigoTextBox);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.ag_horarioMaskedTextBox);
            this.groupBox1.Controls.Add(ag_codigoLabel);
            this.groupBox1.Controls.Add(ag_dataLabel);
            this.groupBox1.Controls.Add(this.ag_dataMaskedTextBox);
            this.groupBox1.Controls.Add(ag_horarioLabel);
            this.groupBox1.Controls.Add(ag_situacaoLabel);
            this.groupBox1.Controls.Add(this.ag_situacaoComboBox);
            this.groupBox1.Controls.Add(ag_animalLabel);
            this.groupBox1.Controls.Add(this.ag_animalComboBox);
            this.groupBox1.Controls.Add(ag_totalLabel);
            this.groupBox1.Controls.Add(this.ag_totalTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados dos Agendamentos";
            // 
            // ag_codigoTextBox
            // 
            this.ag_codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_codigo", true));
            this.ag_codigoTextBox.Location = new System.Drawing.Point(19, 73);
            this.ag_codigoTextBox.Name = "ag_codigoTextBox";
            this.ag_codigoTextBox.Size = new System.Drawing.Size(100, 31);
            this.ag_codigoTextBox.TabIndex = 14;
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataMember = "agendamento";
            this.agendamentoBindingSource.DataSource = this.petshopDataSet;
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.animalBindingSource, "ani_foto", true));
            this.pictureBox1.Location = new System.Drawing.Point(588, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.petshopDataSet;
            // 
            // ag_horarioMaskedTextBox
            // 
            this.ag_horarioMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_horario", true));
            this.ag_horarioMaskedTextBox.Location = new System.Drawing.Point(286, 73);
            this.ag_horarioMaskedTextBox.Mask = "00:00";
            this.ag_horarioMaskedTextBox.Name = "ag_horarioMaskedTextBox";
            this.ag_horarioMaskedTextBox.Size = new System.Drawing.Size(121, 31);
            this.ag_horarioMaskedTextBox.TabIndex = 13;
            this.ag_horarioMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // ag_dataMaskedTextBox
            // 
            this.ag_dataMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_data", true));
            this.ag_dataMaskedTextBox.Location = new System.Drawing.Point(140, 73);
            this.ag_dataMaskedTextBox.Mask = "99/99/9999";
            this.ag_dataMaskedTextBox.Name = "ag_dataMaskedTextBox";
            this.ag_dataMaskedTextBox.Size = new System.Drawing.Size(121, 31);
            this.ag_dataMaskedTextBox.TabIndex = 3;
            // 
            // ag_situacaoComboBox
            // 
            this.ag_situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_situacao", true));
            this.ag_situacaoComboBox.FormattingEnabled = true;
            this.ag_situacaoComboBox.Items.AddRange(new object[] {
            "Agendado",
            "Em Andamento",
            "Finalizado"});
            this.ag_situacaoComboBox.Location = new System.Drawing.Point(438, 73);
            this.ag_situacaoComboBox.Name = "ag_situacaoComboBox";
            this.ag_situacaoComboBox.Size = new System.Drawing.Size(229, 30);
            this.ag_situacaoComboBox.TabIndex = 7;
            // 
            // ag_animalComboBox
            // 
            this.ag_animalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agendamentoBindingSource, "ag_animal", true));
            this.ag_animalComboBox.DataSource = this.animalBindingSource;
            this.ag_animalComboBox.DisplayMember = "ani_nome";
            this.ag_animalComboBox.FormattingEnabled = true;
            this.ag_animalComboBox.Location = new System.Drawing.Point(19, 192);
            this.ag_animalComboBox.Name = "ag_animalComboBox";
            this.ag_animalComboBox.Size = new System.Drawing.Size(508, 30);
            this.ag_animalComboBox.TabIndex = 9;
            this.ag_animalComboBox.ValueMember = "ani_codigo";
            // 
            // ag_totalTextBox
            // 
            this.ag_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_total", true));
            this.ag_totalTextBox.Location = new System.Drawing.Point(699, 73);
            this.ag_totalTextBox.Name = "ag_totalTextBox";
            this.ag_totalTextBox.Size = new System.Drawing.Size(121, 31);
            this.ag_totalTextBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 362);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços";
            // 
            // view_ServicosAgendamentosBindingSource
            // 
            this.view_ServicosAgendamentosBindingSource.DataMember = "View_ServicosAgendamentos";
            this.view_ServicosAgendamentosBindingSource.DataSource = this.petshopDataSet;
            // 
            // agendamentoTableAdapter
            // 
            this.agendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = this.agendamentoTableAdapter;
            this.tableAdapterManager.animalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_Pet_Shop.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // animalBindingNavigator
            // 
            this.animalBindingNavigator.AddNewItem = null;
            this.animalBindingNavigator.BindingSource = this.agendamentoBindingSource;
            this.animalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.animalBindingNavigator.DeleteItem = null;
            this.animalBindingNavigator.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.animalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.animalBindingNavigatorSaveItem,
            this.btnCancelar,
            this.btnEditar});
            this.animalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.animalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.animalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animalBindingNavigator.Name = "animalBindingNavigator";
            this.animalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animalBindingNavigator.Size = new System.Drawing.Size(868, 42);
            this.animalBindingNavigator.TabIndex = 2;
            this.animalBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 39);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(39, 39);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(39, 39);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(39, 39);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(39, 39);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(127, 39);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(81, 39);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // animalBindingNavigatorSaveItem
            // 
            this.animalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("animalBindingNavigatorSaveItem.Image")));
            this.animalBindingNavigatorSaveItem.Name = "animalBindingNavigatorSaveItem";
            this.animalBindingNavigatorSaveItem.Size = new System.Drawing.Size(113, 39);
            this.animalBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.animalBindingNavigatorSaveItem.Click += new System.EventHandler(this.animalBindingNavigatorSaveItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 39);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 39);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmCadAgendamentos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(868, 704);
            this.Controls.Add(this.animalBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadAgendamentos";
            this.Text = "frmCadAgendamentos";
            this.Load += new System.EventHandler(this.frmCadAgendamentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicosAgendamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).EndInit();
            this.animalBindingNavigator.ResumeLayout(false);
            this.animalBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private petshopDataSetTableAdapters.agendamentoTableAdapter agendamentoTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox ag_horarioMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox ag_dataMaskedTextBox;
        private System.Windows.Forms.ComboBox ag_situacaoComboBox;
        private System.Windows.Forms.ComboBox ag_animalComboBox;
        private System.Windows.Forms.TextBox ag_totalTextBox;
        private petshopDataSetTableAdapters.animalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingNavigator animalBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton animalBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.TextBox ag_codigoTextBox;
        private System.Windows.Forms.BindingSource view_ServicosAgendamentosBindingSource;
    }
}