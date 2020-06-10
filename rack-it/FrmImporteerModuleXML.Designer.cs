namespace rack_it
{
    partial class FrmImporteerModuleXML
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImportXml = new System.Windows.Forms.Button();
            this.btnCheckXml = new System.Windows.Forms.Button();
            this.inschrijvingspelersTableAdapter = new rack_it.rack_itDataSetTableAdapters.inschrijvingspelersTableAdapter();
            this.inschrijvingteamsTableAdapter = new rack_it.rack_itDataSetTableAdapters.inschrijvingteamsTableAdapter();
            this.locatiesTableAdapter = new rack_it.rack_itDataSetTableAdapters.locatiesTableAdapter();
            this.scholenTableAdapter = new rack_it.rack_itDataSetTableAdapters.scholenTableAdapter();
            this.spelersTableAdapter = new rack_it.rack_itDataSetTableAdapters.spelersTableAdapter();
            this.teamsTableAdapter = new rack_it.rack_itDataSetTableAdapters.teamsTableAdapter();
            this.toernooienTableAdapter = new rack_it.rack_itDataSetTableAdapters.toernooienTableAdapter();
            this.veldenTableAdapter = new rack_it.rack_itDataSetTableAdapters.veldenTableAdapter();
            this.tableAdapterManager = new rack_it.rack_itDataSetTableAdapters.TableAdapterManager();
            this.wedstrijdenTableAdapter = new rack_it.rack_itDataSetTableAdapters.wedstrijdenTableAdapter();
            this.rack_itDataSet = new rack_it.rack_itDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            this.openFileDialog1.FilterIndex = 0;
            this.openFileDialog1.InitialDirectory = "C:\\Users\\home\\source\\repos\\rack-it\\rack-it\\rack-it\\XML\\import";
            // 
            // btnImportXml
            // 
            this.btnImportXml.Location = new System.Drawing.Point(110, 120);
            this.btnImportXml.Name = "btnImportXml";
            this.btnImportXml.Size = new System.Drawing.Size(130, 46);
            this.btnImportXml.TabIndex = 5;
            this.btnImportXml.Text = "Kies\r\nXml-bestand";
            this.btnImportXml.UseVisualStyleBackColor = true;
            this.btnImportXml.Click += new System.EventHandler(this.btnImportXml_Click);
            // 
            // btnCheckXml
            // 
            this.btnCheckXml.Enabled = false;
            this.btnCheckXml.Location = new System.Drawing.Point(110, 180);
            this.btnCheckXml.Name = "btnCheckXml";
            this.btnCheckXml.Size = new System.Drawing.Size(130, 46);
            this.btnCheckXml.TabIndex = 6;
            this.btnCheckXml.Text = "Controleer Xml-bestand";
            this.btnCheckXml.UseVisualStyleBackColor = true;
            this.btnCheckXml.Click += new System.EventHandler(this.btnCheckXml_Click);
            // 
            // inschrijvingspelersTableAdapter
            // 
            this.inschrijvingspelersTableAdapter.ClearBeforeFill = true;
            // 
            // inschrijvingteamsTableAdapter
            // 
            this.inschrijvingteamsTableAdapter.ClearBeforeFill = true;
            // 
            // locatiesTableAdapter
            // 
            this.locatiesTableAdapter.ClearBeforeFill = true;
            // 
            // scholenTableAdapter
            // 
            this.scholenTableAdapter.ClearBeforeFill = true;
            // 
            // spelersTableAdapter
            // 
            this.spelersTableAdapter.ClearBeforeFill = true;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // toernooienTableAdapter
            // 
            this.toernooienTableAdapter.ClearBeforeFill = true;
            // 
            // veldenTableAdapter
            // 
            this.veldenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inschrijvingspelersTableAdapter = this.inschrijvingspelersTableAdapter;
            this.tableAdapterManager.inschrijvingteamsTableAdapter = this.inschrijvingteamsTableAdapter;
            this.tableAdapterManager.locatiesTableAdapter = this.locatiesTableAdapter;
            this.tableAdapterManager.scholenTableAdapter = this.scholenTableAdapter;
            this.tableAdapterManager.spelersTableAdapter = this.spelersTableAdapter;
            this.tableAdapterManager.teamsTableAdapter = this.teamsTableAdapter;
            this.tableAdapterManager.toernooienTableAdapter = this.toernooienTableAdapter;
            this.tableAdapterManager.UpdateOrder = rack_it.rack_itDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veldenTableAdapter = this.veldenTableAdapter;
            this.tableAdapterManager.wedstrijdenTableAdapter = this.wedstrijdenTableAdapter;
            // 
            // wedstrijdenTableAdapter
            // 
            this.wedstrijdenTableAdapter.ClearBeforeFill = true;
            // 
            // rack_itDataSet
            // 
            this.rack_itDataSet.DataSetName = "rack_itDataSet";
            this.rack_itDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmImporteerModuleXML
            // 
            this.ClientSize = new System.Drawing.Size(332, 403);
            this.Controls.Add(this.btnCheckXml);
            this.Controls.Add(this.btnImportXml);
            this.Name = "FrmImporteerModuleXML";
            this.Load += new System.EventHandler(this.FrmImporteerModuleXML_Load);
            this.Controls.SetChildIndex(this.btnImportXml, 0);
            this.Controls.SetChildIndex(this.btnCreate, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnCheckXml, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImportXml;
        private System.Windows.Forms.Button btnCheckXml;
        private rack_itDataSetTableAdapters.inschrijvingspelersTableAdapter inschrijvingspelersTableAdapter;
        private rack_itDataSetTableAdapters.inschrijvingteamsTableAdapter inschrijvingteamsTableAdapter;
        private rack_itDataSetTableAdapters.locatiesTableAdapter locatiesTableAdapter;
        private rack_itDataSetTableAdapters.scholenTableAdapter scholenTableAdapter;
        private rack_itDataSetTableAdapters.spelersTableAdapter spelersTableAdapter;
        private rack_itDataSetTableAdapters.teamsTableAdapter teamsTableAdapter;
        private rack_itDataSetTableAdapters.toernooienTableAdapter toernooienTableAdapter;
        private rack_itDataSetTableAdapters.veldenTableAdapter veldenTableAdapter;
        private rack_itDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private rack_itDataSetTableAdapters.wedstrijdenTableAdapter wedstrijdenTableAdapter;
        private rack_itDataSet rack_itDataSet;
    }
}
