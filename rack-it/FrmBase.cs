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

        private void btnToernooien_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            FrmToernooienOverzicht frmToernooienOverzicht = new FrmToernooienOverzicht(Toernooi.Alle);

            frmToernooienOverzicht.MdiParent = this;

            frmToernooienOverzicht.StartPosition = FormStartPosition.CenterScreen;
            frmToernooienOverzicht.Dock = DockStyle.Fill;

            frmToernooienOverzicht.Show();
        }

        private void btnScholen_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            FrmScholenOverzicht frmScholenOverzicht = new FrmScholenOverzicht();

            frmScholenOverzicht.MdiParent = this;

            frmScholenOverzicht.StartPosition = FormStartPosition.CenterScreen;
            frmScholenOverzicht.Dock = DockStyle.Fill;

            frmScholenOverzicht.Show();
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            FrmTeamsOverzicht frmTeamsOverzicht = new FrmTeamsOverzicht();

            frmTeamsOverzicht.MdiParent = this;

            frmTeamsOverzicht.StartPosition = FormStartPosition.CenterScreen;
            frmTeamsOverzicht.Dock = DockStyle.Fill;

            frmTeamsOverzicht.Show();
        }

        private void btnSpelers_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            FrmSpelersOverzicht frmSpelersOverzicht = new FrmSpelersOverzicht();

            frmSpelersOverzicht.MdiParent = this;

            frmSpelersOverzicht.StartPosition = FormStartPosition.CenterScreen;
            frmSpelersOverzicht.Dock = DockStyle.Fill;

            frmSpelersOverzicht.Show();
        }
    }
}
