namespace rack_it
{
    partial class FrmMaakToernooi
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
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label naamLabel;
            System.Windows.Forms.Label locaties_NaamLabel;
            System.Windows.Forms.Label doelgroepLabel;
            this.rack_itDataSet = new rack_it.rack_itDataSet();
            this.toernooienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toernooienTableAdapter = new rack_it.rack_itDataSetTableAdapters.toernooienTableAdapter();
            this.tableAdapterManager = new rack_it.rack_itDataSetTableAdapters.TableAdapterManager();
            this.locatiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locatiesTableAdapter = new rack_it.rack_itDataSetTableAdapters.locatiesTableAdapter();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.locaties_NaamComboBox = new System.Windows.Forms.ComboBox();
            this.doelgroepComboBox = new System.Windows.Forms.ComboBox();
            datumLabel = new System.Windows.Forms.Label();
            naamLabel = new System.Windows.Forms.Label();
            locaties_NaamLabel = new System.Windows.Forms.Label();
            doelgroepLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toernooienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(13, 183);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(53, 17);
            datumLabel.TabIndex = 5;
            datumLabel.Text = "Datum:";
            // 
            // naamLabel
            // 
            naamLabel.AutoSize = true;
            naamLabel.Location = new System.Drawing.Point(13, 126);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(49, 17);
            naamLabel.TabIndex = 3;
            naamLabel.Text = "Naam:";
            // 
            // locaties_NaamLabel
            // 
            locaties_NaamLabel.AutoSize = true;
            locaties_NaamLabel.Location = new System.Drawing.Point(13, 209);
            locaties_NaamLabel.Name = "locaties_NaamLabel";
            locaties_NaamLabel.Size = new System.Drawing.Size(58, 17);
            locaties_NaamLabel.TabIndex = 6;
            locaties_NaamLabel.Text = "Locatie:";
            // 
            // rack_itDataSet
            // 
            this.rack_itDataSet.DataSetName = "rack_itDataSet";
            this.rack_itDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toernooienBindingSource
            // 
            this.toernooienBindingSource.DataMember = "toernooien";
            this.toernooienBindingSource.DataSource = this.rack_itDataSet;
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
            this.tableAdapterManager.schoolTableAdapter = null;
            this.tableAdapterManager.spelersTableAdapter = null;
            this.tableAdapterManager.teamsTableAdapter = null;
            this.tableAdapterManager.toernooienTableAdapter = this.toernooienTableAdapter;
            this.tableAdapterManager.UpdateOrder = rack_it.rack_itDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veldenTableAdapter = null;
            this.tableAdapterManager.wedstrijdenTableAdapter = null;
            // 
            // locatiesBindingSource
            // 
            this.locatiesBindingSource.DataMember = "locaties";
            this.locatiesBindingSource.DataSource = this.rack_itDataSet;
            // 
            // locatiesTableAdapter
            // 
            this.locatiesTableAdapter.ClearBeforeFill = true;
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.toernooienBindingSource, "Datum", true));
            this.datumDateTimePicker.Location = new System.Drawing.Point(125, 179);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.datumDateTimePicker.TabIndex = 6;
            // 
            // naamTextBox
            // 
            this.naamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toernooienBindingSource, "Naam", true));
            this.naamTextBox.Location = new System.Drawing.Point(125, 123);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(200, 22);
            this.naamTextBox.TabIndex = 4;
            // 
            // locaties_NaamComboBox
            // 
            this.locaties_NaamComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toernooienBindingSource, "Locaties_Naam", true));
            this.locaties_NaamComboBox.DataSource = this.locatiesBindingSource;
            this.locaties_NaamComboBox.DisplayMember = "Naam";
            this.locaties_NaamComboBox.FormattingEnabled = true;
            this.locaties_NaamComboBox.Location = new System.Drawing.Point(125, 206);
            this.locaties_NaamComboBox.Name = "locaties_NaamComboBox";
            this.locaties_NaamComboBox.Size = new System.Drawing.Size(200, 24);
            this.locaties_NaamComboBox.TabIndex = 7;
            this.locaties_NaamComboBox.ValueMember = "Naam";
            // 
            // doelgroepLabel
            // 
            doelgroepLabel.AutoSize = true;
            doelgroepLabel.Location = new System.Drawing.Point(13, 153);
            doelgroepLabel.Name = "doelgroepLabel";
            doelgroepLabel.Size = new System.Drawing.Size(78, 17);
            doelgroepLabel.TabIndex = 9;
            doelgroepLabel.Text = "Doelgroep:";
            // 
            // doelgroepComboBox
            // 
            this.doelgroepComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toernooienBindingSource, "Doelgroep", true));
            this.doelgroepComboBox.FormattingEnabled = true;
            this.doelgroepComboBox.Location = new System.Drawing.Point(125, 150);
            this.doelgroepComboBox.Name = "doelgroepComboBox";
            this.doelgroepComboBox.Size = new System.Drawing.Size(200, 24);
            this.doelgroepComboBox.TabIndex = 5;
            // 
            // FrmMaakToernooi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(332, 403);
            this.Controls.Add(doelgroepLabel);
            this.Controls.Add(this.doelgroepComboBox);
            this.Controls.Add(locaties_NaamLabel);
            this.Controls.Add(this.locaties_NaamComboBox);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.datumDateTimePicker);
            this.Name = "FrmMaakToernooi";
            this.Load += new System.EventHandler(this.FrmMaakToernooi_Load);
            this.Controls.SetChildIndex(this.datumDateTimePicker, 0);
            this.Controls.SetChildIndex(datumLabel, 0);
            this.Controls.SetChildIndex(this.naamTextBox, 0);
            this.Controls.SetChildIndex(naamLabel, 0);
            this.Controls.SetChildIndex(this.locaties_NaamComboBox, 0);
            this.Controls.SetChildIndex(locaties_NaamLabel, 0);
            this.Controls.SetChildIndex(this.btnCreate, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.doelgroepComboBox, 0);
            this.Controls.SetChildIndex(doelgroepLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toernooienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private rack_itDataSet rack_itDataSet;
        private System.Windows.Forms.BindingSource toernooienBindingSource;
        private rack_itDataSetTableAdapters.toernooienTableAdapter toernooienTableAdapter;
        private rack_itDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource locatiesBindingSource;
        private rack_itDataSetTableAdapters.locatiesTableAdapter locatiesTableAdapter;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.ComboBox locaties_NaamComboBox;
        private System.Windows.Forms.ComboBox doelgroepComboBox;
    }
}
