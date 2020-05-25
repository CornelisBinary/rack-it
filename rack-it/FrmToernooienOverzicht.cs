using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rack_it
{
    public enum Toernooi
    {
        Aankomend,
        Actief,
        Afgelegd
    }

    public partial class FrmToernooienOverzicht : Form
    {
      
        public FrmToernooienOverzicht(Toernooi toernooi)
        {
            InitializeComponent();

            switch (toernooi)
            {
                case Toernooi.Aankomend:
                    rdbAankomend.Checked = true;
                    break;
                case Toernooi.Actief:
                    rdbActief.Checked = true;
                    break;
                case Toernooi.Afgelegd:
                    rdbAfgelegd.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void frmToernooien_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(rdbAankomend, "aankomende toernooien");
            toolTip1.SetToolTip(rdbActief, "actieve toernooien");
            toolTip1.SetToolTip(rdbAfgelegd, "afgelegde toernooien");
            toolTip1.SetToolTip(ckbAlleToernooien, "alle toernooien");
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            string zoekwaarde = txbZoekwaarde.Text;

            try
            {
                toernooienDataGridView.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

                foreach (DataGridViewRow row in toernooienDataGridView.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(zoekwaarde))
                    {
                        toernooienDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

        private void rdbAankomend_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAankomend.Checked && ckbAlleToernooien.Checked == false)
            {
                toernooienTableAdapter.AankomendeToernooien(this.rack_itDataSet.toernooien);
            }
        }

        private void rdbActief_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbActief.Checked && ckbAlleToernooien.Checked == false)
            {
                toernooienTableAdapter.ActieveToernooien(this.rack_itDataSet.toernooien);

            }
        }

        private void rdbAfgelegd_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAfgelegd.Checked && ckbAlleToernooien.Checked == false)
            {
                toernooienTableAdapter.AfgelegdeToernooien(this.rack_itDataSet.toernooien);

            }
        }

        private void ckbAlleToernooien_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAlleToernooien.Checked)
            {
                toernooienTableAdapter.Fill(this.rack_itDataSet.toernooien);
            }
        }
    }
}
