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

        public int AfvalFase { get; set; }

        public Graphics Papier { get; set; }

        public string Naam { get; set; }

        public DataRowCollection WedstrijdFase { get; set; }

        //private
        private rack_itDataSet.wedstrijdenDataTable dTWedstrijdFase;
        private DataRowCollection dRC_Wedstrijden;

        private List<string> velden = new List<string> { };
        private List<string> deelnemers = new List<string> { };
        private List<string> dummySpelers = new List<string> { };
        private List<int> gewensteAantalSpelers = new List<int> { 2, 4, 8, 16, 32, 64, 128, 256};

        public int aantalDeelnemers = 0;

        // grafische eigenschappen

        

        // initialisatie
        public Afvalschema(string naam, List<string> Deelnemers, List<string> Velden, DataRowCollection DRC_Wedstrijden)
        {
            _initClass(naam, Deelnemers, Velden, DRC_Wedstrijden);
        }

        private void _initClass(string naam, List<string> Deelnemers, List<string> Velden, DataRowCollection DRC_Wedstrijden)
        {
            Naam = naam;
            deelnemers = Deelnemers;

            velden = Velden;

            dRC_Wedstrijden = DRC_Wedstrijden;

            dTWedstrijdFase = new rack_itDataSet.wedstrijdenDataTable();
            WedstrijdFase = dTWedstrijdFase.Rows;

            AfvalFase = 0;
        }

        // methodes
        // check voor genereren afvalschema.
        private bool _controleBestaandeGegevens()
        {
            // check of er al bestaande wedstrijden zijn in de database.
            if (dRC_Wedstrijden.Count == 0)
            {
                int AantalDeelnemers = deelnemers.Count;
                //throw new Exception("Overschrijding van miximaal aantal deelnemers : 256!") { };

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
                        //throw new Exception("Overschrijding van miximaal aantal deelnemers : 256!") { };

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
                // Er is nog geen fase gespeeld en er moet een nieuwe fase met de `_maakActieveFase` gegenereerd worden.
                return false;
            }
            else
            {
                // Er zijn al fases gespeeld en die fases moeten met de methode uit `GenereerFases` door `_maakAfgelegdeFase` gegenereerd worden.
                return true;
            }
        }
     

        // de algemene functie voor het visueel weergeven van het toernooi wat met elke fase aangeroepen wordt. 
        public void GenereerFases(Graphics papier, DataRowCollection DRC_Wedstrijden)
        {
            Papier = papier;

            dRC_Wedstrijden = DRC_Wedstrijden;
            
            if (_controleBestaandeGegevens())
            {
                // al de winnaars worden hierin opgeslagen tot één fase terug;
                List<string> winnaarsVorigeRonde = new List<string> { };
                List<string> winnaarsHuidigeRonde = new List<string> { };

                // check functie toevoegen die controleert of het de laatste fase uit de lijst is en controleert voor lege eindstanden.
                foreach (DataRow wedstrijd in dRC_Wedstrijden)
                {
                    // als de afvalfase nog niet gedefineerd is wordt die hier gevuld. 
                    AfvalFase = AfvalFase == 0 ? (int)wedstrijd["Afvalfase"] : AfvalFase;

                    // check of het over een andere afval fase gaat en roep dan de nodige methodes aan.
                    if ((int)wedstrijd["Afvalfase"] != AfvalFase)
                    {

                        // visuele weergave maken van wedstrijd fase.
                        _maakAfgelegdeFase(WedstrijdFase);

                        // het afvalfase nummer verhogen.
                        AfvalFase = (int)wedstrijd["Afvalfase"];

                        // leeg de WedstrijdFase voor de volgende fase.
                        WedstrijdFase.Clear();

                        // de gegevens lijsten met winnaars updaten
                        winnaarsVorigeRonde = new List<string>(winnaarsHuidigeRonde);
                        winnaarsHuidigeRonde.Clear();

                    }

                    // check of de wedstrijd eindstand gevuld is.
                    if (wedstrijd["Eindstand"].ToString() != "")
                    {

                        // gegevens moeten altijd toegevoegd worden, een if check statement is hier overbodig.
                        // voegt de huidige datarow toe aan de fase.
                        WedstrijdFase.Add(wedstrijd.ItemArray);
                        // winnaar registeren, voor als er een ontbrekende eindstand in de volgende fase wordt ontdekt 
                        // kan dit gebruikt worden om die fase opnieuw te genereren.
                        winnaarsHuidigeRonde.Add(wedstrijd["Winnaar"].ToString());

                        // als het de laatste wedstrijd in de collectie blijkt te zijn moet de huidige fase + nieuwe fase gevisualiseerd worden.
                        if (dRC_Wedstrijden.IndexOf(wedstrijd).Equals((dRC_Wedstrijden.Count-1)))
                        {
                            // Eerst de huidige fase.
                            _maakAfgelegdeFase(WedstrijdFase);

                            // verhogen van het nummer van de afval faze.
                            AfvalFase++;

                            // Daarna de nieuwe fase.
                            _maakActieveFase(winnaarsHuidigeRonde);
                        }
                    }
                    else
                    {
                        // met de gegevens uit `winnaarsVorigeRonde` genereer je de niet complete fase opnieuw;
                        if (winnaarsVorigeRonde.Count == 0)
                        {

                            _maakActieveFase(deelnemers);
                            
                        }
                        else
                        {
                            _maakActieveFase(winnaarsVorigeRonde);
                        }
                        break;
                    }
                }
            }
            // Als er nog geen wedstrijden zijn gespeelt wordt met de deelnemers de eerste afvalfase gegenereerd.
            else
            {
                AfvalFase = 1;

                _maakActieveFase(deelnemers);
            }
                
        }
     
        // Visualiseer een afgelegde fase met de gegevens opgehaald uit de database.
        private void _maakAfgelegdeFase(DataRowCollection WedstrijdFase)
        {
            SolidBrush kwastWinnaar = new SolidBrush(Color.LightGreen);
            SolidBrush kwastVerliezer = new SolidBrush(Color.LightCoral);

            SolidBrush kwastVeld = new SolidBrush(Color.DarkOrange);

            Font font = new Font(FontFamily.GenericSansSerif, 10);

            float lengteVeld = 300;
            float breedteVeld = 600;

            float offsetX = breedteVeld / 8;
            float offsetY = lengteVeld / ((WedstrijdFase.Count * 2)* (float)1.5);

            float positieX = AfvalFase == 1 ? 0 : offsetX * (AfvalFase-1);
            float positieY =  offsetY;



            foreach (DataRow wedstrijd in WedstrijdFase)
            {
                // winnaar tekenen op het ui
                Papier.DrawString(wedstrijd["Winnaar"].ToString() +" | "+ wedstrijd["Eindstand"].ToString().Split('|').First(), font, kwastWinnaar, positieX, positieY - (offsetY * (float)0.25));

                // tellers + positie updaten.
                positieY += (offsetY);

                // veld toevoegen tussen bijde namen van spelers
                Papier.DrawString(wedstrijd["Velden_Naam"].ToString(), font, kwastVeld, positieX, positieY - (offsetY * (float)0.5));

                // tellers + positie updaten.
                positieY += (offsetY);

                // verliezer tekenen op het ui
                Papier.DrawString(wedstrijd["Verliezer"].ToString() + " | " + wedstrijd["Eindstand"].ToString().Split('|').Last(), font, kwastVerliezer, positieX, positieY - (offsetY * (float)0.75));

               
                // tellers + positie updaten.
                positieY += offsetY;
            }
            // gelijk geheugen van items legen.
            kwastWinnaar.Dispose();
            kwastVerliezer.Dispose();
            kwastVeld.Dispose();

        }

        // Visualiseer een nog niet afgelegde fase waarvoor automatisch nieuwe datarows voor de database tafel wedstrijden gemaakt moet worden.
        private void _maakActieveFase(List<string> spelers)
        {
            // datarowcollection leeg gooien om problemen te voorkomen.
            WedstrijdFase.Clear();

            SolidBrush kwastSpeler = new SolidBrush(Color.Silver);
            SolidBrush kwastVeld = new SolidBrush(Color.DarkOrange);

            Font font = new Font(FontFamily.GenericSansSerif, 11);
           
            float lengteVeld = 300;
            float breedteVeld = 600;

            float offsetX = breedteVeld / 8;
            float offsetY = spelers.Count() == 1 ? lengteVeld / 2 : lengteVeld / (spelers.Count() * (float)1.5);

            float positieX = AfvalFase == 1 ? 0 : offsetX * (AfvalFase - 1);
            float positieY = offsetY;

            // check als het de tweede speler is voor de if in de for loop.
            int veldTeller = 1;
            // wijst een specifiek veld aan in de `velden` `list`. 
            int VeldTeller = 0;

            int nummer = 1;

            foreach (string speler in spelers)
            {

                if (veldTeller == 2)
                {
                    // check als er een veld in de `List` bestaat met het opgegeven index, 
                    // als dit niet zo is wordt de variabele die het index aanwijst gereset naar nul.
                    if (VeldTeller.Equals(velden.Count))
                    {
                        VeldTeller = 0;
                    }
                    if (velden.Count != 0)
                    {
                        
                        // veld toevoegen tussen bijde namen van spelers
                        Papier.DrawString(velden[VeldTeller], font, kwastVeld, positieX, positieY - (offsetY * (float)0.5));

                        // datarow toevoegen
                        WedstrijdFase.Add(Naam, AfvalFase,  nummer, velden[VeldTeller], "", "", "");
                    }
                    else
                    {
                        // als er geen velden meegegeven wordt kan wordt het niet wegeschreven naar de fase datarow collectie.
                        WedstrijdFase.Add(Naam, AfvalFase,  nummer, null,"", "", "");
                    }

                    // tellers + positie updaten
                    positieY += offsetY;
                    veldTeller = 0;
                    VeldTeller++;

                    // spelers tekenen op ui
                    Papier.DrawString(speler, font, kwastSpeler, positieX, positieY - (offsetY * (float)0.75));

                }
                else if(spelers.Count() == 1)
                {
                    // spelers tekenen op ui
                    Papier.DrawString(speler, font, kwastSpeler, positieX, positieY);
                }
                else
                {
                    Papier.DrawString(speler, font, kwastSpeler, positieX, positieY * (float)0.25);
                }
                // tellers + positie updaten.
                veldTeller++;
                positieY += offsetY;
                nummer++;
            }
            // gelijk geheugen van items legen.
            kwastSpeler.Dispose();
            kwastVeld.Dispose();

        }
      
    }
}
