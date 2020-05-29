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
        private DateTime Date;
        private string Doelgroep;
        private string Naam;
        private List<string> Deelnemers = new List<string> { };
        private List<string> Velden = new List<string> { };
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

    // DIT KAN 10 keer korter en compacter!!!
            // als het toernooi actief of uitgevoerd is moeten we de gegevens ophalen.
            if (Date < DateTime.Today)
            {
                pnlAanmelden.SendToBack();
                pnlToernooi.BringToFront();

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
                else if( Doelgroep == "spelers")
                {
                   inschrijvingspelersTableAdapter.ToernooiInschrijvingen(rack_itDataSet.inschrijvingspelers, Naam);
                    foreach (DataRow data in rack_itDataSet.inschrijvingspelers.Rows)
                    {

                        Deelnemers.Add(data["Spelers_Nummer"].ToString());
                    }

                }

            } else if(Date == DateTime.Today){
                btnAanmelden.Enabled = true;

                pnlAanmelden.SendToBack();
                pnlToernooi.BringToFront();

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
            else
            {
                pnlAanmelden.BringToFront();
                pnlToernooi.SendToBack();
            }
        }

        private void btnXML_Click(object sender, EventArgs e)
        {

        }

        private void btnHandmatig_Click(object sender, EventArgs e)
        {
            handmatigAanmelden();
        }
        private void btnAanmelden_Click(object sender, EventArgs e)
        {
            handmatigAanmelden();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Afvalschema toernooiAfvalschema = new Afvalschema(Naam, Deelnemers, Velden,
                                                                    (DataRowCollection)rack_itDataSet.wedstrijden.Rows);

            toernooiAfvalschema.GenereerFases(pbAfvalschema.CreateGraphics(),
                                            (DataRowCollection)rack_itDataSet.wedstrijden.Rows);

        }

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

       
    }
}
