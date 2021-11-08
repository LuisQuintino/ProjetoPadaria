
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mxtLOGIN = new System.Windows.Forms.MaskedTextBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnENTRAR = new System.Windows.Forms.Button();
            this.txbSENHA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colaboradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_padariaDataSet = new PANDOKS_V1._0.database_padariaDataSet();
            this.colaboradorTableAdapter = new PANDOKS_V1._0.database_padariaDataSetTableAdapters.colaboradorTableAdapter();
            this.tableAdapterManager = new PANDOKS_V1._0.database_padariaDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mxtLOGIN);
            this.panel1.Controls.Add(this.btnCANCELAR);
            this.panel1.Controls.Add(this.btnENTRAR);
            this.panel1.Controls.Add(this.txbSENHA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 680);
            this.panel1.TabIndex = 0;
            // 
            // mxtLOGIN
            // 
            this.mxtLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mxtLOGIN.Location = new System.Drawing.Point(424, 427);
            this.mxtLOGIN.Mask = "000.000.000-00";
            this.mxtLOGIN.Name = "mxtLOGIN";
            this.mxtLOGIN.Size = new System.Drawing.Size(380, 47);
            this.mxtLOGIN.TabIndex = 8;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.Wheat;
            this.btnCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.Location = new System.Drawing.Point(634, 617);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(170, 50);
            this.btnCANCELAR.TabIndex = 7;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnENTRAR
            // 
            this.btnENTRAR.BackColor = System.Drawing.Color.Wheat;
            this.btnENTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnENTRAR.Location = new System.Drawing.Point(424, 617);
            this.btnENTRAR.Name = "btnENTRAR";
            this.btnENTRAR.Size = new System.Drawing.Size(170, 50);
            this.btnENTRAR.TabIndex = 6;
            this.btnENTRAR.Text = "Entrar";
            this.btnENTRAR.UseVisualStyleBackColor = false;
            this.btnENTRAR.Click += new System.EventHandler(this.btnENTRAR_Click);
            // 
            // txbSENHA
            // 
            this.txbSENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSENHA.Location = new System.Drawing.Point(424, 512);
            this.txbSENHA.Name = "txbSENHA";
            this.txbSENHA.Size = new System.Drawing.Size(380, 47);
            this.txbSENHA.TabIndex = 4;
            this.txbSENHA.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Moccasin;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.colaboradorBindingSource, "id_colaborador", true));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1228, 678);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 680);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_padariaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbSENHA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnENTRAR;
        private database_padariaDataSet database_padariaDataSet;
        private System.Windows.Forms.BindingSource colaboradorBindingSource;
        private database_padariaDataSetTableAdapters.colaboradorTableAdapter colaboradorTableAdapter;
        private database_padariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox mxtLOGIN;
    }
}