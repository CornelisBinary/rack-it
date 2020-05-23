namespace rack_it
{
    partial class FrmSpelersOverzicht
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
            this.spelersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spelersTableAdapter = new rack_it.rack_itDataSetTableAdapters.spelersTableAdapter();
            this.tableAdapterManager = new rack_it.rack_itDataSetTableAdapters.TableAdapterManager();
            this.spelersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scholen_Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClmSpelers = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNieuw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rack_itDataSet
            // 
            this.rack_itDataSet.DataSetName = "rack_itDataSet";
            this.rack_itDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spelersBindingSource
            // 
            this.spelersBindingSource.DataMember = "spelers";
            this.spelersBindingSource.DataSource = this.rack_itDataSet;
            // 
            // spelersTableAdapter
            // 
            this.spelersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inschrijvingspelersTableAdapter = null;
            this.tableAdapterManager.inschrijvingteamsTableAdapter = null;
            this.tableAdapterManager.locatiesTableAdapter = null;
            this.tableAdapterManager.scholenTableAdapter = null;
            this.tableAdapterManager.spelersTableAdapter = this.spelersTableAdapter;
            this.tableAdapterManager.teamsTableAdapter = null;
            this.tableAdapterManager.toernooienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = rack_it.rack_itDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veldenTableAdapter = null;
            this.tableAdapterManager.wedstrijdenTableAdapter = null;
            // 
            // spelersDataGridView
            // 
            this.spelersDataGridView.AllowUserToAddRows = false;
            this.spelersDataGridView.AllowUserToDeleteRows = false;
            this.spelersDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spelersDataGridView.AutoGenerateColumns = false;
            this.spelersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spelersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Scholen_Naam,
            this.btnClmSpelers});
            this.spelersDataGridView.DataSource = this.spelersBindingSource;
            this.spelersDataGridView.Location = new System.Drawing.Point(80, 72);
            this.spelersDataGridView.Name = "spelersDataGridView";
            this.spelersDataGridView.RowTemplate.Height = 24;
            this.spelersDataGridView.Size = new System.Drawing.Size(640, 374);
            this.spelersDataGridView.TabIndex = 7;
            this.spelersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spelersDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nummer";
            this.dataGridViewTextBoxColumn1.HeaderText = "nummer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naam";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naam";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Teams_Naam";
            this.dataGridViewTextBoxColumn3.HeaderText = "Teams_Naam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Scholen_Naam
            // 
            this.Scholen_Naam.DataPropertyName = "Scholen_Naam";
            this.Scholen_Naam.HeaderText = "Scholen_Naam";
            this.Scholen_Naam.Name = "Scholen_Naam";
            this.Scholen_Naam.ReadOnly = true;
            // 
            // btnClmSpelers
            // 
            this.btnClmSpelers.HeaderText = "Bewerk";
            this.btnClmSpelers.Name = "btnClmSpelers";
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button7.Location = new System.Drawing.Point(186, 43);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 24);
            this.button7.TabIndex = 11;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(80, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
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
            // FrmSpelersOverzicht
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.spelersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSpelersOverzicht";
            this.Load += new System.EventHandler(this.frmSpelersOverzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private rack_itDataSet rack_itDataSet;
        private System.Windows.Forms.BindingSource spelersBindingSource;
        private rack_itDataSetTableAdapters.spelersTableAdapter spelersTableAdapter;
        private rack_itDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView spelersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scholen_Naam;
        private System.Windows.Forms.DataGridViewButtonColumn btnClmSpelers;
    }
}
