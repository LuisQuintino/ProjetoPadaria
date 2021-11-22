
namespace PANDOKS_V1._0
{
    partial class Cadastrarprodutos
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
            System.Windows.Forms.Label valor_produtoLabel;
            System.Windows.Forms.Label nome_produtoLabel;
            System.Windows.Forms.Label id_produtoLabel;
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database_padarianovoDataSet = new PANDOKS_V1._0.database_padarianovoDataSet();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_padariaDataSet = new PANDOKS_V1._0.database_padariaDataSet();
            this.produtoTableAdapter = new PANDOKS_V1._0.database_padariaDataSetTableAdapters.produtoTableAdapter();
            this.tableAdapterManager = new PANDOKS_V1._0.database_padariaDataSetTableAdapters.TableAdapterManager();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.produtoTableAdapter1 = new PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.produtoTableAdapter();
            this.tableAdapterManager1 = new PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.TableAdapterManager();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.id_produtoTextBox = new System.Windows.Forms.TextBox();
            this.nome_produtoTextBox = new System.Windows.Forms.TextBox();
            this.valor_produtoTextBox = new System.Windows.Forms.TextBox();
            this.tabProduto = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnproximo = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.produtoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            valor_produtoLabel = new System.Windows.Forms.Label();
            nome_produtoLabel = new System.Windows.Forms.Label();
            id_produtoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padarianovoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padariaDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // valor_produtoLabel
            // 
            valor_produtoLabel.AutoSize = true;
            valor_produtoLabel.Location = new System.Drawing.Point(26, 160);
            valor_produtoLabel.Name = "valor_produtoLabel";
            valor_produtoLabel.Size = new System.Drawing.Size(206, 36);
            valor_produtoLabel.TabIndex = 4;
            valor_produtoLabel.Text = "valor produto:";
            // 
            // nome_produtoLabel
            // 
            nome_produtoLabel.AutoSize = true;
            nome_produtoLabel.Location = new System.Drawing.Point(26, 102);
            nome_produtoLabel.Name = "nome_produtoLabel";
            nome_produtoLabel.Size = new System.Drawing.Size(218, 36);
            nome_produtoLabel.TabIndex = 2;
            nome_produtoLabel.Text = "nome produto:";
            // 
            // id_produtoLabel
            // 
            id_produtoLabel.AutoSize = true;
            id_produtoLabel.Location = new System.Drawing.Point(26, 44);
            id_produtoLabel.Name = "id_produtoLabel";
            id_produtoLabel.Size = new System.Drawing.Size(163, 36);
            id_produtoLabel.TabIndex = 0;
            id_produtoLabel.Text = "id produto:";
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackgroundImage = global::PANDOKS_V1._0.Properties.Resources.Design_sem_nome;
            this.tabPage3.Controls.Add(this.produtoDataGridView);
            this.tabPage3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 45);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(544, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consulta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackgroundImage = global::PANDOKS_V1._0.Properties.Resources.Design_sem_nome;
            this.tabPage1.Controls.Add(id_produtoLabel);
            this.tabPage1.Controls.Add(this.id_produtoTextBox);
            this.tabPage1.Controls.Add(this.nome_produtoTextBox);
            this.tabPage1.Controls.Add(this.valor_produtoTextBox);
            this.tabPage1.Controls.Add(nome_produtoLabel);
            this.tabPage1.Controls.Add(valor_produtoLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 45);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // id_produtoTextBox
            // 
            this.id_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource1, "id_produto", true));
            this.id_produtoTextBox.Location = new System.Drawing.Point(289, 36);
            this.id_produtoTextBox.Name = "id_produtoTextBox";
            this.id_produtoTextBox.Size = new System.Drawing.Size(174, 44);
            this.id_produtoTextBox.TabIndex = 1;
            this.id_produtoTextBox.TextChanged += new System.EventHandler(this.id_produtoTextBox_TextChanged);
            // 
            // nome_produtoTextBox
            // 
            this.nome_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource1, "nome_produto", true));
            this.nome_produtoTextBox.Location = new System.Drawing.Point(289, 94);
            this.nome_produtoTextBox.Name = "nome_produtoTextBox";
            this.nome_produtoTextBox.Size = new System.Drawing.Size(174, 44);
            this.nome_produtoTextBox.TabIndex = 3;
            this.nome_produtoTextBox.TextChanged += new System.EventHandler(this.nome_produtoTextBox_TextChanged);
            // 
            // valor_produtoTextBox
            // 
            this.valor_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource1, "valor_produto", true));
            this.valor_produtoTextBox.Location = new System.Drawing.Point(289, 152);
            this.valor_produtoTextBox.Name = "valor_produtoTextBox";
            this.valor_produtoTextBox.Size = new System.Drawing.Size(174, 44);
            this.valor_produtoTextBox.TabIndex = 5;
            // 
            // tabProduto
            // 
            this.tabProduto.Controls.Add(this.tabPage1);
            this.tabProduto.Controls.Add(this.tabPage3);
            this.tabProduto.Font = new System.Drawing.Font("Arial", 24F);
            this.tabProduto.Location = new System.Drawing.Point(12, 57);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.SelectedIndex = 0;
            this.tabProduto.Size = new System.Drawing.Size(552, 384);
            this.tabProduto.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::PANDOKS_V1._0.Properties.Resources.CLIENTES_2;
            this.pictureBox1.Location = new System.Drawing.Point(621, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // btndeletar
            // 
            this.btndeletar.BackColor = System.Drawing.Color.Transparent;
            this.btndeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletar.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.btndeletar.Image = global::PANDOKS_V1._0.Properties.Resources.Folder_Delete256_24851;
            this.btndeletar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndeletar.Location = new System.Drawing.Point(512, 477);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(109, 62);
            this.btndeletar.TabIndex = 87;
            this.btndeletar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndeletar.UseVisualStyleBackColor = false;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.BackColor = System.Drawing.Color.Transparent;
            this.btnanterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnanterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnanterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanterior.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.btnanterior.Image = global::PANDOKS_V1._0.Properties.Resources.navigate_left256_24869;
            this.btnanterior.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnanterior.Location = new System.Drawing.Point(627, 477);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(109, 62);
            this.btnanterior.TabIndex = 86;
            this.btnanterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnanterior.UseVisualStyleBackColor = false;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnproximo
            // 
            this.btnproximo.BackColor = System.Drawing.Color.Transparent;
            this.btnproximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnproximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproximo.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.btnproximo.Image = global::PANDOKS_V1._0.Properties.Resources.navigate_right256_24872;
            this.btnproximo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnproximo.Location = new System.Drawing.Point(742, 477);
            this.btnproximo.Name = "btnproximo";
            this.btnproximo.Size = new System.Drawing.Size(109, 62);
            this.btnproximo.TabIndex = 85;
            this.btnproximo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnproximo.UseVisualStyleBackColor = false;
            this.btnproximo.Click += new System.EventHandler(this.btnproximo_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnsalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.btnsalvar.Image = global::PANDOKS_V1._0.Properties.Resources.Folder_Accept256_24860;
            this.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsalvar.Location = new System.Drawing.Point(397, 477);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(109, 62);
            this.btnsalvar.TabIndex = 84;
            this.btnsalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::PANDOKS_V1._0.Properties.Resources.undo256_24848;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(857, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 62);
            this.button1.TabIndex = 83;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.Color.Transparent;
            this.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovo.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.btnnovo.Image = global::PANDOKS_V1._0.Properties.Resources.Folder_Add256_24876;
            this.btnnovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnnovo.Location = new System.Drawing.Point(282, 477);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(109, 62);
            this.btnnovo.TabIndex = 82;
            this.btnnovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // produtoDataGridView
            // 
            this.produtoDataGridView.AutoGenerateColumns = false;
            this.produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.produtoDataGridView.DataSource = this.produtoBindingSource1;
            this.produtoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produtoDataGridView.Location = new System.Drawing.Point(3, 3);
            this.produtoDataGridView.Name = "produtoDataGridView";
            this.produtoDataGridView.Size = new System.Drawing.Size(538, 329);
            this.produtoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_produto";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome_produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "valor_produto";
            this.dataGridViewTextBoxColumn3.HeaderText = "valor_produto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "img_produto";
            this.dataGridViewTextBoxColumn4.HeaderText = "img_produto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Cadastrarprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PANDOKS_V1._0.Properties.Resources.Design_sem_nome;
            this.ClientSize = new System.Drawing.Size(1326, 561);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.btnproximo);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Cadastrarprodutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrarprodutos";
            this.Load += new System.EventHandler(this.Cadastrarprodutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padarianovoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padariaDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private database_padariaDataSet database_padariaDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private database_padariaDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private database_padariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private database_padarianovoDataSet database_padarianovoDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private database_padarianovoDataSetTableAdapters.produtoTableAdapter produtoTableAdapter1;
        private database_padarianovoDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox id_produtoTextBox;
        private System.Windows.Forms.TextBox nome_produtoTextBox;
        private System.Windows.Forms.TextBox valor_produtoTextBox;
        private System.Windows.Forms.TabControl tabProduto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnproximo;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.DataGridView produtoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}