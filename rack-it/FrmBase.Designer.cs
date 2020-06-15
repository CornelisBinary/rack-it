namespace rack_it
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEinde = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnToernooien = new System.Windows.Forms.Button();
            this.btnSpelers = new System.Windows.Forms.Button();
            this.btnTeams = new System.Windows.Forms.Button();
            this.btnScholen = new System.Windows.Forms.Button();
            this.btnHoofdscherm = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.btnEinde);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(109, 478);
            this.panel5.TabIndex = 4;
            // 
            // btnEinde
            // 
            this.btnEinde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEinde.BackColor = System.Drawing.Color.LightCoral;
            this.btnEinde.Location = new System.Drawing.Point(3, 452);
            this.btnEinde.Name = "btnEinde";
            this.btnEinde.Size = new System.Drawing.Size(103, 26);
            this.btnEinde.TabIndex = 6;
            this.btnEinde.Text = "Einde";
            this.btnEinde.UseVisualStyleBackColor = false;
            this.btnEinde.Click += new System.EventHandler(this.btnEinde_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MintCream;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(109, 38);
            this.panel7.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel6.Controls.Add(this.btnToernooien);
            this.panel6.Controls.Add(this.btnSpelers);
            this.panel6.Controls.Add(this.btnTeams);
            this.panel6.Controls.Add(this.btnScholen);
            this.panel6.Controls.Add(this.btnHoofdscherm);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(109, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(838, 38);
            this.panel6.TabIndex = 5;
            // 
            // btnToernooien
            // 
            this.btnToernooien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnToernooien.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnToernooien.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnToernooien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToernooien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToernooien.ForeColor = System.Drawing.SystemColors.Control;
            this.btnToernooien.Location = new System.Drawing.Point(181, 2);
            this.btnToernooien.Margin = new System.Windows.Forms.Padding(30, 1, 20, 1);
            this.btnToernooien.Name = "btnToernooien";
            this.btnToernooien.Size = new System.Drawing.Size(150, 34);
            this.btnToernooien.TabIndex = 4;
            this.btnToernooien.Text = "Toernooien";
            this.btnToernooien.UseVisualStyleBackColor = false;
            this.btnToernooien.Click += new System.EventHandler(this.btnToernooien_Click);
            // 
            // btnSpelers
            // 
            this.btnSpelers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSpelers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSpelers.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSpelers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpelers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpelers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSpelers.Location = new System.Drawing.Point(679, 2);
            this.btnSpelers.Margin = new System.Windows.Forms.Padding(30, 1, 20, 1);
            this.btnSpelers.Name = "btnSpelers";
            this.btnSpelers.Size = new System.Drawing.Size(150, 34);
            this.btnSpelers.TabIndex = 3;
            this.btnSpelers.Text = "Spelers";
            this.btnSpelers.UseVisualStyleBackColor = false;
            this.btnSpelers.Click += new System.EventHandler(this.btnSpelers_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTeams.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTeams.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeams.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTeams.Location = new System.Drawing.Point(513, 2);
            this.btnTeams.Margin = new System.Windows.Forms.Padding(30, 1, 20, 1);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(150, 34);
            this.btnTeams.TabIndex = 2;
            this.btnTeams.Text = "Teams";
            this.btnTeams.UseVisualStyleBackColor = false;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // btnScholen
            // 
            this.btnScholen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnScholen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnScholen.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnScholen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScholen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScholen.ForeColor = System.Drawing.SystemColors.Control;
            this.btnScholen.Location = new System.Drawing.Point(347, 2);
            this.btnScholen.Margin = new System.Windows.Forms.Padding(30, 1, 20, 1);
            this.btnScholen.Name = "btnScholen";
            this.btnScholen.Size = new System.Drawing.Size(150, 34);
            this.btnScholen.TabIndex = 1;
            this.btnScholen.Text = "Scholen";
            this.btnScholen.UseVisualStyleBackColor = false;
            this.btnScholen.Click += new System.EventHandler(this.btnScholen_Click);
            // 
            // btnHoofdscherm
            // 
            this.btnHoofdscherm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHoofdscherm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHoofdscherm.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnHoofdscherm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoofdscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoofdscherm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHoofdscherm.Location = new System.Drawing.Point(15, 2);
            this.btnHoofdscherm.Margin = new System.Windows.Forms.Padding(30, 1, 20, 1);
            this.btnHoofdscherm.Name = "btnHoofdscherm";
            this.btnHoofdscherm.Size = new System.Drawing.Size(150, 34);
            this.btnHoofdscherm.TabIndex = 0;
            this.btnHoofdscherm.Text = "Hoofdscherm";
            this.btnHoofdscherm.UseVisualStyleBackColor = false;
            this.btnHoofdscherm.Click += new System.EventHandler(this.btnHoofdscherm_Click);
            // 
            // FrmBase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(947, 478);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmBase";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Rack-It";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnEinde;
        private System.Windows.Forms.Button btnSpelers;
        private System.Windows.Forms.Button btnTeams;
        private System.Windows.Forms.Button btnScholen;
        private System.Windows.Forms.Button btnHoofdscherm;
        private System.Windows.Forms.Button btnToernooien;
    }
}

