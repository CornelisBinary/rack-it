using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rack_it
{
    public partial class FrmMaakSpeler : rack_it.FrmCreateBase
    {
        public FrmMaakSpeler()
        {
            InitializeComponent();
        }

        private void spelersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.spelersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rack_itDataSet);

        }

        private void spelersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.spelersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rack_itDataSet);

        }

        private void FrmMaakSpeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rack_itDataSet.scholen' table. You can move, or remove it, as needed.
            this.scholenTableAdapter.Fill(this.rack_itDataSet.scholen);
            // TODO: This line of code loads data into the 'rack_itDataSet.teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.rack_itDataSet.teams);
            // TODO: This line of code loads data into the 'rack_itDataSet.spelers' table. You can move, or remove it, as needed.
            this.spelersTableAdapter.Fill(this.rack_itDataSet.spelers);

            spelersBindingSource.AddNew();


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                spelersBindingSource.EndEdit();
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
