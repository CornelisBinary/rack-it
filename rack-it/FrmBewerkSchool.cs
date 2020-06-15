using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rack_it
{
    public partial class FrmBewerkSchool : rack_it.FrmEditBase
    {
        public FrmBewerkSchool(int index)
        {
            InitializeComponent();

            this.scholenTableAdapter.Fill(this.rack_itDataSet.scholen);

            scholenBindingSource.Position = index;

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                scholenBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.rack_itDataSet);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
          
        }
    }
}
