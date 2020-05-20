using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rack_it
{
    public partial class FrmScholenOverzicht : Form
    {
        public FrmScholenOverzicht()
        {
            InitializeComponent();
        }

        private void schoolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scholenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rack_itDataSet);

        }

        private void frmScholenOverzicht_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rack_itDataSet.school' table. You can move, or remove it, as needed.
            this.scholenTableAdapter.Fill(this.rack_itDataSet.scholen);

        }

        private void schoolDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                MessageBox.Show(e.RowIndex.ToString() + " " + schoolDataGridView.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            FrmMaakSchool frmMaakSchool = new FrmMaakSchool();

            if (frmMaakSchool.ShowDialog() == DialogResult.OK)
            {
                this.scholenTableAdapter.Fill(rack_itDataSet.scholen);
            }
        }
    }
}
