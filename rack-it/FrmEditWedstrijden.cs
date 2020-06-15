using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rack_it
{
    public partial class FrmEditWedstrijden : rack_it.FrmEditBase
    {
        private string toernooi;
        private int afvalFase;

        public FrmEditWedstrijden(string Toernooi, int AfvalFase, DataRowCollection WedstrijdFase)
        {
            InitializeComponent();

            toernooi = Toernooi;
            afvalFase = AfvalFase;

            // alle wedstrijden aan de lokale datatable toevoegen.
            try
            {
                foreach (DataRow wedstrijd in WedstrijdFase)
                {
                    rack_itDataSet.wedstrijden.Rows.Add(wedstrijd.ItemArray);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
          

        }

        private void FrmEditWedstrijden_Load(object sender, EventArgs e)
        {
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
                wedstrijdenBindingSource.EndEdit();
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
