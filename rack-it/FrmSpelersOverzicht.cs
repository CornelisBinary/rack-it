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

        private void spelersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.spelersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rack_itDataSet);

        }

        private void frmSpelersOverzicht_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rack_itDataSet.spelers' table. You can move, or remove it, as needed.
            this.spelersTableAdapter.Fill(this.rack_itDataSet.spelers);

        }
    }
}