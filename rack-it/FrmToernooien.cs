using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rack_it
{
    public partial class FrmToernooien : Form
    {
        public FrmToernooien()
        {
            InitializeComponent();
        }

        private void frmToernooien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rack_itDataSet.toernooien' table. You can move, or remove it, as needed.
            this.toernooienTableAdapter.Fill(this.rack_itDataSet.toernooien);

        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            string zoekwaarde = txbZoekwaarde.Text;

            toernooienDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                foreach (DataGridViewRow row in toernooienDataGridView.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(zoekwaarde))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }
        }
    }
}
