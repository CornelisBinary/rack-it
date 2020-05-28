namespace rack_it
{
    partial class FrmToernooienWeergave
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
            this.pnlAanmelden = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHandmatig = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.toernooienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rack_itDataSet = new rack_it.rack_itDataSet();
            this.toernooienTableAdapter = new rack_it.rack_itDataSetTableAdapters.toernooienTableAdapter();
            this.tableAdapterManager = new rack_it.rack_itDataSetTableAdapters.TableAdapterManager();
            this.pnlToernooi = new System.Windows.Forms.Panel();
            this.pbAfvalschema = new System.Windows.Forms.PictureBox();
            this.pnlAanmelden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toernooienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).BeginInit();
            this.pnlToernooi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfvalschema)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAanmelden
            // 
            this.pnlAanmelden.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlAanmelden.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAanmelden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAanmelden.Controls.Add(this.label1);
            this.pnlAanmelden.Controls.Add(this.btnHandmatig);
            this.pnlAanmelden.Controls.Add(this.btnXML);
            this.pnlAanmelden.Location = new System.Drawing.Point(100, 50);
            this.pnlAanmelden.Name = "pnlAanmelden";
            this.pnlAanmelden.Size = new System.Drawing.Size(600, 350);
            this.pnlAanmelden.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aanmelden";
            // 
            // btnHandmatig
            // 
            this.btnHandmatig.Location = new System.Drawing.Point(197, 106);
            this.btnHandmatig.Name = "btnHandmatig";
            this.btnHandmatig.Size = new System.Drawing.Size(100, 25);
            this.btnHandmatig.TabIndex = 1;
            this.btnHandmatig.Text = "Handmatig";
            this.btnHandmatig.UseVisualStyleBackColor = true;
            this.btnHandmatig.Click += new System.EventHandler(this.btnHandmatig_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(77, 106);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(100, 25);
            this.btnXML.TabIndex = 0;
            this.btnXML.Text = "XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // toernooienBindingSource
            // 
            this.toernooienBindingSource.DataMember = "toernooien";
            this.toernooienBindingSource.DataSource = this.rack_itDataSet;
            // 
            // rack_itDataSet
            // 
            this.rack_itDataSet.DataSetName = "rack_itDataSet";
            this.rack_itDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toernooienTableAdapter
            // 
            this.toernooienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inschrijvingspelersTableAdapter = null;
            this.tableAdapterManager.inschrijvingteamsTableAdapter = null;
            this.tableAdapterManager.locatiesTableAdapter = null;
            this.tableAdapterManager.scholenTableAdapter = null;
            this.tableAdapterManager.spelersTableAdapter = null;
            this.tableAdapterManager.teamsTableAdapter = null;
            this.tableAdapterManager.toernooienTableAdapter = this.toernooienTableAdapter;
            this.tableAdapterManager.UpdateOrder = rack_it.rack_itDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veldenTableAdapter = null;
            this.tableAdapterManager.wedstrijdenTableAdapter = null;
            // 
            // pnlToernooi
            // 
            this.pnlToernooi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlToernooi.AutoScroll = true;
            this.pnlToernooi.AutoSize = true;
            this.pnlToernooi.BackColor = System.Drawing.SystemColors.Control;
            this.pnlToernooi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToernooi.Controls.Add(this.pbAfvalschema);
            this.pnlToernooi.Location = new System.Drawing.Point(100, 50);
            this.pnlToernooi.Name = "pnlToernooi";
            this.pnlToernooi.Size = new System.Drawing.Size(600, 350);
            this.pnlToernooi.TabIndex = 9;
            // 
            // pbAfvalschema
            // 
            this.pbAfvalschema.Location = new System.Drawing.Point(10, 10);
            this.pbAfvalschema.Name = "pbAfvalschema";
            this.pbAfvalschema.Size = new System.Drawing.Size(580, 300);
            this.pbAfvalschema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAfvalschema.TabIndex = 3;
            this.pbAfvalschema.TabStop = false;
            // 
            // FrmToernooienWeergave
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlToernooi);
            this.Controls.Add(this.pnlAanmelden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmToernooienWeergave";
            this.Text = "FrmToernooienWeergave";
            this.Load += new System.EventHandler(this.FrmToernooienWeergave_Load);
            this.pnlAanmelden.ResumeLayout(false);
            this.pnlAanmelden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toernooienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).EndInit();
            this.pnlToernooi.ResumeLayout(false);
            this.pnlToernooi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfvalschema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAanmelden;
        private rack_itDataSet rack_itDataSet;
        private System.Windows.Forms.BindingSource toernooienBindingSource;
        private rack_itDataSetTableAdapters.toernooienTableAdapter toernooienTableAdapter;
        private rack_itDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel pnlToernooi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHandmatig;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.PictureBox pbAfvalschema;
    }
}