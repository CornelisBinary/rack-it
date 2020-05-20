using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rack_it
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();

            this.Bounds = Screen.GetBounds(this);
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            FrmHoofdscherm frmHoofdscherm = new FrmHoofdscherm();

            frmHoofdscherm.MdiParent = this;

            frmHoofdscherm.StartPosition = FormStartPosition.CenterScreen;
            frmHoofdscherm.Dock = DockStyle.Fill;

            frmHoofdscherm.Show();
        }

        private void btnHoofdscherm_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            FrmHoofdscherm frmHoofdscherm = new FrmHoofdscherm();

            frmHoofdscherm.MdiParent = this;

            frmHoofdscherm.StartPosition = FormStartPosition.CenterScreen;
            frmHoofdscherm.Dock = DockStyle.Fill;

            frmHoofdscherm.Show();

        }

        private void btnEinde_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
