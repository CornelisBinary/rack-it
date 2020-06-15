namespace rack_it
{
    partial class FrmTeamsOverzicht
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
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new rack_it.rack_itDataSetTableAdapters.teamsTableAdapter();
            this.tableAdapterManager = new rack_it.rack_itDataSetTableAdapters.TableAdapterManager();
            this.teamsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClmTeams = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.txbZoekwaarde = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rack_itDataSet
            // 
            this.rack_itDataSet.DataSetName = "rack_itDataSet";
            this.rack_itDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "teams";
            this.teamsBindingSource.DataSource = this.rack_itDataSet;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inschrijvingspelersTableAdapter = null;
            this.tableAdapterManager.inschrijvingteamsTableAdapter = null;
            this.tableAdapterManager.locatiesTableAdapter = null;
            this.tableAdapterManager.scholenTableAdapter = null;
            this.tableAdapterManager.spelersTableAdapter = null;
            this.tableAdapterManager.teamsTableAdapter = this.teamsTableAdapter;
            this.tableAdapterManager.toernooienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = rack_it.rack_itDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veldenTableAdapter = null;
            this.tableAdapterManager.wedstrijdenTableAdapter = null;
            // 
            // teamsDataGridView
            // 
            this.teamsDataGridView.AllowUserToAddRows = false;
            this.teamsDataGridView.AllowUserToDeleteRows = false;
            this.teamsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.teamsDataGridView.AutoGenerateColumns = false;
            this.teamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.btnClmTeams});
            this.teamsDataGridView.DataSource = this.teamsBindingSource;
            this.teamsDataGridView.Location = new System.Drawing.Point(80, 72);
            this.teamsDataGridView.Name = "teamsDataGridView";
            this.teamsDataGridView.RowTemplate.Height = 24;
            this.teamsDataGridView.Size = new System.Drawing.Size(640, 374);
            this.teamsDataGridView.TabIndex = 7;
            this.teamsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teamsDataGridView_CellContentClick);
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
            // btnClmTeams
            // 
            this.btnClmTeams.HeaderText = "Bewerk";
            this.btnClmTeams.Name = "btnClmTeams";
            // 
            // btnNieuw
            // 
            this.btnNieuw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNieuw.BackColor = System.Drawing.Color.LightBlue;
            this.btnNieuw.Location = new System.Drawing.Point(620, 43);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(100, 23);
            this.btnNieuw.TabIndex = 12;
            this.btnNieuw.Text = "+";
            this.btnNieuw.UseVisualStyleBackColor = false;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // btnZoeken
            // 
            this.btnZoeken.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnZoeken.BackColor = System.Drawing.Color.LightBlue;
            this.btnZoeken.Location = new System.Drawing.Point(186, 42);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(75, 24);
            this.btnZoeken.TabIndex = 14;
            this.btnZoeken.Text = "Zoek";
            this.btnZoeken.UseVisualStyleBackColor = false;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // txbZoekwaarde
            // 
            this.txbZoekwaarde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbZoekwaarde.Location = new System.Drawing.Point(80, 43);
            this.txbZoekwaarde.Name = "txbZoekwaarde";
            this.txbZoekwaarde.Size = new System.Drawing.Size(100, 22);
            this.txbZoekwaarde.TabIndex = 13;
            // 
            // FrmTeamsOverzicht
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.txbZoekwaarde);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.teamsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTeamsOverzicht";
            this.Load += new System.EventHandler(this.frmTeamsOverzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private rack_itDataSet rack_itDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private rack_itDataSetTableAdapters.teamsTableAdapter teamsTableAdapter;
        private rack_itDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView teamsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn btnClmTeams;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.TextBox txbZoekwaarde;
    }
}
