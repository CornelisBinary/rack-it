﻿using System;
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
    public partial class FrmHoofdscherm : Form
    {
        public FrmHoofdscherm()
        {
            InitializeComponent();
        }
        private void btnAfgelegdeToernooien_Click(object sender, EventArgs e)
        {
            FrmToernooienOverzicht frmToernooien = new FrmToernooienOverzicht(Toernooi.Afgelegd);
            frmToernooien.MdiParent = this.MdiParent;

            frmToernooien.StartPosition = FormStartPosition.CenterScreen;
            frmToernooien.Dock = DockStyle.Fill;

            frmToernooien.Show();
            this.Close();
        }

        private void btnActieveToernooien_Click(object sender, EventArgs e)
        {
            FrmToernooienOverzicht frmToernooien = new FrmToernooienOverzicht(Toernooi.Actief);
            frmToernooien.MdiParent = this.MdiParent;

            frmToernooien.StartPosition = FormStartPosition.CenterScreen;
            frmToernooien.Dock = DockStyle.Fill;

            frmToernooien.Show();
            this.Close();
        }

        private void btnAankomendeToernooien_Click(object sender, EventArgs e)
        {
            FrmToernooienOverzicht frmToernooien = new FrmToernooienOverzicht(Toernooi.Aankomend);
            frmToernooien.MdiParent = this.MdiParent;

            frmToernooien.StartPosition = FormStartPosition.CenterScreen;
            frmToernooien.Dock = DockStyle.Fill;

            frmToernooien.Show();
            this.Close();
        }

        private void btnSpelersOverzicht_Click(object sender, EventArgs e)
        {
            FrmSpelersOverzicht frmSpelersOverzicht = new FrmSpelersOverzicht();
            frmSpelersOverzicht.MdiParent = this.MdiParent;

            frmSpelersOverzicht.StartPosition = FormStartPosition.CenterScreen;
            frmSpelersOverzicht.Dock = DockStyle.Fill;

            frmSpelersOverzicht.Show();
            this.Close();
        }

        private void btnTeamsOverzicht_Click(object sender, EventArgs e)
        {
            FrmTeamsOverzicht frmTeamsOverzicht = new FrmTeamsOverzicht();
            frmTeamsOverzicht.MdiParent = this.MdiParent;

            frmTeamsOverzicht.StartPosition = FormStartPosition.CenterScreen;
            frmTeamsOverzicht.Dock = DockStyle.Fill;

            frmTeamsOverzicht.Show();
            this.Close();
        }

        private void btnScholenOverzicht_Click(object sender, EventArgs e)
        {
            FrmScholenOverzicht frmScholenOverzicht = new FrmScholenOverzicht();
            frmScholenOverzicht.MdiParent = this.MdiParent;

            frmScholenOverzicht.StartPosition = FormStartPosition.CenterScreen;
            frmScholenOverzicht.Dock = DockStyle.Fill;

            frmScholenOverzicht.Show();
            this.Close();
        }

        private void btnMaakToernooi_Click(object sender, EventArgs e)
        {
            FrmMaakToernooi frmMaakToernooi = new FrmMaakToernooi();
            frmMaakToernooi.StartPosition = FormStartPosition.CenterParent;

            if (frmMaakToernooi.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Nieuw toernooi toegevoegd");
            }
        }

        private void btnImporteerXML_Click(object sender, EventArgs e)
        {
            FrmImporteerModuleXML frmImporteerModuleXML = new FrmImporteerModuleXML();
            frmImporteerModuleXML.StartPosition = FormStartPosition.CenterParent;

            if (frmImporteerModuleXML.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Xml-bestand toegevoegd");
            }
        }
    }
}
