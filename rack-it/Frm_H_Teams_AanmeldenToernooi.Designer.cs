namespace rack_it
{
    partial class Frm_H_Teams_AanmeldenToernooi
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
            System.Windows.Forms.Label teams_NaamLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_H_Teams_AanmeldenToernooi));
            this.rack_itDataSet = new rack_it.rack_itDataSet();
            this.inschrijvingteamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inschrijvingteamsTableAdapter = new rack_it.rack_itDataSetTableAdapters.inschrijvingteamsTableAdapter();
            this.tableAdapterManager = new rack_it.rack_itDataSetTableAdapters.TableAdapterManager();
            this.inschrijvingteamsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.teams_NaamComboBox = new System.Windows.Forms.ComboBox();
            this.bindingNavigatorRemoveItem = new System.Windows.Forms.ToolStripButton();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new rack_it.rack_itDataSetTableAdapters.teamsTableAdapter();
            toernooien_NaamLabel = new System.Windows.Forms.Label();
            teams_NaamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inschrijvingteamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inschrijvingteamsBindingNavigator)).BeginInit();
            this.inschrijvingteamsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
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
            // teams_NaamLabel
            // 
            teams_NaamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            teams_NaamLabel.AutoSize = true;
            teams_NaamLabel.Location = new System.Drawing.Point(25, 173);
            teams_NaamLabel.Name = "teams_NaamLabel";
            teams_NaamLabel.Size = new System.Drawing.Size(96, 17);
            teams_NaamLabel.TabIndex = 6;
            teams_NaamLabel.Text = "Teams Naam:";
            // 
            // rack_itDataSet
            // 
            this.rack_itDataSet.DataSetName = "rack_itDataSet";
            this.rack_itDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inschrijvingteamsBindingSource
            // 
            this.inschrijvingteamsBindingSource.DataMember = "inschrijvingteams";
            this.inschrijvingteamsBindingSource.DataSource = this.rack_itDataSet;
            // 
            // inschrijvingteamsTableAdapter
            // 
            this.inschrijvingteamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inschrijvingspelersTableAdapter = null;
            this.tableAdapterManager.inschrijvingteamsTableAdapter = this.inschrijvingteamsTableAdapter;
            this.tableAdapterManager.locatiesTableAdapter = null;
            this.tableAdapterManager.scholenTableAdapter = null;
            this.tableAdapterManager.spelersTableAdapter = null;
            this.tableAdapterManager.teamsTableAdapter = null;
            this.tableAdapterManager.toernooienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = rack_it.rack_itDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veldenTableAdapter = null;
            this.tableAdapterManager.wedstrijdenTableAdapter = null;
            // 
            // inschrijvingteamsBindingNavigator
            // 
            this.inschrijvingteamsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inschrijvingteamsBindingNavigator.BindingSource = this.inschrijvingteamsBindingSource;
            this.inschrijvingteamsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inschrijvingteamsBindingNavigator.DeleteItem = this.bindingNavigatorRemoveItem;
            this.inschrijvingteamsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.inschrijvingteamsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.inschrijvingteamsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inschrijvingteamsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inschrijvingteamsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inschrijvingteamsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inschrijvingteamsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inschrijvingteamsBindingNavigator.Name = "inschrijvingteamsBindingNavigator";
            this.inschrijvingteamsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inschrijvingteamsBindingNavigator.Size = new System.Drawing.Size(332, 27);
            this.inschrijvingteamsBindingNavigator.TabIndex = 4;
            this.inschrijvingteamsBindingNavigator.Text = "bindingNavigator1";
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
            this.toernooien_NaamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inschrijvingteamsBindingSource, "Toernooien_Naam", true));
            this.toernooien_NaamTextBox.Location = new System.Drawing.Point(157, 142);
            this.toernooien_NaamTextBox.Name = "toernooien_NaamTextBox";
            this.toernooien_NaamTextBox.ReadOnly = true;
            this.toernooien_NaamTextBox.Size = new System.Drawing.Size(121, 22);
            this.toernooien_NaamTextBox.TabIndex = 5;
            // 
            // teams_NaamComboBox
            // 
            this.teams_NaamComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.teams_NaamComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.inschrijvingteamsBindingSource, "Teams_Naam", true));
            this.teams_NaamComboBox.DataSource = this.teamsBindingSource;
            this.teams_NaamComboBox.DisplayMember = "Naam";
            this.teams_NaamComboBox.FormattingEnabled = true;
            this.teams_NaamComboBox.Location = new System.Drawing.Point(157, 170);
            this.teams_NaamComboBox.Name = "teams_NaamComboBox";
            this.teams_NaamComboBox.Size = new System.Drawing.Size(121, 24);
            this.teams_NaamComboBox.TabIndex = 7;
            this.teams_NaamComboBox.ValueMember = "Naam";
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
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "teams";
            this.teamsBindingSource.DataSource = this.rack_itDataSet;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_H_Teams_AanmeldenToernooi
            // 
            this.ClientSize = new System.Drawing.Size(332, 403);
            this.Controls.Add(toernooien_NaamLabel);
            this.Controls.Add(this.toernooien_NaamTextBox);
            this.Controls.Add(teams_NaamLabel);
            this.Controls.Add(this.teams_NaamComboBox);
            this.Controls.Add(this.inschrijvingteamsBindingNavigator);
            this.Name = "Frm_H_Teams_AanmeldenToernooi";
            this.Load += new System.EventHandler(this.Frm_H_Teams_AanmeldenToernooi_Load);
            this.Controls.SetChildIndex(this.btnCreate, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.inschrijvingteamsBindingNavigator, 0);
            this.Controls.SetChildIndex(this.teams_NaamComboBox, 0);
            this.Controls.SetChildIndex(teams_NaamLabel, 0);
            this.Controls.SetChildIndex(this.toernooien_NaamTextBox, 0);
            this.Controls.SetChildIndex(toernooien_NaamLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inschrijvingteamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inschrijvingteamsBindingNavigator)).EndInit();
            this.inschrijvingteamsBindingNavigator.ResumeLayout(false);
            this.inschrijvingteamsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private rack_itDataSet rack_itDataSet;
        private System.Windows.Forms.BindingSource inschrijvingteamsBindingSource;
        private rack_itDataSetTableAdapters.inschrijvingteamsTableAdapter inschrijvingteamsTableAdapter;
        private rack_itDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inschrijvingteamsBindingNavigator;
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
        private System.Windows.Forms.ComboBox teams_NaamComboBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRemoveItem;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private rack_itDataSetTableAdapters.teamsTableAdapter teamsTableAdapter;
    }
}
