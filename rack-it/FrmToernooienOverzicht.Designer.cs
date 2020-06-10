namespace rack_it
{
    partial class FrmToernooienOverzicht
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
            this.toernooienDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doelgroep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClmToernooien = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toernooienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rack_itDataSet = new rack_it.rack_itDataSet();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.txbZoekwaarde = new System.Windows.Forms.TextBox();
            this.rdbAankomend = new System.Windows.Forms.RadioButton();
            this.rdbActief = new System.Windows.Forms.RadioButton();
            this.rdbAfgelegd = new System.Windows.Forms.RadioButton();
            this.toernooienTableAdapter = new rack_it.rack_itDataSetTableAdapters.toernooienTableAdapter();
            this.tableAdapterManager = new rack_it.rack_itDataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rdbAlleToernooien = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.toernooienDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toernooienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toernooienDataGridView
            // 
            this.toernooienDataGridView.AllowUserToAddRows = false;
            this.toernooienDataGridView.AllowUserToDeleteRows = false;
            this.toernooienDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toernooienDataGridView.AutoGenerateColumns = false;
            this.toernooienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toernooienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Doelgroep,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.btnClmToernooien});
            this.toernooienDataGridView.DataSource = this.toernooienBindingSource;
            this.toernooienDataGridView.Location = new System.Drawing.Point(80, 72);
            this.toernooienDataGridView.Name = "toernooienDataGridView";
            this.toernooienDataGridView.RowTemplate.Height = 24;
            this.toernooienDataGridView.Size = new System.Drawing.Size(640, 374);
            this.toernooienDataGridView.TabIndex = 7;
            this.toernooienDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.toernooienDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Naam";
            this.dataGridViewTextBoxColumn1.HeaderText = "Naam";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Doelgroep
            // 
            this.Doelgroep.DataPropertyName = "Doelgroep";
            this.Doelgroep.HeaderText = "Doelgroep";
            this.Doelgroep.Name = "Doelgroep";
            this.Doelgroep.ReadOnly = true;
            this.Doelgroep.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn2.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Locaties_Naam";
            this.dataGridViewTextBoxColumn3.HeaderText = "Locaties_Naam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // btnClmToernooien
            // 
            this.btnClmToernooien.HeaderText = "Bekijk";
            this.btnClmToernooien.Name = "btnClmToernooien";
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
            // btnZoeken
            // 
            this.btnZoeken.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnZoeken.BackColor = System.Drawing.Color.LightBlue;
            this.btnZoeken.Location = new System.Drawing.Point(186, 43);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(75, 24);
            this.btnZoeken.TabIndex = 11;
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
            this.txbZoekwaarde.TabIndex = 10;
            // 
            // rdbAankomend
            // 
            this.rdbAankomend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbAankomend.BackColor = System.Drawing.Color.Silver;
            this.rdbAankomend.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbAankomend.Location = new System.Drawing.Point(566, 41);
            this.rdbAankomend.Name = "rdbAankomend";
            this.rdbAankomend.Size = new System.Drawing.Size(34, 25);
            this.rdbAankomend.TabIndex = 12;
            this.rdbAankomend.TabStop = true;
            this.rdbAankomend.UseVisualStyleBackColor = false;
            this.rdbAankomend.CheckedChanged += new System.EventHandler(this.rdbAankomend_CheckedChanged);
            // 
            // rdbActief
            // 
            this.rdbActief.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbActief.BackColor = System.Drawing.Color.LightGreen;
            this.rdbActief.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbActief.Location = new System.Drawing.Point(606, 41);
            this.rdbActief.Name = "rdbActief";
            this.rdbActief.Size = new System.Drawing.Size(34, 25);
            this.rdbActief.TabIndex = 16;
            this.rdbActief.TabStop = true;
            this.rdbActief.UseVisualStyleBackColor = false;
            this.rdbActief.CheckedChanged += new System.EventHandler(this.rdbActief_CheckedChanged);
            // 
            // rdbAfgelegd
            // 
            this.rdbAfgelegd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbAfgelegd.BackColor = System.Drawing.Color.Black;
            this.rdbAfgelegd.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbAfgelegd.Location = new System.Drawing.Point(646, 41);
            this.rdbAfgelegd.Name = "rdbAfgelegd";
            this.rdbAfgelegd.Size = new System.Drawing.Size(34, 25);
            this.rdbAfgelegd.TabIndex = 17;
            this.rdbAfgelegd.TabStop = true;
            this.rdbAfgelegd.UseVisualStyleBackColor = false;
            this.rdbAfgelegd.CheckedChanged += new System.EventHandler(this.rdbAfgelegd_CheckedChanged);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rdbAlleToernooien
            // 
            this.rdbAlleToernooien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbAlleToernooien.BackColor = System.Drawing.Color.Gray;
            this.rdbAlleToernooien.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbAlleToernooien.Location = new System.Drawing.Point(686, 41);
            this.rdbAlleToernooien.Name = "rdbAlleToernooien";
            this.rdbAlleToernooien.Size = new System.Drawing.Size(34, 25);
            this.rdbAlleToernooien.TabIndex = 18;
            this.rdbAlleToernooien.TabStop = true;
            this.rdbAlleToernooien.UseVisualStyleBackColor = false;
            this.rdbAlleToernooien.CheckedChanged += new System.EventHandler(this.rdbAlleToernooien_CheckedChanged);
            // 
            // FrmToernooienOverzicht
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.rdbAlleToernooien);
            this.Controls.Add(this.rdbAfgelegd);
            this.Controls.Add(this.rdbActief);
            this.Controls.Add(this.rdbAankomend);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.txbZoekwaarde);
            this.Controls.Add(this.toernooienDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmToernooienOverzicht";
            this.Load += new System.EventHandler(this.frmToernooien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toernooienDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toernooienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private rack_itDataSet rack_itDataSet;
        private System.Windows.Forms.BindingSource toernooienBindingSource;
        private rack_itDataSetTableAdapters.toernooienTableAdapter toernooienTableAdapter;
        private rack_itDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView toernooienDataGridView;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.TextBox txbZoekwaarde;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doelgroep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn btnClmToernooien;
        private System.Windows.Forms.RadioButton rdbAankomend;
        private System.Windows.Forms.RadioButton rdbActief;
        private System.Windows.Forms.RadioButton rdbAfgelegd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rdbAlleToernooien;
    }
}
