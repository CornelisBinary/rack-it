using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rack_it
{
    public partial class FrmMaakSchool : rack_it.FrmCreateBase
    {
        public FrmMaakSchool()
        {
            InitializeComponent();
        }

        private void scholenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scholenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rack_itDataSet);

        }

        private void FrmMaakSchool_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rack_itDataSet.scholen' table. You can move, or remove it, as needed.
            this.scholenTableAdapter.Fill(this.rack_itDataSet.scholen);

            scholenBindingSource.AddNew();
        }

        private void btnCreate_Click(object sender, EventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
