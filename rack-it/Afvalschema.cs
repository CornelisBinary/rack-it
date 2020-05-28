using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace rack_it
{
    class Afvalschema
    {
        // eigenschappen
        //public
        public int AfvalFase = -1;
        public bool TeveelDeelnemers;

        //private
        private DataRowCollection dRC_Wedstrijden;
        private DataRowCollection wedstrijdFase;
        private List<string> deelnemers;
        private List<string> dummySpelers;
        private List<int> gewensteAantalSpelers = new List<int> { 2, 4, 8, 16, 32, 64, 128, 256};
        private int aantalDeelnemers;

        // grafische eigenschappen



        // initialisatie
        public Afvalschema(List<string> Deelnemers, DataRowCollection DRC_Wedstrijden)
        {
            initClass(Deelnemers, DRC_Wedstrijden);
        }

        private void initClass(List<string> Deelnemers, DataRowCollection DRC_Wedstrijden)
        {
            deelnemers = Deelnemers;
            dRC_Wedstrijden = DRC_Wedstrijden;
        }

        // methodes
        // check voor genereren afvalschema.
        private bool controleGegevens()
        {
            // check of er al bestaande wedstrijden zijn in de database.
            if (dRC_Wedstrijden[0] == null)
            {
                int AantalDeelnemers = deelnemers.Count;

                // Check of het aantal spelers overeenkomt met het gewenste aantal, als dit niet zo is worden er 
                // dummy spelers toegevoegd.
                foreach (int getal in gewensteAantalSpelers)
                {
                    if (getal > AantalDeelnemers || getal == AantalDeelnemers && AantalDeelnemers >= 2)
                    {
                        for (int i = 0; i < (getal - AantalDeelnemers); i++)
                        {
                            dummySpelers.Add("DummySpeler" + (i + 1));
                        }
                        aantalDeelnemers = getal;
                        TeveelDeelnemers = false;
                        break;
                    }
                    // Als er te veel spelers zijn wordt het toernooi geannuleerd en moet het aantal deelnemers aangepast worden. 
                    else if (getal.Equals(gewensteAantalSpelers.Last()))
                    {
                        TeveelDeelnemers = true;
                        throw new Exception("Overschrijding van miximaal aantal deelnemers : 256!") { };
                    }
                }

                return false;
            }
            else
            {
                return true;
            }
        }
     

        // de algemene functie voor het visueel weergeven van het toernooi wat met elke fase aangeroepen wordt. 
        public void GenereerFases(Graphics papier, DataRowCollection DRC_Wedstrijden)
        {
            dRC_Wedstrijden = DRC_Wedstrijden;
            if (TeveelDeelnemers != true)
            {
                if (controleGegevens())
                {
                    // al de winnaars worden hierin opgeslagen tot één fase terug;
                    List<string> winnaarsVorigeRonde = new List<string> { };
                    List<string> winnaarsHuidigeRonde = new List<string> { };

                    // check functie toevoegen die controleert of het de laatste fase uit de lijst is en controleert voor lege eindstanden.
                    foreach (DataRow wedstrijd in dRC_Wedstrijden)
                    {
                        // als de afvalfase nog niet gedefineerd is wordt die hier gevuld. 
                        AfvalFase = AfvalFase == -1 ? (int)wedstrijd["Afvalfase"] : AfvalFase;

                        // check of de wedstrijd eindstand gevuld is.
                        if (wedstrijd["Eindstand"] != null)
                        {
                            // check of het over dezelfde afvalfase gaat.
                            if ((int)wedstrijd["Afvalfase"] == AfvalFase)
                            {
                                // voegt de huidige datarow toe aan de fase.
                                wedstrijdFase.Add(wedstrijd);
                                // winnaar registeren, voor als er een ontbrekende eindstand in de volgende fase wordt ontdekt 
                                // kan dit gebruikt worden om die fase opnieuw te genereren.
                                winnaarsHuidigeRonde.Add(wedstrijd["Winnaar"].ToString());

                            }
                            else
                            {
                                // visuele weergave maken van wedstrijd fase.
                                MaakAfgelegdeFase(papier, wedstrijdFase);

                                // leeg de wedstrijdFase voor de volgende fase.
                                wedstrijdFase.Clear();

                                // het afvalfase nummer verhogen.
                                AfvalFase = (int)wedstrijd["Afvalfase"];

                                // de gegevens lijsten met winnaars updaten
                                winnaarsVorigeRonde.Clear();
                                winnaarsVorigeRonde = winnaarsHuidigeRonde;
                                winnaarsHuidigeRonde.Clear();
                            }
                        }
                        else
                        {
                            // met de gegevens uit `winnaarsVorigeRonde` genereer je de niet complete fase opnieuw;
                            MaakActieveFase(papier, winnaarsVorigeRonde);
                        }


                    }
                }
                // Als er nog geen wedstrijden zijn gespeelt wordt met de deelnemers de eerste afvalfase gegenereerd.
                else
                {
                    AfvalFase = 1;

                    MaakActieveFase(papier, deelnemers);
                }
            }
           
        }
     
        // Visualiseer een afgeronde fase met de gegevens opgehaald uit de database.
        private void MaakAfgelegdeFase(Graphics papier, DataRowCollection wedstrijdFase)
        {
                     
        }

        // Visualiseer een nog niet afgeronde fase waarvoor automatisch nieuwe datarows voor de database tafel wedstrijden gemaakt moet worden.
        private void MaakActieveFase(Graphics papier, List<string> spelers)
        {

        }

        // Deze functie wordt gebruikt om de individuele wedstrijden te tekenen.
        private void MaakKolom(List<string>spelers, List<int> eindstand)
        {

        }

    }
}
