namespace rack_it
{
    partial class FrmBewerkSpeler
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
            System.Windows.Forms.Label nummerLabel;
            System.Windows.Forms.Label naamLabel;
            System.Windows.Forms.Label teams_NaamLabel;
            System.Windows.Forms.Label scholen_NaamLabel;
            this.tableAdapterManager = new rack_it.rack_itDataSetTableAdapters.TableAdapterManager();
            this.scholenTableAdapter = new rack_it.rack_itDataSetTableAdapters.scholenTableAdapter();
            this.spelersTableAdapter = new rack_it.rack_itDataSetTableAdapters.spelersTableAdapter();
            this.teamsTableAdapter = new rack_it.rack_itDataSetTableAdapters.teamsTableAdapter();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rack_itDataSet = new rack_it.rack_itDataSet();
            this.scholenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spelersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nummerTextBox = new System.Windows.Forms.TextBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.teams_NaamComboBox = new System.Windows.Forms.ComboBox();
            this.scholen_NaamComboBox = new System.Windows.Forms.ComboBox();
            nummerLabel = new System.Windows.Forms.Label();
            naamLabel = new System.Windows.Forms.Label();
            teams_NaamLabel = new System.Windows.Forms.Label();
            scholen_NaamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scholenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // nummerLabel
            // 
            nummerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            nummerLabel.AutoSize = true;
            nummerLabel.Location = new System.Drawing.Point(34, 104);
            nummerLabel.Name = "nummerLabel";
            nummerLabel.Size = new System.Drawing.Size(63, 17);
            nummerLabel.TabIndex = 3;
            nummerLabel.Text = "nummer:";
            // 
            // naamLabel
            // 
            naamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            naamLabel.AutoSize = true;
            naamLabel.Location = new System.Drawing.Point(34, 132);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(49, 17);
            naamLabel.TabIndex = 5;
            naamLabel.Text = "Naam:";
            // 
            // teams_NaamLabel
            // 
            teams_NaamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            teams_NaamLabel.AutoSize = true;
            teams_NaamLabel.Location = new System.Drawing.Point(34, 160);
            teams_NaamLabel.Name = "teams_NaamLabel";
            teams_NaamLabel.Size = new System.Drawing.Size(96, 17);
            teams_NaamLabel.TabIndex = 7;
            teams_NaamLabel.Text = "Teams Naam:";
            // 
            // scholen_NaamLabel
            // 
            scholen_NaamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            scholen_NaamLabel.AutoSize = true;
            scholen_NaamLabel.Location = new System.Drawing.Point(34, 191);
            scholen_NaamLabel.Name = "scholen_NaamLabel";
            scholen_NaamLabel.Size = new System.Drawing.Size(104, 17);
            scholen_NaamLabel.TabIndex = 9;
            scholen_NaamLabel.Text = "Scholen Naam:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inschrijvingspelersTableAdapter = null;
            this.tableAdapterManager.inschrijvingteamsTableAdapter = null;
            this.tableAdapterManager.locatiesTableAdapter = null;
            this.tableAdapterManager.scholenTableAdapter = this.scholenTableAdapter;
            this.tableAdapterManager.spelersTableAdapter = this.spelersTableAdapter;
            this.tableAdapterManager.teamsTableAdapter = this.teamsTableAdapter;
            this.tableAdapterManager.toernooienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = rack_it.rack_itDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veldenTableAdapter = null;
            this.tableAdapterManager.wedstrijdenTableAdapter = null;
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
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "teams";
            this.teamsBindingSource.DataSource = this.rack_itDataSet;
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
            // spelersBindingSource
            // 
            this.spelersBindingSource.DataMember = "spelers";
            this.spelersBindingSource.DataSource = this.rack_itDataSet;
            // 
            // nummerTextBox
            // 
            this.nummerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spelersBindingSource, "nummer", true));
            this.nummerTextBox.Location = new System.Drawing.Point(144, 101);
            this.nummerTextBox.Name = "nummerTextBox";
            this.nummerTextBox.Size = new System.Drawing.Size(121, 22);
            this.nummerTextBox.TabIndex = 0;
            // 
            // naamTextBox
            // 
            this.naamTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.naamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spelersBindingSource, "Naam", true));
            this.naamTextBox.Location = new System.Drawing.Point(144, 129);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(121, 22);
            this.naamTextBox.TabIndex = 1;
            // 
            // teams_NaamComboBox
            // 
            this.teams_NaamComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.teams_NaamComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.spelersBindingSource, "Teams_Naam", true));
            this.teams_NaamComboBox.DataSource = this.teamsBindingSource;
            this.teams_NaamComboBox.DisplayMember = "Naam";
            this.teams_NaamComboBox.FormattingEnabled = true;
            this.teams_NaamComboBox.Location = new System.Drawing.Point(144, 157);
            this.teams_NaamComboBox.Name = "teams_NaamComboBox";
            this.teams_NaamComboBox.Size = new System.Drawing.Size(121, 24);
            this.teams_NaamComboBox.TabIndex = 2;
            this.teams_NaamComboBox.ValueMember = "Naam";
            // 
            // scholen_NaamComboBox
            // 
            this.scholen_NaamComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.scholen_NaamComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.spelersBindingSource, "Scholen_Naam", true));
            this.scholen_NaamComboBox.DataSource = this.scholenBindingSource;
            this.scholen_NaamComboBox.DisplayMember = "Naam";
            this.scholen_NaamComboBox.FormattingEnabled = true;
            this.scholen_NaamComboBox.Location = new System.Drawing.Point(144, 188);
            this.scholen_NaamComboBox.Name = "scholen_NaamComboBox";
            this.scholen_NaamComboBox.Size = new System.Drawing.Size(121, 24);
            this.scholen_NaamComboBox.TabIndex = 3;
            this.scholen_NaamComboBox.ValueMember = "Naam";
            // 
            // FrmBewerkSpeler
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(332, 403);
            this.Controls.Add(nummerLabel);
            this.Controls.Add(this.nummerTextBox);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(teams_NaamLabel);
            this.Controls.Add(this.teams_NaamComboBox);
            this.Controls.Add(scholen_NaamLabel);
            this.Controls.Add(this.scholen_NaamComboBox);
            this.Name = "FrmBewerkSpeler";
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.scholen_NaamComboBox, 0);
            this.Controls.SetChildIndex(scholen_NaamLabel, 0);
            this.Controls.SetChildIndex(this.teams_NaamComboBox, 0);
            this.Controls.SetChildIndex(teams_NaamLabel, 0);
            this.Controls.SetChildIndex(this.naamTextBox, 0);
            this.Controls.SetChildIndex(naamLabel, 0);
            this.Controls.SetChildIndex(this.nummerTextBox, 0);
            this.Controls.SetChildIndex(nummerLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scholenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private rack_itDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private rack_itDataSetTableAdapters.scholenTableAdapter scholenTableAdapter;
        private System.Windows.Forms.BindingSource scholenBindingSource;
        private rack_itDataSet rack_itDataSet;
        private System.Windows.Forms.BindingSource spelersBindingSource;
        private rack_itDataSetTableAdapters.spelersTableAdapter spelersTableAdapter;
        private System.Windows.Forms.TextBox nummerTextBox;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.ComboBox teams_NaamComboBox;
        private System.Windows.Forms.ComboBox scholen_NaamComboBox;
        private rack_itDataSetTableAdapters.teamsTableAdapter teamsTableAdapter;
    }
}
