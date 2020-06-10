using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rack_it
{
    public partial class FrmTeamsOverzicht : Form
    {
        public FrmTeamsOverzicht()
        {
            InitializeComponent();
        }

        private void teamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rack_itDataSet);

        }

        private void frmTeamsOverzicht_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rack_itDataSet.teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.rack_itDataSet.teams);

        }

        private void teamsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && teamsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "");
            {
                int index = e.RowIndex;
                FrmBewerkTeam frmBewerkTeam = new FrmBewerkTeam(index);

                if (frmBewerkTeam.ShowDialog() == DialogResult.OK)
                {
                    this.teamsTableAdapter.Fill(rack_itDataSet.teams);
                }
                //MessageBox.Show(e.RowIndex.ToString() + " " + teamsDataGridView.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            FrmMaakTeam frmMaakTeam = new FrmMaakTeam();

            if (frmMaakTeam.ShowDialog() == DialogResult.OK)
            {
                this.teamsTableAdapter.Fill(this.rack_itDataSet.teams);
            }
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            string zoekwaarde = txbZoekwaarde.Text;

            try
            {
                teamsDataGridView.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

                foreach (DataGridViewRow row in teamsDataGridView.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(zoekwaarde))
                    {
                        teamsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        row.Selected = true;
                        break;
                    }

                }

            }
            catch (Exception)
            {
                //MessageBox.Show(exception.Message);
            }
        }
    }
}
