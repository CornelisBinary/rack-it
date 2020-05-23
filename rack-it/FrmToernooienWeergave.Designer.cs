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
            this.pnlWeergave = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlWeergave
            // 
            this.pnlWeergave.BackColor = System.Drawing.SystemColors.Control;
            this.pnlWeergave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWeergave.Location = new System.Drawing.Point(100, 50);
            this.pnlWeergave.Name = "pnlWeergave";
            this.pnlWeergave.Size = new System.Drawing.Size(600, 350);
            this.pnlWeergave.TabIndex = 0;
            // 
            // FrmToernooienWeergave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlWeergave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmToernooienWeergave";
            this.Text = "FrmToernooienWeergave";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWeergave;
    }
}