namespace rack_it
{
    partial class FrmEditWedstrijden
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
            System.Windows.Forms.Label afvalfaseLabel;
            System.Windows.Forms.Label toernooien_NaamLabel;
            System.Windows.Forms.Label nummerLabel;
            System.Windows.Forms.Label velden_NaamLabel;
            System.Windows.Forms.Label eindstandLabel;
            System.Windows.Forms.Label winnaarLabel;
            System.Windows.Forms.Label verliezerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditWedstrijden));
            this.rack_itDataSet = new rack_it.rack_itDataSet();
            this.wedstrijdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wedstrijdenTableAdapter = new rack_it.rack_itDataSetTableAdapters.wedstrijdenTableAdapter();
            this.tableAdapterManager = new rack_it.rack_itDataSetTableAdapters.TableAdapterManager();
            this.wedstrijdenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.afvalfaseTextBox = new System.Windows.Forms.TextBox();
            this.toernooien_NaamTextBox = new System.Windows.Forms.TextBox();
            this.nummerTextBox = new System.Windows.Forms.TextBox();
            this.velden_NaamTextBox = new System.Windows.Forms.TextBox();
            this.eindstandTextBox = new System.Windows.Forms.TextBox();
            this.winnaarTextBox = new System.Windows.Forms.TextBox();
            this.verliezerTextBox = new System.Windows.Forms.TextBox();
            afvalfaseLabel = new System.Windows.Forms.Label();
            toernooien_NaamLabel = new System.Windows.Forms.Label();
            nummerLabel = new System.Windows.Forms.Label();
            velden_NaamLabel = new System.Windows.Forms.Label();
            eindstandLabel = new System.Windows.Forms.Label();
            winnaarLabel = new System.Windows.Forms.Label();
            verliezerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wedstrijdenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wedstrijdenBindingNavigator)).BeginInit();
            this.wedstrijdenBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Text = "Verwerken";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // afvalfaseLabel
            // 
            afvalfaseLabel.AutoSize = true;
            afvalfaseLabel.Location = new System.Drawing.Point(37, 93);
            afvalfaseLabel.Name = "afvalfaseLabel";
            afvalfaseLabel.Size = new System.Drawing.Size(70, 17);
            afvalfaseLabel.TabIndex = 4;
            afvalfaseLabel.Text = "Afvalfase:";
            // 
            // toernooien_NaamLabel
            // 
            toernooien_NaamLabel.AutoSize = true;
            toernooien_NaamLabel.Location = new System.Drawing.Point(37, 121);
            toernooien_NaamLabel.Name = "toernooien_NaamLabel";
            toernooien_NaamLabel.Size = new System.Drawing.Size(126, 17);
            toernooien_NaamLabel.TabIndex = 6;
            toernooien_NaamLabel.Text = "Toernooien Naam:";
            // 
            // nummerLabel
            // 
            nummerLabel.AutoSize = true;
            nummerLabel.Location = new System.Drawing.Point(37, 149);
            nummerLabel.Name = "nummerLabel";
            nummerLabel.Size = new System.Drawing.Size(65, 17);
            nummerLabel.TabIndex = 8;
            nummerLabel.Text = "Nummer:";
            // 
            // velden_NaamLabel
            // 
            velden_NaamLabel.AutoSize = true;
            velden_NaamLabel.Location = new System.Drawing.Point(37, 177);
            velden_NaamLabel.Name = "velden_NaamLabel";
            velden_NaamLabel.Size = new System.Drawing.Size(97, 17);
            velden_NaamLabel.TabIndex = 10;
            velden_NaamLabel.Text = "Velden Naam:";
            // 
            // eindstandLabel
            // 
            eindstandLabel.AutoSize = true;
            eindstandLabel.Location = new System.Drawing.Point(37, 205);
            eindstandLabel.Name = "eindstandLabel";
            eindstandLabel.Size = new System.Drawing.Size(75, 17);
            eindstandLabel.TabIndex = 12;
            eindstandLabel.Text = "Eindstand:";
            // 
            // winnaarLabel
            // 
            winnaarLabel.AutoSize = true;
            winnaarLabel.Location = new System.Drawing.Point(37, 233);
            winnaarLabel.Name = "winnaarLabel";
            winnaarLabel.Size = new System.Drawing.Size(65, 17);
            winnaarLabel.TabIndex = 14;
            winnaarLabel.Text = "Winnaar:";
            // 
            // verliezerLabel
            // 
            verliezerLabel.AutoSize = true;
            verliezerLabel.Location = new System.Drawing.Point(37, 261);
            verliezerLabel.Name = "verliezerLabel";
            verliezerLabel.Size = new System.Drawing.Size(68, 17);
            verliezerLabel.TabIndex = 16;
            verliezerLabel.Text = "Verliezer:";
            // 
            // rack_itDataSet
            // 
            this.rack_itDataSet.DataSetName = "rack_itDataSet";
            this.rack_itDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wedstrijdenBindingSource
            // 
            this.wedstrijdenBindingSource.DataMember = "wedstrijden";
            this.wedstrijdenBindingSource.DataSource = this.rack_itDataSet;
            // 
            // wedstrijdenTableAdapter
            // 
            this.wedstrijdenTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.toernooienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = rack_it.rack_itDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veldenTableAdapter = null;
            this.tableAdapterManager.wedstrijdenTableAdapter = this.wedstrijdenTableAdapter;
            // 
            // wedstrijdenBindingNavigator
            // 
            this.wedstrijdenBindingNavigator.AddNewItem = null;
            this.wedstrijdenBindingNavigator.BindingSource = this.wedstrijdenBindingSource;
            this.wedstrijdenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.wedstrijdenBindingNavigator.DeleteItem = null;
            this.wedstrijdenBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.wedstrijdenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.wedstrijdenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.wedstrijdenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.wedstrijdenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.wedstrijdenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.wedstrijdenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.wedstrijdenBindingNavigator.Name = "wedstrijdenBindingNavigator";
            this.wedstrijdenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.wedstrijdenBindingNavigator.Size = new System.Drawing.Size(332, 27);
            this.wedstrijdenBindingNavigator.TabIndex = 4;
            this.wedstrijdenBindingNavigator.Text = "bindingNavigator1";
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
            // afvalfaseTextBox
            // 
            this.afvalfaseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wedstrijdenBindingSource, "Afvalfase", true));
            this.afvalfaseTextBox.Location = new System.Drawing.Point(169, 90);
            this.afvalfaseTextBox.Name = "afvalfaseTextBox";
            this.afvalfaseTextBox.ReadOnly = true;
            this.afvalfaseTextBox.Size = new System.Drawing.Size(100, 22);
            this.afvalfaseTextBox.TabIndex = 5;
            // 
            // toernooien_NaamTextBox
            // 
            this.toernooien_NaamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wedstrijdenBindingSource, "Toernooien_Naam", true));
            this.toernooien_NaamTextBox.Location = new System.Drawing.Point(169, 118);
            this.toernooien_NaamTextBox.Name = "toernooien_NaamTextBox";
            this.toernooien_NaamTextBox.ReadOnly = true;
            this.toernooien_NaamTextBox.Size = new System.Drawing.Size(100, 22);
            this.toernooien_NaamTextBox.TabIndex = 7;
            // 
            // nummerTextBox
            // 
            this.nummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wedstrijdenBindingSource, "Nummer", true));
            this.nummerTextBox.Location = new System.Drawing.Point(169, 146);
            this.nummerTextBox.Name = "nummerTextBox";
            this.nummerTextBox.ReadOnly = true;
            this.nummerTextBox.Size = new System.Drawing.Size(100, 22);
            this.nummerTextBox.TabIndex = 9;
            // 
            // velden_NaamTextBox
            // 
            this.velden_NaamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wedstrijdenBindingSource, "Velden_Naam", true));
            this.velden_NaamTextBox.Location = new System.Drawing.Point(169, 174);
            this.velden_NaamTextBox.Name = "velden_NaamTextBox";
            this.velden_NaamTextBox.ReadOnly = true;
            this.velden_NaamTextBox.Size = new System.Drawing.Size(100, 22);
            this.velden_NaamTextBox.TabIndex = 11;
            // 
            // eindstandTextBox
            // 
            this.eindstandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wedstrijdenBindingSource, "Eindstand", true));
            this.eindstandTextBox.Location = new System.Drawing.Point(169, 202);
            this.eindstandTextBox.Name = "eindstandTextBox";
            this.eindstandTextBox.Size = new System.Drawing.Size(100, 22);
            this.eindstandTextBox.TabIndex = 13;
            // 
            // winnaarTextBox
            // 
            this.winnaarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wedstrijdenBindingSource, "Winnaar", true));
            this.winnaarTextBox.Location = new System.Drawing.Point(169, 230);
            this.winnaarTextBox.Name = "winnaarTextBox";
            this.winnaarTextBox.Size = new System.Drawing.Size(100, 22);
            this.winnaarTextBox.TabIndex = 15;
            // 
            // verliezerTextBox
            // 
            this.verliezerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wedstrijdenBindingSource, "Verliezer", true));
            this.verliezerTextBox.Location = new System.Drawing.Point(169, 258);
            this.verliezerTextBox.Name = "verliezerTextBox";
            this.verliezerTextBox.Size = new System.Drawing.Size(100, 22);
            this.verliezerTextBox.TabIndex = 17;
            // 
            // FrmEditWedstrijden
            // 
            this.ClientSize = new System.Drawing.Size(332, 403);
            this.Controls.Add(afvalfaseLabel);
            this.Controls.Add(this.afvalfaseTextBox);
            this.Controls.Add(toernooien_NaamLabel);
            this.Controls.Add(this.toernooien_NaamTextBox);
            this.Controls.Add(nummerLabel);
            this.Controls.Add(this.nummerTextBox);
            this.Controls.Add(velden_NaamLabel);
            this.Controls.Add(this.velden_NaamTextBox);
            this.Controls.Add(eindstandLabel);
            this.Controls.Add(this.eindstandTextBox);
            this.Controls.Add(winnaarLabel);
            this.Controls.Add(this.winnaarTextBox);
            this.Controls.Add(verliezerLabel);
            this.Controls.Add(this.verliezerTextBox);
            this.Controls.Add(this.wedstrijdenBindingNavigator);
            this.Name = "FrmEditWedstrijden";
            this.Load += new System.EventHandler(this.FrmEditWedstrijden_Load);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.wedstrijdenBindingNavigator, 0);
            this.Controls.SetChildIndex(this.verliezerTextBox, 0);
            this.Controls.SetChildIndex(verliezerLabel, 0);
            this.Controls.SetChildIndex(this.winnaarTextBox, 0);
            this.Controls.SetChildIndex(winnaarLabel, 0);
            this.Controls.SetChildIndex(this.eindstandTextBox, 0);
            this.Controls.SetChildIndex(eindstandLabel, 0);
            this.Controls.SetChildIndex(this.velden_NaamTextBox, 0);
            this.Controls.SetChildIndex(velden_NaamLabel, 0);
            this.Controls.SetChildIndex(this.nummerTextBox, 0);
            this.Controls.SetChildIndex(nummerLabel, 0);
            this.Controls.SetChildIndex(this.toernooien_NaamTextBox, 0);
            this.Controls.SetChildIndex(toernooien_NaamLabel, 0);
            this.Controls.SetChildIndex(this.afvalfaseTextBox, 0);
            this.Controls.SetChildIndex(afvalfaseLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wedstrijdenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wedstrijdenBindingNavigator)).EndInit();
            this.wedstrijdenBindingNavigator.ResumeLayout(false);
            this.wedstrijdenBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private rack_itDataSet rack_itDataSet;
        private System.Windows.Forms.BindingSource wedstrijdenBindingSource;
        private rack_itDataSetTableAdapters.wedstrijdenTableAdapter wedstrijdenTableAdapter;
        private rack_itDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator wedstrijdenBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox afvalfaseTextBox;
        private System.Windows.Forms.TextBox toernooien_NaamTextBox;
        private System.Windows.Forms.TextBox nummerTextBox;
        private System.Windows.Forms.TextBox velden_NaamTextBox;
        private System.Windows.Forms.TextBox eindstandTextBox;
        private System.Windows.Forms.TextBox winnaarTextBox;
        private System.Windows.Forms.TextBox verliezerTextBox;
    }
}
