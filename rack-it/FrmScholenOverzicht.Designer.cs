namespace rack_it
{
    partial class FrmScholenOverzicht
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
            this.rack_itDataSet = new rack_it.rack_itDataSet();
            this.scholenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scholenTableAdapter = new rack_it.rack_itDataSetTableAdapters.scholenTableAdapter();
            this.tableAdapterManager = new rack_it.rack_itDataSetTableAdapters.TableAdapterManager();
            this.schoolDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClmSchool = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.txbZoekwaarde = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scholenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rack_itDataSet
            // 
            this.rack_itDataSet.DataSetName = "rack_itDataSet";
            this.rack_itDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scholenBindingSource
            // 
            this.scholenBindingSource.DataMember = "scholen";
            this.scholenBindingSource.DataSource = this.rack_itDataSet;
            // 
            // scholenTableAdapter
            // 
            this.scholenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inschrijvingspelersTableAdapter = null;
            this.tableAdapterManager.inschrijvingteamsTableAdapter = null;
            this.tableAdapterManager.locatiesTableAdapter = null;
            this.tableAdapterManager.scholenTableAdapter = this.scholenTableAdapter;
            this.tableAdapterManager.spelersTableAdapter = null;
            this.tableAdapterManager.teamsTableAdapter = null;
            this.tableAdapterManager.toernooienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = rack_it.rack_itDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veldenTableAdapter = null;
            this.tableAdapterManager.wedstrijdenTableAdapter = null;
            // 
            // schoolDataGridView
            // 
            this.schoolDataGridView.AllowUserToAddRows = false;
            this.schoolDataGridView.AllowUserToDeleteRows = false;
            this.schoolDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.schoolDataGridView.AutoGenerateColumns = false;
            this.schoolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schoolDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.btnClmSchool});
            this.schoolDataGridView.DataSource = this.scholenBindingSource;
            this.schoolDataGridView.Location = new System.Drawing.Point(80, 72);
            this.schoolDataGridView.Name = "schoolDataGridView";
            this.schoolDataGridView.RowTemplate.Height = 24;
            this.schoolDataGridView.Size = new System.Drawing.Size(640, 374);
            this.schoolDataGridView.TabIndex = 7;
            this.schoolDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schoolDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Naam";
            this.dataGridViewTextBoxColumn1.HeaderText = "Naam";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // btnClmSchool
            // 
            this.btnClmSchool.HeaderText = "Bewerk";
            this.btnClmSchool.Name = "btnClmSchool";
            this.btnClmSchool.Text = "";
            // 
            // btnNieuw
            // 
            this.btnNieuw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNieuw.BackColor = System.Drawing.Color.LightBlue;
            this.btnNieuw.Location = new System.Drawing.Point(620, 44);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(100, 23);
            this.btnNieuw.TabIndex = 10;
            this.btnNieuw.Text = "+";
            this.btnNieuw.UseVisualStyleBackColor = false;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // btnZoeken
            // 
            this.btnZoeken.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnZoeken.BackColor = System.Drawing.Color.LightBlue;
            this.btnZoeken.Location = new System.Drawing.Point(186, 43);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(75, 24);
            this.btnZoeken.TabIndex = 13;
            this.btnZoeken.Text = "Zoek";
            this.btnZoeken.UseVisualStyleBackColor = false;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // txbZoekwaarde
            // 
            this.txbZoekwaarde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbZoekwaarde.Location = new System.Drawing.Point(80, 44);
            this.txbZoekwaarde.Name = "txbZoekwaarde";
            this.txbZoekwaarde.Size = new System.Drawing.Size(100, 22);
            this.txbZoekwaarde.TabIndex = 12;
            // 
            // FrmScholenOverzicht
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.txbZoekwaarde);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.schoolDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmScholenOverzicht";
            this.Load += new System.EventHandler(this.frmScholenOverzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scholenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private rack_itDataSet rack_itDataSet;
        private System.Windows.Forms.BindingSource scholenBindingSource;
        private rack_itDataSetTableAdapters.scholenTableAdapter scholenTableAdapter;
        private rack_itDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView schoolDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn btnClmSchool;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.TextBox txbZoekwaarde;
    }
}
