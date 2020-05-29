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
    public partial class FrmToernooienWeergave : Form
    {
        public DateTime Date;
        public string Doelgroep;
        public string Naam;

        public FrmToernooienWeergave(string naam)
        {
            InitializeComponent();

            Naam = naam;
            this.toernooienTableAdapter.GetToernooi(this.rack_itDataSet.toernooien, Naam);

        }

        private void FrmToernooienWeergave_Load(object sender, EventArgs e)
        {
            DataRow dataRow = (DataRow)((DataRowView)toernooienBindingSource.Current).Row;

            Date = (DateTime)dataRow["Datum"];
            Doelgroep = dataRow["Doelgroep"].ToString();
            
            tableAdapterManager.UpdateAll(this.rack_itDataSet);

            pnlAanmelden.SendToBack();
            pnlToernooi.BringToFront();

        }

        private void btnXML_Click(object sender, EventArgs e)
        {

        }

        private void btnHandmatig_Click(object sender, EventArgs e)
        {
            if (Doelgroep == "teams")
            {
                Frm_H_Teams_AanmeldenToernooi frmHandmatigAanmelden = new Frm_H_Teams_AanmeldenToernooi(Naam);
                frmHandmatigAanmelden.StartPosition = FormStartPosition.CenterParent;

                if (frmHandmatigAanmelden.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else if (Doelgroep == "spelers")
            {
                Frm_H_Spelers_AanmeldenToernooi frmHandmatigAanmelden = new Frm_H_Spelers_AanmeldenToernooi(Naam);
                frmHandmatigAanmelden.StartPosition = FormStartPosition.CenterParent;

                if (frmHandmatigAanmelden.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void pbAfvalschema_Click(object sender, EventArgs e)
        {
           
                Afvalschema afvalschema = new Afvalschema(new List<string> { "piet", "henk", "tuin", "musket", "doeplet", "henk", "tuin", "musket" },
                                                                        new List<string> { "veld1", "veld2", "veld3", "veld4", "veld5", "veld1", "veld2", "veld3", "veld4", "veld5" },
                                                                        ((DataRowCollection)rack_itDataSet.wedstrijden.Rows));

                List<string> spelers = new List<string> { "piet", "henk", "tuin", "musket", "piet", "henk", "tuin", "musket" };
            afvalschema.AfvalFase++;

            afvalschema.MaakActieveFase(spelers.GetRange(0, 8), pbAfvalschema.CreateGraphics());
            afvalschema.AfvalFase++;

            afvalschema.MaakActieveFase(spelers.GetRange(0, 4), pbAfvalschema.CreateGraphics());
            afvalschema.AfvalFase++;

            afvalschema.MaakActieveFase(spelers.GetRange(0, 2), pbAfvalschema.CreateGraphics());
            afvalschema.AfvalFase++;

            afvalschema.MaakActieveFase(spelers.GetRange(0, 1), pbAfvalschema.CreateGraphics());


          

        }
    }
}
