
namespace PANDOKS_V1._0
{
    partial class TelaCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCaixa));
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database_padarianovoDataSet = new PANDOKS_V1._0.database_padarianovoDataSet();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_padariaDataSet = new PANDOKS_V1._0.database_padariaDataSet();
            this.produtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.produtoTableAdapter = new PANDOKS_V1._0.database_padariaDataSetTableAdapters.produtoTableAdapter();
            this.tableAdapterManager = new PANDOKS_V1._0.database_padariaDataSetTableAdapters.TableAdapterManager();
            this.produtoTableAdapter1 = new PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.produtoTableAdapter();
            this.tableAdapterManager1 = new PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.TableAdapterManager();
            this.Caixa = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNomeOperador = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtTotalQtd = new System.Windows.Forms.TextBox();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnadcproduto = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.lbcupom = new System.Windows.Forms.ListBox();
            this.button23 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfecharvenda = new System.Windows.Forms.Button();
            this.txtcancelarvenda = new System.Windows.Forms.Button();
            this.pesqproduto = new System.Windows.Forms.Button();
            this.cancelaritem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnmproduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padarianovoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).BeginInit();
            this.produtoBindingNavigator.SuspendLayout();
            this.Caixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "produto";
            this.produtoBindingSource1.DataSource = this.database_padarianovoDataSet;
            // 
            // database_padarianovoDataSet
            // 
            this.database_padarianovoDataSet.DataSetName = "database_padarianovoDataSet";
            this.database_padarianovoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.database_padariaDataSet;
            // 
            // database_padariaDataSet
            // 
            this.database_padariaDataSet.DataSetName = "database_padariaDataSet";
            this.database_padariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingNavigator
            // 
            this.produtoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produtoBindingNavigator.BindingSource = this.produtoBindingSource;
            this.produtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produtoBindingNavigatorSaveItem});
            this.produtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtoBindingNavigator.Name = "produtoBindingNavigator";
            this.produtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtoBindingNavigator.Size = new System.Drawing.Size(1467, 25);
            this.produtoBindingNavigator.TabIndex = 1;
            this.produtoBindingNavigator.Text = "bindingNavigator1";
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
            // produtoBindingNavigatorSaveItem
            // 
            this.produtoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoBindingNavigatorSaveItem.Image")));
            this.produtoBindingNavigatorSaveItem.Name = "produtoBindingNavigatorSaveItem";
            this.produtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produtoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.produtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtoBindingNavigatorSaveItem_Click);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cargoTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.colaboradorTableAdapter = null;
            this.tableAdapterManager.pedido_produtoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.producaoTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.tipo_pedidoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PANDOKS_V1._0.database_padariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtoTableAdapter1
            // 
            this.produtoTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.cargoTableAdapter = null;
            this.tableAdapterManager1.clienteTableAdapter = null;
            this.tableAdapterManager1.colaboradorTableAdapter = null;
            this.tableAdapterManager1.pedido_produtoTableAdapter = null;
            this.tableAdapterManager1.pedidoTableAdapter = null;
            this.tableAdapterManager1.producaoTableAdapter = null;
            this.tableAdapterManager1.produtoTableAdapter = this.produtoTableAdapter1;
            this.tableAdapterManager1.tipo_pedidoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Caixa
            // 
            this.Caixa.BackColor = System.Drawing.Color.Transparent;
            this.Caixa.BackgroundImage = global::PANDOKS_V1._0.Properties.Resources.Design_sem_nome;
            this.Caixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Caixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Caixa.Controls.Add(this.pictureBox1);
            this.Caixa.Controls.Add(this.txtNomeOperador);
            this.Caixa.Controls.Add(this.textBox3);
            this.Caixa.Controls.Add(this.pictureBox2);
            this.Caixa.Controls.Add(this.txtTotalQtd);
            this.Caixa.Controls.Add(this.txtValorFinal);
            this.Caixa.Controls.Add(this.txtValorTotal);
            this.Caixa.Controls.Add(this.txtValorUnit);
            this.Caixa.Controls.Add(this.txtQtd);
            this.Caixa.Controls.Add(this.textBox1);
            this.Caixa.Controls.Add(this.label7);
            this.Caixa.Controls.Add(this.btnadcproduto);
            this.Caixa.Controls.Add(this.button25);
            this.Caixa.Controls.Add(this.button26);
            this.Caixa.Controls.Add(this.lbcupom);
            this.Caixa.Controls.Add(this.button23);
            this.Caixa.Controls.Add(this.label6);
            this.Caixa.Controls.Add(this.button22);
            this.Caixa.Controls.Add(this.button19);
            this.Caixa.Controls.Add(this.label5);
            this.Caixa.Controls.Add(this.label4);
            this.Caixa.Controls.Add(this.label3);
            this.Caixa.Controls.Add(this.label2);
            this.Caixa.Controls.Add(this.label1);
            this.Caixa.Controls.Add(this.btnfecharvenda);
            this.Caixa.Controls.Add(this.txtcancelarvenda);
            this.Caixa.Controls.Add(this.pesqproduto);
            this.Caixa.Controls.Add(this.cancelaritem);
            this.Caixa.Controls.Add(this.button1);
            this.Caixa.Controls.Add(this.txtnmproduto);
            this.Caixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Caixa.ForeColor = System.Drawing.Color.White;
            this.Caixa.Location = new System.Drawing.Point(0, 0);
            this.Caixa.Name = "Caixa";
            this.Caixa.Size = new System.Drawing.Size(1467, 836);
            this.Caixa.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::PANDOKS_V1._0.Properties.Resources._3440920_bag_basket_cart_ecommerce_shop_shopping_store_107540;
            this.pictureBox1.Location = new System.Drawing.Point(62, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtNomeOperador
            // 
            this.txtNomeOperador.BackColor = System.Drawing.Color.Black;
            this.txtNomeOperador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeOperador.Font = new System.Drawing.Font("Arial", 20F);
            this.txtNomeOperador.ForeColor = System.Drawing.Color.White;
            this.txtNomeOperador.Location = new System.Drawing.Point(6, 53);
            this.txtNomeOperador.Name = "txtNomeOperador";
            this.txtNomeOperador.Size = new System.Drawing.Size(140, 31);
            this.txtNomeOperador.TabIndex = 50;
            this.txtNomeOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeOperador.TextChanged += new System.EventHandler(this.txtNomeOperador_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(-16, -16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 49;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::PANDOKS_V1._0.Properties.Resources.PanificSystemPadrão;
            this.pictureBox2.Location = new System.Drawing.Point(1074, 609);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(380, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtTotalQtd
            // 
            this.txtTotalQtd.BackColor = System.Drawing.Color.Teal;
            this.txtTotalQtd.Font = new System.Drawing.Font("Arial", 33F);
            this.txtTotalQtd.Location = new System.Drawing.Point(603, 602);
            this.txtTotalQtd.Name = "txtTotalQtd";
            this.txtTotalQtd.Size = new System.Drawing.Size(107, 58);
            this.txtTotalQtd.TabIndex = 46;
            this.txtTotalQtd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.BackColor = System.Drawing.Color.SeaGreen;
            this.txtValorFinal.Font = new System.Drawing.Font("Arial", 64F);
            this.txtValorFinal.ForeColor = System.Drawing.SystemColors.Window;
            this.txtValorFinal.Location = new System.Drawing.Point(791, 702);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(259, 106);
            this.txtValorFinal.TabIndex = 45;
            this.txtValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorFinal.TextChanged += new System.EventHandler(this.txtValorFinal_TextChanged);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.txtValorTotal.Location = new System.Drawing.Point(538, 480);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(325, 40);
            this.txtValorTotal.TabIndex = 43;
            this.txtValorTotal.TextChanged += new System.EventHandler(this.txtValorTotal_TextChanged);
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource1, "valor_produto", true));
            this.txtValorUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.txtValorUnit.Location = new System.Drawing.Point(538, 366);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(325, 40);
            this.txtValorUnit.TabIndex = 42;
            this.txtValorUnit.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.txtQtd.Location = new System.Drawing.Point(538, 242);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(325, 40);
            this.txtQtd.TabIndex = 1;
            this.txtQtd.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.textBox1.Location = new System.Drawing.Point(24, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(761, 40);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Arial", 24F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(597, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 36);
            this.label7.TabIndex = 39;
            this.label7.Text = "17:03:52";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnadcproduto
            // 
            this.btnadcproduto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnadcproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.btnadcproduto.ForeColor = System.Drawing.Color.Black;
            this.btnadcproduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadcproduto.Location = new System.Drawing.Point(791, 140);
            this.btnadcproduto.Name = "btnadcproduto";
            this.btnadcproduto.Size = new System.Drawing.Size(72, 40);
            this.btnadcproduto.TabIndex = 3;
            this.btnadcproduto.Text = "OK";
            this.btnadcproduto.UseVisualStyleBackColor = false;
            this.btnadcproduto.Click += new System.EventHandler(this.btnadcproduto_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.White;
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.button25.Image = global::PANDOKS_V1._0.Properties.Resources.Home;
            this.button25.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button25.Location = new System.Drawing.Point(1155, 27);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(60, 44);
            this.button25.TabIndex = 37;
            this.button25.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.White;
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.button26.Image = global::PANDOKS_V1._0.Properties.Resources.voltar;
            this.button26.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button26.Location = new System.Drawing.Point(1089, 27);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(60, 44);
            this.button26.TabIndex = 36;
            this.button26.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // lbcupom
            // 
            this.lbcupom.BackColor = System.Drawing.Color.Wheat;
            this.lbcupom.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.lbcupom.FormattingEnabled = true;
            this.lbcupom.ItemHeight = 33;
            this.lbcupom.Location = new System.Drawing.Point(889, 141);
            this.lbcupom.Name = "lbcupom";
            this.lbcupom.Size = new System.Drawing.Size(529, 400);
            this.lbcupom.TabIndex = 11;
            this.lbcupom.SelectedIndexChanged += new System.EventHandler(this.lbcupom_SelectedIndexChanged);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Black;
            this.button23.Font = new System.Drawing.Font("Arial", 24F);
            this.button23.Location = new System.Drawing.Point(1260, 27);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(173, 44);
            this.button23.TabIndex = 34;
            this.button23.Text = "Sair (F12)";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Arial", 18F);
            this.label6.Location = new System.Drawing.Point(3, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "OPERADOR";
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.SeaGreen;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.button22.Location = new System.Drawing.Point(791, 631);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(259, 56);
            this.button22.TabIndex = 30;
            this.button22.Text = "R$ TOTAL";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Teal;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.button19.Location = new System.Drawing.Point(303, 602);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(285, 58);
            this.button19.TabIndex = 26;
            this.button19.Text = "Total Itens";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(533, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 33);
            this.label5.TabIndex = 22;
            this.label5.Text = "R$ Valor Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(533, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 33);
            this.label4.TabIndex = 21;
            this.label4.Text = "R$ Valor Unitário";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(533, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome do produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código de Barras";
            // 
            // btnfecharvenda
            // 
            this.btnfecharvenda.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnfecharvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.btnfecharvenda.Location = new System.Drawing.Point(301, 759);
            this.btnfecharvenda.Name = "btnfecharvenda";
            this.btnfecharvenda.Size = new System.Drawing.Size(407, 55);
            this.btnfecharvenda.TabIndex = 12;
            this.btnfecharvenda.Text = "Fechar Venda (F10)";
            this.btnfecharvenda.UseVisualStyleBackColor = false;
            this.btnfecharvenda.Click += new System.EventHandler(this.btnfecharvenda_Click);
            // 
            // txtcancelarvenda
            // 
            this.txtcancelarvenda.BackColor = System.Drawing.Color.Red;
            this.txtcancelarvenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtcancelarvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.txtcancelarvenda.Location = new System.Drawing.Point(301, 678);
            this.txtcancelarvenda.Name = "txtcancelarvenda";
            this.txtcancelarvenda.Size = new System.Drawing.Size(408, 55);
            this.txtcancelarvenda.TabIndex = 10;
            this.txtcancelarvenda.Text = "CANCELAR VENDA (F11)";
            this.txtcancelarvenda.UseVisualStyleBackColor = false;
            this.txtcancelarvenda.Click += new System.EventHandler(this.txtcancelarvenda_Click);
            // 
            // pesqproduto
            // 
            this.pesqproduto.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pesqproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesqproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.pesqproduto.Location = new System.Drawing.Point(25, 575);
            this.pesqproduto.Name = "pesqproduto";
            this.pesqproduto.Size = new System.Drawing.Size(219, 112);
            this.pesqproduto.TabIndex = 5;
            this.pesqproduto.Text = "Pesquisar Produto (F9)";
            this.pesqproduto.UseVisualStyleBackColor = false;
            this.pesqproduto.Click += new System.EventHandler(this.pesqproduto_Click);
            // 
            // cancelaritem
            // 
            this.cancelaritem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cancelaritem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelaritem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.cancelaritem.Location = new System.Drawing.Point(25, 702);
            this.cancelaritem.Name = "cancelaritem";
            this.cancelaritem.Size = new System.Drawing.Size(219, 112);
            this.cancelaritem.TabIndex = 4;
            this.cancelaritem.Text = "Cancelar Item (F8)";
            this.cancelaritem.UseVisualStyleBackColor = false;
            this.cancelaritem.Click += new System.EventHandler(this.cancelaritem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1467, 90);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtnmproduto
            // 
            this.txtnmproduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource1, "nome_produto", true));
            this.txtnmproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.txtnmproduto.Location = new System.Drawing.Point(24, 483);
            this.txtnmproduto.Name = "txtnmproduto";
            this.txtnmproduto.Size = new System.Drawing.Size(496, 40);
            this.txtnmproduto.TabIndex = 44;
            this.txtnmproduto.TextChanged += new System.EventHandler(this.txtnmproduto_TextChanged);
            // 
            // TelaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 836);
            this.Controls.Add(this.produtoBindingNavigator);
            this.Controls.Add(this.Caixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "TelaCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TelaCaixa_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padarianovoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).EndInit();
            this.produtoBindingNavigator.ResumeLayout(false);
            this.produtoBindingNavigator.PerformLayout();
            this.Caixa.ResumeLayout(false);
            this.Caixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Caixa;
        private System.Windows.Forms.Button btnfecharvenda;
        private System.Windows.Forms.Button txtcancelarvenda;
        private System.Windows.Forms.Button pesqproduto;
        private System.Windows.Forms.Button cancelaritem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.ListBox lbcupom;
        private System.Windows.Forms.Button btnadcproduto;
        private System.Windows.Forms.Label label7;
        private database_padariaDataSet database_padariaDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private database_padariaDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private database_padariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produtoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produtoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtnmproduto;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtValorFinal;
        private database_padarianovoDataSet database_padarianovoDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private database_padarianovoDataSetTableAdapters.produtoTableAdapter produtoTableAdapter1;
        private database_padarianovoDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtTotalQtd;
        private System.Windows.Forms.TextBox txtNomeOperador;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}