using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rack_it
{
    public partial class Frm_H_Spelers_AanmeldenToernooi : rack_it.FrmVoegToeBase
    {
        private string toernooi;

        public Frm_H_Spelers_AanmeldenToernooi(string naam)
        {
            InitializeComponent();

            toernooi = naam;
        }

        private void Frm_H_AanmeldenToernooi_Load(object sender, EventArgs e)
        {
            spelersTableAdapter.Fill(this.rack_itDataSet.spelers);

            inschrijvingspelersTableAdapter.Fill(this.rack_itDataSet.inschrijvingspelers);
            inschrijvingspelersBindingSource.AddNew();

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
                inschrijvingspelersBindingSource.EndEdit();
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
