namespace rack_it
{
    partial class FrmToernooienWeergave
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
            this.pnlAanmelden = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHandmatig = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.pnlToernooi = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbAfvalschema = new System.Windows.Forms.PictureBox();
            this.toernooienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rack_itDataSet = new rack_it.rack_itDataSet();
            this.toernooienTableAdapter = new rack_it.rack_itDataSetTableAdapters.toernooienTableAdapter();
            this.tableAdapterManager = new rack_it.rack_itDataSetTableAdapters.TableAdapterManager();
            this.inschrijvingspelersTableAdapter = new rack_it.rack_itDataSetTableAdapters.inschrijvingspelersTableAdapter();
            this.inschrijvingteamsTableAdapter = new rack_it.rack_itDataSetTableAdapters.inschrijvingteamsTableAdapter();
            this.spelersTableAdapter = new rack_it.rack_itDataSetTableAdapters.spelersTableAdapter();
            this.veldenTableAdapter = new rack_it.rack_itDataSetTableAdapters.veldenTableAdapter();
            this.wedstrijdenTableAdapter = new rack_it.rack_itDataSetTableAdapters.wedstrijdenTableAdapter();
            this.btnAanmelden = new System.Windows.Forms.Button();
            this.btnToernooi = new System.Windows.Forms.Button();
            this.pnlAanmelden.SuspendLayout();
            this.pnlToernooi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfvalschema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toernooienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAanmelden
            // 
            this.pnlAanmelden.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlAanmelden.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAanmelden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAanmelden.Controls.Add(this.label1);
            this.pnlAanmelden.Controls.Add(this.btnHandmatig);
            this.pnlAanmelden.Controls.Add(this.btnXML);
            this.pnlAanmelden.Location = new System.Drawing.Point(100, 50);
            this.pnlAanmelden.Name = "pnlAanmelden";
            this.pnlAanmelden.Size = new System.Drawing.Size(600, 350);
            this.pnlAanmelden.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aanmelden";
            // 
            // btnHandmatig
            // 
            this.btnHandmatig.Location = new System.Drawing.Point(197, 106);
            this.btnHandmatig.Name = "btnHandmatig";
            this.btnHandmatig.Size = new System.Drawing.Size(100, 25);
            this.btnHandmatig.TabIndex = 1;
            this.btnHandmatig.Text = "Handmatig";
            this.btnHandmatig.UseVisualStyleBackColor = true;
            this.btnHandmatig.Click += new System.EventHandler(this.btnHandmatig_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(77, 106);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(100, 25);
            this.btnXML.TabIndex = 0;
            this.btnXML.Text = "XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // pnlToernooi
            // 
            this.pnlToernooi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlToernooi.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlToernooi.Controls.Add(this.button8);
            this.pnlToernooi.Controls.Add(this.button7);
            this.pnlToernooi.Controls.Add(this.button6);
            this.pnlToernooi.Controls.Add(this.button5);
            this.pnlToernooi.Controls.Add(this.button4);
            this.pnlToernooi.Controls.Add(this.button3);
            this.pnlToernooi.Controls.Add(this.button2);
            this.pnlToernooi.Controls.Add(this.button1);
            this.pnlToernooi.Controls.Add(this.pbAfvalschema);
            this.pnlToernooi.Location = new System.Drawing.Point(100, 50);
            this.pnlToernooi.Name = "pnlToernooi";
            this.pnlToernooi.Size = new System.Drawing.Size(600, 350);
            this.pnlToernooi.TabIndex = 9;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(525, 310);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 30);
            this.button8.TabIndex = 11;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(450, 310);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 30);
            this.button7.TabIndex = 10;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(375, 310);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 9;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(300, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(225, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "afvalschema";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbAfvalschema
            // 
            this.pbAfvalschema.BackColor = System.Drawing.Color.Black;
            this.pbAfvalschema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAfvalschema.Location = new System.Drawing.Point(0, 0);
            this.pbAfvalschema.Name = "pbAfvalschema";
            this.pbAfvalschema.Size = new System.Drawing.Size(600, 300);
            this.pbAfvalschema.TabIndex = 3;
            this.pbAfvalschema.TabStop = false;
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
            // toernooienTableAdapter
            // 
            this.toernooienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inschrijvingspelersTableAdapter = this.inschrijvingspelersTableAdapter;
            this.tableAdapterManager.inschrijvingteamsTableAdapter = this.inschrijvingteamsTableAdapter;
            this.tableAdapterManager.locatiesTableAdapter = null;
            this.tableAdapterManager.scholenTableAdapter = null;
            this.tableAdapterManager.spelersTableAdapter = this.spelersTableAdapter;
            this.tableAdapterManager.teamsTableAdapter = null;
            this.tableAdapterManager.toernooienTableAdapter = this.toernooienTableAdapter;
            this.tableAdapterManager.UpdateOrder = rack_it.rack_itDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veldenTableAdapter = this.veldenTableAdapter;
            this.tableAdapterManager.wedstrijdenTableAdapter = this.wedstrijdenTableAdapter;
            // 
            // inschrijvingspelersTableAdapter
            // 
            this.inschrijvingspelersTableAdapter.ClearBeforeFill = true;
            // 
            // inschrijvingteamsTableAdapter
            // 
            this.inschrijvingteamsTableAdapter.ClearBeforeFill = true;
            // 
            // spelersTableAdapter
            // 
            this.spelersTableAdapter.ClearBeforeFill = true;
            // 
            // veldenTableAdapter
            // 
            this.veldenTableAdapter.ClearBeforeFill = true;
            // 
            // wedstrijdenTableAdapter
            // 
            this.wedstrijdenTableAdapter.ClearBeforeFill = true;
            // 
            // btnAanmelden
            // 
            this.btnAanmelden.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAanmelden.Enabled = false;
            this.btnAanmelden.Location = new System.Drawing.Point(100, 21);
            this.btnAanmelden.Name = "btnAanmelden";
            this.btnAanmelden.Size = new System.Drawing.Size(100, 25);
            this.btnAanmelden.TabIndex = 10;
            this.btnAanmelden.Text = "Aanmelden";
            this.btnAanmelden.UseVisualStyleBackColor = true;
            this.btnAanmelden.Click += new System.EventHandler(this.btnAanmelden_Click);
            // 
            // btnToernooi
            // 
            this.btnToernooi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnToernooi.Enabled = false;
            this.btnToernooi.Location = new System.Drawing.Point(206, 21);
            this.btnToernooi.Name = "btnToernooi";
            this.btnToernooi.Size = new System.Drawing.Size(100, 25);
            this.btnToernooi.TabIndex = 11;
            this.btnToernooi.Text = "Toernooi";
            this.btnToernooi.UseVisualStyleBackColor = true;
            this.btnToernooi.Click += new System.EventHandler(this.btnToernooi_Click);
            // 
            // FrmToernooienWeergave
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToernooi);
            this.Controls.Add(this.btnAanmelden);
            this.Controls.Add(this.pnlToernooi);
            this.Controls.Add(this.pnlAanmelden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmToernooienWeergave";
            this.Text = "FrmToernooienWeergave";
            this.Load += new System.EventHandler(this.FrmToernooienWeergave_Load);
            this.pnlAanmelden.ResumeLayout(false);
            this.pnlAanmelden.PerformLayout();
            this.pnlToernooi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAfvalschema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toernooienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rack_itDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAanmelden;
        private rack_itDataSet rack_itDataSet;
        private System.Windows.Forms.BindingSource toernooienBindingSource;
        private rack_itDataSetTableAdapters.toernooienTableAdapter toernooienTableAdapter;
        private rack_itDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel pnlToernooi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHandmatig;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.PictureBox pbAfvalschema;
        private rack_itDataSetTableAdapters.wedstrijdenTableAdapter wedstrijdenTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private rack_itDataSetTableAdapters.inschrijvingspelersTableAdapter inschrijvingspelersTableAdapter;
        private rack_itDataSetTableAdapters.inschrijvingteamsTableAdapter inschrijvingteamsTableAdapter;
        internal rack_itDataSetTableAdapters.veldenTableAdapter veldenTableAdapter;
        private rack_itDataSetTableAdapters.spelersTableAdapter spelersTableAdapter;
        private System.Windows.Forms.Button btnAanmelden;
        private System.Windows.Forms.Button btnToernooi;
    }
}