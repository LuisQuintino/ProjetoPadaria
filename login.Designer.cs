
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
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padariaDataSet)).BeginInit();
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
            this.mxtLOGIN.Font = new System.Drawing.Font("Arial", 28F);
            this.mxtLOGIN.Location = new System.Drawing.Point(706, 519);
            this.mxtLOGIN.Mask = "000\\.000\\.000-00";
            this.mxtLOGIN.Name = "mxtLOGIN";
            this.mxtLOGIN.Size = new System.Drawing.Size(380, 50);
            this.mxtLOGIN.TabIndex = 0;
            this.mxtLOGIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.Wheat;
            this.btnCANCELAR.Font = new System.Drawing.Font("Arial", 28F);
            this.btnCANCELAR.Location = new System.Drawing.Point(907, 709);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(179, 50);
            this.btnCANCELAR.TabIndex = 3;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click_1);
            // 
            // btnENTRAR
            // 
            this.btnENTRAR.BackColor = System.Drawing.Color.Wheat;
            this.btnENTRAR.Font = new System.Drawing.Font("Arial", 28F);
            this.btnENTRAR.Location = new System.Drawing.Point(706, 709);
            this.btnENTRAR.Name = "btnENTRAR";
            this.btnENTRAR.Size = new System.Drawing.Size(170, 50);
            this.btnENTRAR.TabIndex = 2;
            this.btnENTRAR.Text = "Entrar";
            this.btnENTRAR.UseVisualStyleBackColor = false;
            this.btnENTRAR.Click += new System.EventHandler(this.btnENTRAR_Click_1);
            // 
            // txbSENHA
            // 
            this.txbSENHA.Font = new System.Drawing.Font("Arial", 28F);
            this.txbSENHA.Location = new System.Drawing.Point(706, 604);
            this.txbSENHA.Name = "txbSENHA";
            this.txbSENHA.Size = new System.Drawing.Size(380, 50);
            this.txbSENHA.TabIndex = 1;
            this.txbSENHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbSENHA.UseSystemPasswordChar = true;
            this.txbSENHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSENHA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 28F);
            this.label2.Location = new System.Drawing.Point(548, 612);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 43);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 28F);
            this.label1.Location = new System.Drawing.Point(563, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login :";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PANDOKS_V1._0.Properties.Resources.Panific_System__5_;
            this.ClientSize = new System.Drawing.Size(1838, 860);
            this.Controls.Add(this.mxtLOGIN);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnENTRAR);
            this.Controls.Add(this.txbSENHA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padariaDataSet)).EndInit();
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
    }
}