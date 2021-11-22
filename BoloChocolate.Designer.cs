
namespace PANDOKS_V1._0
{
    partial class BoloChocolate
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
            System.Windows.Forms.Label id_producaoLabel;
            System.Windows.Forms.Label data_producaoLabel;
            System.Windows.Forms.Label time_producaoLabel;
            System.Windows.Forms.Label qtd_producaoLabel;
            System.Windows.Forms.Label id_produtoLabel;
            System.Windows.Forms.Label id_colaboradorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoloChocolate));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.database_padarianovoDataSet = new PANDOKS_V1._0.database_padarianovoDataSet();
            this.producaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producaoTableAdapter = new PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.producaoTableAdapter();
            this.tableAdapterManager = new PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.TableAdapterManager();
            this.producaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.producaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_producaoTextBox = new System.Windows.Forms.TextBox();
            this.data_producaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.time_producaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.qtd_producaoTextBox = new System.Windows.Forms.TextBox();
            this.kg_producaoCheckBox = new System.Windows.Forms.CheckBox();
            this.un_producaoCheckBox = new System.Windows.Forms.CheckBox();
            this.id_produtoTextBox = new System.Windows.Forms.TextBox();
            this.id_colaboradorTextBox = new System.Windows.Forms.TextBox();
            id_producaoLabel = new System.Windows.Forms.Label();
            data_producaoLabel = new System.Windows.Forms.Label();
            time_producaoLabel = new System.Windows.Forms.Label();
            qtd_producaoLabel = new System.Windows.Forms.Label();
            id_produtoLabel = new System.Windows.Forms.Label();
            id_colaboradorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database_padarianovoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producaoBindingNavigator)).BeginInit();
            this.producaoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_producaoLabel
            // 
            id_producaoLabel.AutoSize = true;
            id_producaoLabel.BackColor = System.Drawing.Color.Transparent;
            id_producaoLabel.Location = new System.Drawing.Point(409, 48);
            id_producaoLabel.Name = "id_producaoLabel";
            id_producaoLabel.Size = new System.Drawing.Size(66, 13);
            id_producaoLabel.TabIndex = 49;
            id_producaoLabel.Text = "id producao:";
            // 
            // data_producaoLabel
            // 
            data_producaoLabel.AutoSize = true;
            data_producaoLabel.BackColor = System.Drawing.Color.Transparent;
            data_producaoLabel.Font = new System.Drawing.Font("Arial", 24F);
            data_producaoLabel.Location = new System.Drawing.Point(170, 211);
            data_producaoLabel.Name = "data_producaoLabel";
            data_producaoLabel.Size = new System.Drawing.Size(223, 36);
            data_producaoLabel.TabIndex = 51;
            data_producaoLabel.Text = "data producao:";
            // 
            // time_producaoLabel
            // 
            time_producaoLabel.AutoSize = true;
            time_producaoLabel.BackColor = System.Drawing.Color.Transparent;
            time_producaoLabel.Font = new System.Drawing.Font("Arial", 24F);
            time_producaoLabel.Location = new System.Drawing.Point(170, 297);
            time_producaoLabel.Name = "time_producaoLabel";
            time_producaoLabel.Size = new System.Drawing.Size(223, 36);
            time_producaoLabel.TabIndex = 53;
            time_producaoLabel.Text = "time producao:";
            // 
            // qtd_producaoLabel
            // 
            qtd_producaoLabel.AutoSize = true;
            qtd_producaoLabel.BackColor = System.Drawing.Color.Transparent;
            qtd_producaoLabel.Font = new System.Drawing.Font("Arial", 24F);
            qtd_producaoLabel.Location = new System.Drawing.Point(187, 451);
            qtd_producaoLabel.Name = "qtd_producaoLabel";
            qtd_producaoLabel.Size = new System.Drawing.Size(206, 36);
            qtd_producaoLabel.TabIndex = 55;
            qtd_producaoLabel.Text = "qtd producao:";
            // 
            // id_produtoLabel
            // 
            id_produtoLabel.AutoSize = true;
            id_produtoLabel.BackColor = System.Drawing.Color.Transparent;
            id_produtoLabel.Location = new System.Drawing.Point(409, 75);
            id_produtoLabel.Name = "id_produtoLabel";
            id_produtoLabel.Size = new System.Drawing.Size(57, 13);
            id_produtoLabel.TabIndex = 61;
            id_produtoLabel.Text = "id produto:";
            // 
            // id_colaboradorLabel
            // 
            id_colaboradorLabel.AutoSize = true;
            id_colaboradorLabel.BackColor = System.Drawing.Color.Transparent;
            id_colaboradorLabel.Location = new System.Drawing.Point(409, 101);
            id_colaboradorLabel.Name = "id_colaboradorLabel";
            id_colaboradorLabel.Size = new System.Drawing.Size(77, 13);
            id_colaboradorLabel.TabIndex = 63;
            id_colaboradorLabel.Text = "id colaborador:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::PANDOKS_V1._0.Properties.Resources.kisspng_chocolate_cake_birthday_cake_black_forest_gateau_w_indian_sweets_5b0d24439f4f89_7050587015275879076526__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(153, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 163);
            this.button1.TabIndex = 34;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.button2.Image = global::PANDOKS_V1._0.Properties.Resources.Folder_Accept256_24860;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(153, 554);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 62);
            this.button2.TabIndex = 47;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.button3.Image = global::PANDOKS_V1._0.Properties.Resources.undo256_24848;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(296, 554);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 62);
            this.button3.TabIndex = 48;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // database_padarianovoDataSet
            // 
            this.database_padarianovoDataSet.DataSetName = "database_padarianovoDataSet";
            this.database_padarianovoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // producaoBindingSource
            // 
            this.producaoBindingSource.DataMember = "producao";
            this.producaoBindingSource.DataSource = this.database_padarianovoDataSet;
            // 
            // producaoTableAdapter
            // 
            this.producaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cargoTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.colaboradorTableAdapter = null;
            this.tableAdapterManager.pedido_produtoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.producaoTableAdapter = this.producaoTableAdapter;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.tipo_pedidoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // producaoBindingNavigator
            // 
            this.producaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.producaoBindingNavigator.BindingSource = this.producaoBindingSource;
            this.producaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.producaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.producaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.producaoBindingNavigatorSaveItem});
            this.producaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.producaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.producaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.producaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.producaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.producaoBindingNavigator.Name = "producaoBindingNavigator";
            this.producaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.producaoBindingNavigator.Size = new System.Drawing.Size(854, 25);
            this.producaoBindingNavigator.TabIndex = 49;
            this.producaoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // producaoBindingNavigatorSaveItem
            // 
            this.producaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.producaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("producaoBindingNavigatorSaveItem.Image")));
            this.producaoBindingNavigatorSaveItem.Name = "producaoBindingNavigatorSaveItem";
            this.producaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.producaoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.producaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.producaoBindingNavigatorSaveItem_Click_1);
            // 
            // id_producaoTextBox
            // 
            this.id_producaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producaoBindingSource, "id_producao", true));
            this.id_producaoTextBox.Location = new System.Drawing.Point(494, 45);
            this.id_producaoTextBox.Name = "id_producaoTextBox";
            this.id_producaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_producaoTextBox.TabIndex = 50;
            this.id_producaoTextBox.TextChanged += new System.EventHandler(this.id_producaoTextBox_TextChanged);
            // 
            // data_producaoDateTimePicker
            // 
            this.data_producaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.producaoBindingSource, "data_producao", true));
            this.data_producaoDateTimePicker.Font = new System.Drawing.Font("Arial", 24F);
            this.data_producaoDateTimePicker.Location = new System.Drawing.Point(153, 250);
            this.data_producaoDateTimePicker.Name = "data_producaoDateTimePicker";
            this.data_producaoDateTimePicker.Size = new System.Drawing.Size(350, 44);
            this.data_producaoDateTimePicker.TabIndex = 52;
            this.data_producaoDateTimePicker.ValueChanged += new System.EventHandler(this.data_producaoDateTimePicker_ValueChanged);
            // 
            // time_producaoDateTimePicker
            // 
            this.time_producaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.producaoBindingSource, "time_producao", true));
            this.time_producaoDateTimePicker.Font = new System.Drawing.Font("Arial", 24F);
            this.time_producaoDateTimePicker.Location = new System.Drawing.Point(176, 336);
            this.time_producaoDateTimePicker.Name = "time_producaoDateTimePicker";
            this.time_producaoDateTimePicker.Size = new System.Drawing.Size(200, 44);
            this.time_producaoDateTimePicker.TabIndex = 54;
            this.time_producaoDateTimePicker.ValueChanged += new System.EventHandler(this.time_producaoDateTimePicker_ValueChanged);
            // 
            // qtd_producaoTextBox
            // 
            this.qtd_producaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producaoBindingSource, "qtd_producao", true));
            this.qtd_producaoTextBox.Font = new System.Drawing.Font("Arial", 24F);
            this.qtd_producaoTextBox.Location = new System.Drawing.Point(176, 490);
            this.qtd_producaoTextBox.Name = "qtd_producaoTextBox";
            this.qtd_producaoTextBox.Size = new System.Drawing.Size(200, 44);
            this.qtd_producaoTextBox.TabIndex = 56;
            // 
            // kg_producaoCheckBox
            // 
            this.kg_producaoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.kg_producaoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.producaoBindingSource, "kg_producao", true));
            this.kg_producaoCheckBox.Font = new System.Drawing.Font("Arial", 24F);
            this.kg_producaoCheckBox.Location = new System.Drawing.Point(153, 410);
            this.kg_producaoCheckBox.Name = "kg_producaoCheckBox";
            this.kg_producaoCheckBox.Size = new System.Drawing.Size(80, 38);
            this.kg_producaoCheckBox.TabIndex = 58;
            this.kg_producaoCheckBox.Text = "KG";
            this.kg_producaoCheckBox.UseVisualStyleBackColor = false;
            // 
            // un_producaoCheckBox
            // 
            this.un_producaoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.un_producaoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.producaoBindingSource, "un_producao", true));
            this.un_producaoCheckBox.Font = new System.Drawing.Font("Arial", 24F);
            this.un_producaoCheckBox.Location = new System.Drawing.Point(263, 410);
            this.un_producaoCheckBox.Name = "un_producaoCheckBox";
            this.un_producaoCheckBox.Size = new System.Drawing.Size(200, 38);
            this.un_producaoCheckBox.TabIndex = 60;
            this.un_producaoCheckBox.Text = "Unitário";
            this.un_producaoCheckBox.UseVisualStyleBackColor = false;
            // 
            // id_produtoTextBox
            // 
            this.id_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producaoBindingSource, "id_produto", true));
            this.id_produtoTextBox.Location = new System.Drawing.Point(494, 72);
            this.id_produtoTextBox.Name = "id_produtoTextBox";
            this.id_produtoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_produtoTextBox.TabIndex = 62;
            this.id_produtoTextBox.TextChanged += new System.EventHandler(this.id_produtoTextBox_TextChanged);
            // 
            // id_colaboradorTextBox
            // 
            this.id_colaboradorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producaoBindingSource, "id_colaborador", true));
            this.id_colaboradorTextBox.Location = new System.Drawing.Point(494, 98);
            this.id_colaboradorTextBox.Name = "id_colaboradorTextBox";
            this.id_colaboradorTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_colaboradorTextBox.TabIndex = 64;
            // 
            // BoloChocolate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PANDOKS_V1._0.Properties.Resources.Design_sem_nome;
            this.ClientSize = new System.Drawing.Size(854, 636);
            this.Controls.Add(id_producaoLabel);
            this.Controls.Add(this.id_producaoTextBox);
            this.Controls.Add(data_producaoLabel);
            this.Controls.Add(this.data_producaoDateTimePicker);
            this.Controls.Add(time_producaoLabel);
            this.Controls.Add(this.time_producaoDateTimePicker);
            this.Controls.Add(qtd_producaoLabel);
            this.Controls.Add(this.qtd_producaoTextBox);
            this.Controls.Add(this.kg_producaoCheckBox);
            this.Controls.Add(this.un_producaoCheckBox);
            this.Controls.Add(id_produtoLabel);
            this.Controls.Add(this.id_produtoTextBox);
            this.Controls.Add(id_colaboradorLabel);
            this.Controls.Add(this.id_colaboradorTextBox);
            this.Controls.Add(this.producaoBindingNavigator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "BoloChocolate";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.BoloChocolate_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.database_padarianovoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producaoBindingNavigator)).EndInit();
            this.producaoBindingNavigator.ResumeLayout(false);
            this.producaoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private database_padarianovoDataSet database_padarianovoDataSet;
        private System.Windows.Forms.BindingSource producaoBindingSource;
        private database_padarianovoDataSetTableAdapters.producaoTableAdapter producaoTableAdapter;
        private database_padarianovoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator producaoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton producaoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_producaoTextBox;
        private System.Windows.Forms.DateTimePicker data_producaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker time_producaoDateTimePicker;
        private System.Windows.Forms.TextBox qtd_producaoTextBox;
        private System.Windows.Forms.CheckBox kg_producaoCheckBox;
        private System.Windows.Forms.CheckBox un_producaoCheckBox;
        private System.Windows.Forms.TextBox id_produtoTextBox;
        private System.Windows.Forms.TextBox id_colaboradorTextBox;
    }
}