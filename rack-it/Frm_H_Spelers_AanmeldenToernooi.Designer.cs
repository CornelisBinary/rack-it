namespace rack_it
{
    partial class Frm_H_Spelers_AanmeldenToernooi
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
            System.Windows.Forms.Label toernooien_NaamLabel;
            System.Windows.Forms.Label spelers_nummerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_H_Spelers_AanmeldenToernooi));
            this.rack_itDataSet = new rack_it.rack_itDataSet();
            this.inschrijvingspelersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inschrijvingspelersTableAdapter = new rack_it.rack_itDataSetTableAdapters.inschrijvingspelersTableAdapter();
            this.tableAdapterManager = new rack_it.rack_itDataSetTableAdapters.TableAdapterManager();
            this.spelersTableAdapter = new rack_it.rack_itDataSetTableAdapters.spelersTableAdapter();
            this.inschrijvingspelersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toernooien_NaamTextBox = new System.Windows.Forms.TextBox();
            this.spelers_nummerComboBox = new System.Windows.Forms.ComboBox();
            this.spelersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorRemoveItem = new System.Windows.Forms.ToolStripButton();
            toernooien_NaamLabel = new System.Windows.Forms.Label();
            spelers_nummerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inschrijvingspelersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inschrijvingspelersBindingNavigator)).BeginInit();
            this.inschrijvingspelersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spelersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // toernooien_NaamLabel
            // 
            toernooien_NaamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            toernooien_NaamLabel.AutoSize = true;
            toernooien_NaamLabel.Location = new System.Drawing.Point(25, 145);
            toernooien_NaamLabel.Name = "toernooien_NaamLabel";
            toernooien_NaamLabel.Size = new System.Drawing.Size(126, 17);
            toernooien_NaamLabel.TabIndex = 4;
            toernooien_NaamLabel.Text = "Toernooien Naam:";
            // 
            // spelers_nummerLabel
            // 
            spelers_nummerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            spelers_nummerLabel.AutoSize = true;
            spelers_nummerLabel.Location = new System.Drawing.Point(25, 173);
            spelers_nummerLabel.Name = "spelers_nummerLabel";
            spelers_nummerLabel.Size = new System.Drawing.Size(115, 17);
            spelers_nummerLabel.TabIndex = 6;
            spelers_nummerLabel.Text = "Spelers nummer:";
            // 
            // rack_itDataSet
            // 
            this.rack_itDataSet.DataSetName = "rack_itDataSet";
            this.rack_itDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inschrijvingspelersBindingSource
            // 
            this.inschrijvingspelersBindingSource.DataMember = "inschrijvingspelers";
            this.inschrijvingspelersBindingSource.DataSource = this.rack_itDataSet;
            // 
            // inschrijvingspelersTableAdapter
            // 
            this.inschrijvingspelersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inschrijvingspelersTableAdapter = this.inschrijvingspelersTableAdapter;
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
            // spelersTableAdapter
            // 
            this.spelersTableAdapter.ClearBeforeFill = true;
            // 
            // inschrijvingspelersBindingNavigator
            // 
            this.inschrijvingspelersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inschrijvingspelersBindingNavigator.BindingSource = this.inschrijvingspelersBindingSource;
            this.inschrijvingspelersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inschrijvingspelersBindingNavigator.DeleteItem = this.bindingNavigatorRemoveItem;
            this.inschrijvingspelersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.inschrijvingspelersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorRemoveItem});
            this.inschrijvingspelersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inschrijvingspelersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inschrijvingspelersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inschrijvingspelersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inschrijvingspelersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inschrijvingspelersBindingNavigator.Name = "inschrijvingspelersBindingNavigator";
            this.inschrijvingspelersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inschrijvingspelersBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.inschrijvingspelersBindingNavigator.Size = new System.Drawing.Size(332, 27);
            this.inschrijvingspelersBindingNavigator.TabIndex = 4;
            this.inschrijvingspelersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toernooien_NaamTextBox
            // 
            this.toernooien_NaamTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.toernooien_NaamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inschrijvingspelersBindingSource, "Toernooien_Naam", true));
            this.toernooien_NaamTextBox.Location = new System.Drawing.Point(157, 142);
            this.toernooien_NaamTextBox.Name = "toernooien_NaamTextBox";
            this.toernooien_NaamTextBox.ReadOnly = true;
            this.toernooien_NaamTextBox.Size = new System.Drawing.Size(121, 22);
            this.toernooien_NaamTextBox.TabIndex = 5;
            // 
            // spelers_nummerComboBox
            // 
            this.spelers_nummerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.spelers_nummerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.inschrijvingspelersBindingSource, "Spelers_nummer", true));
            this.spelers_nummerComboBox.DataSource = this.spelersBindingSource;
            this.spelers_nummerComboBox.DisplayMember = "Naam";
            this.spelers_nummerComboBox.FormattingEnabled = true;
            this.spelers_nummerComboBox.Location = new System.Drawing.Point(157, 170);
            this.spelers_nummerComboBox.Name = "spelers_nummerComboBox";
            this.spelers_nummerComboBox.Size = new System.Drawing.Size(121, 24);
            this.spelers_nummerComboBox.TabIndex = 7;
            this.spelers_nummerComboBox.ValueMember = "nummer";
            // 
            // spelersBindingSource
            // 
            this.spelersBindingSource.DataMember = "spelers";
            this.spelersBindingSource.DataSource = this.rack_itDataSet;
            // 
            // bindingNavigatorRemoveItem
            // 
            this.bindingNavigatorRemoveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorRemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorRemoveItem.Image")));
            this.bindingNavigatorRemoveItem.Name = "bindingNavigatorRemoveItem";
            this.bindingNavigatorRemoveItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorRemoveItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorRemoveItem.Text = "Delete";
            // 
            // Frm_H_Spelers_AanmeldenToernooi
            // 
            this.ClientSize = new System.Drawing.Size(332, 403);
            this.Controls.Add(toernooien_NaamLabel);
            this.Controls.Add(this.toernooien_NaamTextBox);
            this.Controls.Add(spelers_nummerLabel);
            this.Controls.Add(this.spelers_nummerComboBox);
            this.Controls.Add(this.inschrijvingspelersBindingNavigator);
            this.Name = "Frm_H_Spelers_AanmeldenToernooi";
            this.Load += new System.EventHandler(this.Frm_H_AanmeldenToernooi_Load);
            this.Controls.SetChildIndex(this.inschrijvingspelersBindingNavigator, 0);
            this.Controls.SetChildIndex(this.spelers_nummerComboBox, 0);
            this.Controls.SetChildIndex(spelers_nummerLabel, 0);
            this.Controls.SetChildIndex(this.toernooien_NaamTextBox, 0);
            this.Controls.SetChildIndex(toernooien_NaamLabel, 0);
            this.Controls.SetChildIndex(this.btnCreate, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inschrijvingspelersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inschrijvingspelersBindingNavigator)).EndInit();
            this.inschrijvingspelersBindingNavigator.ResumeLayout(false);
            this.inschrijvingspelersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spelersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private rack_itDataSet rack_itDataSet;
        private System.Windows.Forms.BindingSource inschrijvingspelersBindingSource;
        private rack_itDataSetTableAdapters.inschrijvingspelersTableAdapter inschrijvingspelersTableAdapter;
        private rack_itDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox toernooien_NaamTextBox;
        private System.Windows.Forms.ComboBox spelers_nummerComboBox;
        private rack_itDataSetTableAdapters.spelersTableAdapter spelersTableAdapter;
        private System.Windows.Forms.BindingSource spelersBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRemoveItem;
        protected System.Windows.Forms.BindingNavigator inschrijvingspelersBindingNavigator;
    }
}
