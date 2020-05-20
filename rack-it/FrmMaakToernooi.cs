using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rack_it
{
    public partial class FrmMaakToernooi : rack_it.FrmCreateBase
    {
       
        public FrmMaakToernooi()
        {
            InitializeComponent();
        }

        private void toernooienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.toernooienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rack_itDataSet);

        }

        private void FrmMaakToernooi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rack_itDataSet.locaties' table. You can move, or remove it, as needed.
            this.locatiesTableAdapter.Fill(this.rack_itDataSet.locaties);

            toernooienBindingSource.AddNew();

            locaties_NaamComboBox.DataBindings.Add("SelectedValue", toernooienBindingSource, "Locaties_Naam");

            doelgroepComboBox.Items.AddRange(new object[] { "teams", "spelers" });
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.toernooienBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.rack_itDataSet);

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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
