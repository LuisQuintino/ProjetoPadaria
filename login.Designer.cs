
namespace PANDOKS_V1._0
{
    partial class login
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
            this.colaboradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_padariaDataSet = new PANDOKS_V1._0.database_padariaDataSet();
            this.colaboradorTableAdapter = new PANDOKS_V1._0.database_padariaDataSetTableAdapters.colaboradorTableAdapter();
            this.tableAdapterManager = new PANDOKS_V1._0.database_padariaDataSetTableAdapters.TableAdapterManager();
            this.mxtLOGIN = new System.Windows.Forms.MaskedTextBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnENTRAR = new System.Windows.Forms.Button();
            this.txbSENHA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.database_padarianovoDataSet = new PANDOKS_V1._0.database_padarianovoDataSet();
            this.colaboradorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colaboradorTableAdapter1 = new PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.colaboradorTableAdapter();
            this.tableAdapterManager1 = new PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.TableAdapterManager();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padarianovoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // colaboradorBindingSource
            // 
            this.colaboradorBindingSource.DataMember = "colaborador";
            this.colaboradorBindingSource.DataSource = this.database_padariaDataSet;
            // 
            // database_padariaDataSet
            // 
            this.database_padariaDataSet.DataSetName = "database_padariaDataSet";
            this.database_padariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colaboradorTableAdapter
            // 
            this.colaboradorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cargoTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.colaboradorTableAdapter = this.colaboradorTableAdapter;
            this.tableAdapterManager.pedido_produtoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.producaoTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.tipo_pedidoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PANDOKS_V1._0.database_padariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mxtLOGIN
            // 
            this.mxtLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.mxtLOGIN.Location = new System.Drawing.Point(963, 597);
            this.mxtLOGIN.Mask = "000\\.000\\.000-00";
            this.mxtLOGIN.Name = "mxtLOGIN";
            this.mxtLOGIN.Size = new System.Drawing.Size(214, 40);
            this.mxtLOGIN.TabIndex = 0;
            this.mxtLOGIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.Wheat;
            this.btnCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.Location = new System.Drawing.Point(1028, 756);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(149, 50);
            this.btnCANCELAR.TabIndex = 3;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click_1);
            // 
            // btnENTRAR
            // 
            this.btnENTRAR.BackColor = System.Drawing.Color.Wheat;
            this.btnENTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnENTRAR.Location = new System.Drawing.Point(826, 756);
            this.btnENTRAR.Name = "btnENTRAR";
            this.btnENTRAR.Size = new System.Drawing.Size(149, 50);
            this.btnENTRAR.TabIndex = 2;
            this.btnENTRAR.Text = "Entrar";
            this.btnENTRAR.UseVisualStyleBackColor = false;
            this.btnENTRAR.Click += new System.EventHandler(this.btnENTRAR_Click_1);
            // 
            // txbSENHA
            // 
            this.txbSENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.txbSENHA.Location = new System.Drawing.Point(963, 660);
            this.txbSENHA.Name = "txbSENHA";
            this.txbSENHA.Size = new System.Drawing.Size(214, 40);
            this.txbSENHA.TabIndex = 1;
            this.txbSENHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbSENHA.UseSystemPasswordChar = true;
            this.txbSENHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSENHA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label2.Location = new System.Drawing.Point(820, 667);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label1.Location = new System.Drawing.Point(820, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login :";
            // 
            // database_padarianovoDataSet
            // 
            this.database_padarianovoDataSet.DataSetName = "database_padarianovoDataSet";
            this.database_padarianovoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colaboradorBindingSource1
            // 
            this.colaboradorBindingSource1.DataMember = "colaborador";
            this.colaboradorBindingSource1.DataSource = this.database_padarianovoDataSet;
            // 
            // colaboradorTableAdapter1
            // 
            this.colaboradorTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.cargoTableAdapter = null;
            this.tableAdapterManager1.clienteTableAdapter = null;
            this.tableAdapterManager1.colaboradorTableAdapter = this.colaboradorTableAdapter1;
            this.tableAdapterManager1.pedido_produtoTableAdapter = null;
            this.tableAdapterManager1.pedidoTableAdapter = null;
            this.tableAdapterManager1.producaoTableAdapter = null;
            this.tableAdapterManager1.produtoTableAdapter = null;
            this.tableAdapterManager1.tipo_pedidoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Moccasin;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource1, "nome_colaborador", true));
            this.txtNome.ForeColor = System.Drawing.Color.Moccasin;
            this.txtNome.Location = new System.Drawing.Point(-34, -1);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(33, 13);
            this.txtNome.TabIndex = 11;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::PANDOKS_V1._0.Properties.Resources.PanificSystemPadrão;
            this.pictureBox2.Location = new System.Drawing.Point(806, 347);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(380, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PANDOKS_V1._0.Properties.Resources.Design_sem_nome;
            this.ClientSize = new System.Drawing.Size(1838, 860);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mxtLOGIN);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnENTRAR);
            this.Controls.Add(this.txbSENHA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.login_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padarianovoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private database_padariaDataSet database_padariaDataSet;
        private System.Windows.Forms.BindingSource colaboradorBindingSource;
        private database_padariaDataSetTableAdapters.colaboradorTableAdapter colaboradorTableAdapter;
        private database_padariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox mxtLOGIN;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnENTRAR;
        private System.Windows.Forms.TextBox txbSENHA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private database_padarianovoDataSet database_padarianovoDataSet;
        private System.Windows.Forms.BindingSource colaboradorBindingSource1;
        private database_padarianovoDataSetTableAdapters.colaboradorTableAdapter colaboradorTableAdapter1;
        private database_padarianovoDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}