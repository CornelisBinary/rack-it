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
    public partial class FrmToernooienWeergave : Form
    {
    // prive variabelen
        private DateTime Date;
        private string Doelgroep;
        private string Naam;
        private List<string> Deelnemers = new List<string> { };
        private List<string> Velden = new List<string> { };

        private Afvalschema afvalschema;

    // initisatie methodes.
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
            
            // als het toernooi actief of uitgevoerd is moeten we de gegevens ophalen.
            if (Date < DateTime.Today)
            {
                pnlAanmelden.SendToBack();
                pnlToernooi.BringToFront();

                toernooiGegevensOphalen();

            } else if(Date == DateTime.Today){
                btnAanmelden.Visible = true;
                btnToernooi.Visible = true;
                btnVerwerk.Visible = true;

                pnlAanmelden.SendToBack();
                pnlToernooi.BringToFront();

                toernooiGegevensOphalen();
                
            }
            else
            {
                pnlAanmelden.BringToFront();
                pnlToernooi.SendToBack();
            }
        }
    // onclick events
        private void btnXML_Click(object sender, EventArgs e)
        {
            FrmImporteerModuleXML frmImporteerModuleXML = new FrmImporteerModuleXML();
            frmImporteerModuleXML.StartPosition = FormStartPosition.CenterParent;

            if (frmImporteerModuleXML.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("inschrijvingen toegevoegd");
            }
        }

        private void btnHandmatig_Click(object sender, EventArgs e)
        {
            handmatigAanmelden();
        }
        private void btnAanmelden_Click(object sender, EventArgs e)
        {
            pnlAanmelden.BringToFront();
            pnlToernooi.SendToBack();

        }
        private void btnToernooi_Click(object sender, EventArgs e)
        {
            pnlAanmelden.SendToBack();
            pnlToernooi.BringToFront();
        }

        private void btnAfvalSchema_Click(object sender, EventArgs e)
        {
    // manier verzinnen om dit gelijk inteladen zonder dat je deze knop moet indrukken

            leegPictureBox();

            afvalschema = new Afvalschema(Naam, Deelnemers, Velden,
                                                                    (DataRowCollection)rack_itDataSet.wedstrijden.Rows);

            afvalschema.GenereerFases(pbAfvalschema.CreateGraphics(),
                                            (DataRowCollection)rack_itDataSet.wedstrijden.Rows);
        }

        private void btnVerwerk_Click(object sender, EventArgs e)
        {
           // twee blokken om als iets in de ééne fout gaat de ander door te laten gaan.
            try
            {
                foreach (DataRow wedstrijd in afvalschema.wedstrijdFase)
                {
                    rack_itDataSet.wedstrijden.Rows.Add(wedstrijd.ItemArray);
                }

                tableAdapterManager.UpdateAll(this.rack_itDataSet);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            try
            {
        // Filter toevoegen die aangeeft dat de doelgroep over teams gaat of over speler.
                FrmEditWedstrijden frmEditWedstrijden = new FrmEditWedstrijden(Naam, afvalschema.AfvalFase);
                frmEditWedstrijden.StartPosition = FormStartPosition.CenterParent;

                if (frmEditWedstrijden.ShowDialog() == DialogResult.OK)
                {
                    // dit moet globaler kunnen.!
                    afvalschema.wedstrijdFase.Clear();

                    wedstrijdenTableAdapter.GetToernooiWedstrijden(rack_itDataSet.wedstrijden, Naam);

                    leegPictureBox();

                    afvalschema.GenereerFases(pbAfvalschema.CreateGraphics(),
                                         (DataRowCollection)rack_itDataSet.wedstrijden.Rows);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    // functies
        private void handmatigAanmelden()
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

        private void toernooiGegevensOphalen()
        {

            // alle eventuel gemaakte wedstrijden van het toernooi.
            wedstrijdenTableAdapter.GetToernooiWedstrijden(rack_itDataSet.wedstrijden, Naam);
            // alle velden van de locatie die gekozen is voor het toernooi.
            veldenTableAdapter.ToernooiVelden(rack_itDataSet.velden, Naam);
            // toevoegen aan de velden `List`
            //Velden.AddRange(new List<string> { rack_itDataSet.velden.Rows.ToString() });
            foreach (DataRow data in rack_itDataSet.velden.Rows)
            {
                Velden.Add(data["Naam"].ToString());
            }

            // alle inschrijvingen voor het toernooi ophalen.
            if (Doelgroep == "teams")
            {
                inschrijvingteamsTableAdapter.ToernooiInschrijvingen(rack_itDataSet.inschrijvingteams, Naam);
                //Deelnemers.AddRange(new List<string> { rack_itDataSet.inschrijvingteams.Rows.ToString() });
                foreach (DataRow data in rack_itDataSet.inschrijvingteams.Rows)
                {
                    Deelnemers.Add(data["Teams_Naam"].ToString());
                }
            }
            else if (Doelgroep == "spelers")
            {
                inschrijvingspelersTableAdapter.ToernooiInschrijvingen(rack_itDataSet.inschrijvingspelers, Naam);
                foreach (DataRow data in rack_itDataSet.inschrijvingspelers.Rows)
                {

                    Deelnemers.Add(data["Spelers_Nummer"].ToString());
                }

            }
        }
        private void leegPictureBox()
        {
            pbAfvalschema.Refresh();
        }
    }
}
