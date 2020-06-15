using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rack_it
{
    public partial class FrmMaakTeam : rack_it.FrmCreateBase
    {
        public FrmMaakTeam()
        {
            InitializeComponent();
        }

        private void teamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rack_itDataSet);

        }

        private void FrmMaakTeam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rack_itDataSet.teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.rack_itDataSet.teams);

            teamsBindingSource.AddNew();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                teamsBindingSource.EndEdit();
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
