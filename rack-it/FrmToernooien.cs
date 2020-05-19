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

        private void toernooienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.toernooienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rack_itDataSet);

        }

        private void frmToernooien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rack_itDataSet.toernooien' table. You can move, or remove it, as needed.
            this.toernooienTableAdapter.Fill(this.rack_itDataSet.toernooien);

        }
    }
}
