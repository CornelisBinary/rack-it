﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rack_it
{
    public partial class FrmSpelersOverzicht : Form
    {
        public FrmSpelersOverzicht()
        {
            InitializeComponent();
        }

        private void frmSpelersOverzicht_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rack_itDataSet.spelers' table. You can move, or remove it, as needed.
            this.spelersTableAdapter.Fill(this.rack_itDataSet.spelers);

        }

        private void spelersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && spelersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                int index = e.RowIndex;
                FrmBewerkSpeler frmBewerkSpeler = new FrmBewerkSpeler(index);

                if (frmBewerkSpeler.ShowDialog() == DialogResult.OK)
                {
                    spelersTableAdapter.Fill(rack_itDataSet.spelers);
                }
                //MessageBox.Show(e.RowIndex.ToString() + " " + spelersDataGridView.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            FrmMaakSpeler frmMaakSpeler = new FrmMaakSpeler();

            if (frmMaakSpeler.ShowDialog() == DialogResult.OK)
            {
                this.spelersTableAdapter.Fill(this.rack_itDataSet.spelers);
            }
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            string zoekwaarde = txbZoekwaarde.Text;

            try
            {
                spelersDataGridView.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

                foreach (DataGridViewRow row in spelersDataGridView.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(zoekwaarde))
                    {
                        spelersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
