using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rack_it
{
    public partial class Frm_H_Teams_AanmeldenToernooi : rack_it.FrmVoegToeBase
    {
        private string toernooi;

        public Frm_H_Teams_AanmeldenToernooi(string naam)
        {
            InitializeComponent();
            toernooi = naam;
        }

        private void Frm_H_Teams_AanmeldenToernooi_Load(object sender, EventArgs e)
        {
            this.teamsTableAdapter.Fill(this.rack_itDataSet.teams);
            inschrijvingteamsTableAdapter.Fill(this.rack_itDataSet.inschrijvingteams);
            inschrijvingteamsBindingSource.AddNew();

            toernooien_NaamTextBox.Text = toernooi;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                inschrijvingteamsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.rack_itDataSet);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            toernooien_NaamTextBox.Text = toernooi;
        }
    }
}
