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
        public bool TeveelDeelnemers { get; set; }

        public DataRowCollection HuidigeFase { get;}

        //private
        private DataRowCollection dRC_Wedstrijden;
        private DataRowCollection wedstrijdFase;

        private List<string> deelnemers = new List<string> { };
        private List<string> dummySpelers = new List<string> { };
        private List<int> gewensteAantalSpelers = new List<int> { 2, 4, 8, 16, 32, 64, 128, 256};

        private int aantalDeelnemers = 0;
        private int AfvalFase = -1;

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
        private bool controleBestaandeGegevens()
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
                        // voegt al de dummy spelers toe aan de deelnemer `List` om op een werkend getal uit te komen.
                        deelnemers.AddRange(dummySpelers);

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
                // Er is nog geen fase gespeeld en er moet een nieuwe fase met de `MaakActieveFase` gegenereerd worden.
                return false;
            }
            else
            {
                // Er zijn al fases gespeeld en die fases moeten met de methode uit `GenereerFases` door `maakAfgelegdeFase` gegenereerd worden.
                return true;
            }
        }
     

        // de algemene functie voor het visueel weergeven van het toernooi wat met elke fase aangeroepen wordt. 
        public void GenereerFases(Graphics papier, DataRowCollection DRC_Wedstrijden)
        {
            dRC_Wedstrijden = DRC_Wedstrijden;
            
            if (controleBestaandeGegevens())
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

                        // to do:
                        // 1.   (af maar niet getest..)
                        //      Als al de gemaakte afvalfases gevisualiseerd zijn moet er een controle komen die controleert
                        //      of het de laatste fase, als dit niet zo is moet de functie `maakActieveFase` aangeroepen worden
                        //      met de gegevens uit de `List` `winnaarsHuidigeRonde`.
                        // 2.   .
                        // 3.   .

                        // check of het over een andere afval fase gaat en roep dan de nodige methodes aan.
                        if ((int)wedstrijd["Afvalfase"] != AfvalFase)
                        {
                            // het afvalfase nummer verhogen.
                            AfvalFase = (int)wedstrijd["Afvalfase"];

                            // visuele weergave maken van wedstrijd fase.
                            MaakAfgelegdeFase(papier, wedstrijdFase);

                            // leeg de wedstrijdFase voor de volgende fase.
                            wedstrijdFase.Clear();

                            // de gegevens lijsten met winnaars updaten
                            winnaarsVorigeRonde.Clear();
                            winnaarsVorigeRonde = winnaarsHuidigeRonde;
                            winnaarsHuidigeRonde.Clear();

                        }

                        // gegevens moeten altijd toegevoegd worden, een if check statement is hier overbodig.
                        // voegt de huidige datarow toe aan de fase.
                        wedstrijdFase.Add(wedstrijd);
                        // winnaar registeren, voor als er een ontbrekende eindstand in de volgende fase wordt ontdekt 
                        // kan dit gebruikt worden om die fase opnieuw te genereren.
                        winnaarsHuidigeRonde.Add(wedstrijd["Winnaar"].ToString());

                        // als het de laatste wedstrijd in de collectie blijkt te zijn moet de huidige fase + nieuwe fase gevisualiseerd worden.
                        if (dRC_Wedstrijden.IndexOf(wedstrijd).Equals((dRC_Wedstrijden.Count-1)))
                        {
                            // Eerst de huidige fase.
                            MaakAfgelegdeFase(papier, wedstrijdFase);

        // check toevoegen die controleert of het niet de laatste fase is van het toernooi!

                            // verhogen van het nummer van de afval faze.
                            AfvalFase++;

                            // Daarna de nieuwe fase.
                            MaakActieveFase(papier, winnaarsHuidigeRonde);
                        }
                    }
                    else
                    {
                        // met de gegevens uit `winnaarsVorigeRonde` genereer je de niet complete fase opnieuw;
                        MaakActieveFase(papier, winnaarsVorigeRonde);
                        break;
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
     
        // Visualiseer een afgelegde fase met de gegevens opgehaald uit de database.
        private void MaakAfgelegdeFase(Graphics papier, DataRowCollection WedstrijdFase)
        {
            // to do:
            // 1.  .
            // 2.  .
            // 3.  .


        }

        // Visualiseer een nog niet afgelegde fase waarvoor automatisch nieuwe datarows voor de database tafel wedstrijden gemaakt moet worden.
        private void MaakActieveFase(Graphics papier, List<string> spelers)
        {
            // to do:
            // 1.   methode die nieuwe datarows aanmaakt voor elke wedstrijd 
            //      die hier gegenereerd wordt en aan een prive `dataRowCollection` wordt toegevoegd.
            // 2.   .
            // 3.   .


        }

        // Deze functie wordt gebruikt om de individuele wedstrijden te tekenen.
        private void MaakKolom(List<string>spelers, List<int> eindstand)
        {

        }
    }
}
