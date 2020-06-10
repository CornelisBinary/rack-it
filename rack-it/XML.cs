using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace rack_it
{
    class XML
    {
        private rack_itDataSet rack_ItDataSet = new rack_itDataSet();

        public DataRowCollection TeamsCollection;

        public DataRowCollection ScholenCollection;
        public DataRowCollection SpelersCollection;

        public DataRowCollection LocatiesCollection;
        public DataRowCollection VeldenCollection;

        public DataRowCollection ToernooienCollection;
        public DataRowCollection InschrijvingenSpelersCollection;
        public DataRowCollection InschrijvingenTeamsCollection;
        public DataRowCollection WedstrijdenCollection;


        public XML()
        {
            TeamsCollection = rack_ItDataSet.teams.Rows;

            ScholenCollection = rack_ItDataSet.scholen.Rows;
            SpelersCollection = rack_ItDataSet.spelers.Rows;

            LocatiesCollection = rack_ItDataSet.locaties.Rows;
            VeldenCollection = rack_ItDataSet.velden.Rows;

            ToernooienCollection = rack_ItDataSet.toernooien.Rows;
            InschrijvingenSpelersCollection = rack_ItDataSet.inschrijvingspelers.Rows;
            InschrijvingenTeamsCollection = rack_ItDataSet.inschrijvingteams.Rows;
            WedstrijdenCollection = rack_ItDataSet.wedstrijden.Rows;
        }


        public void ReadXml(string FileName)
        {
            XmlDocument xmlDoc = new XmlDocument();

            if (File.Exists(FileName))
            {
                xmlDoc.Load(FileName);
            }
            else {
                throw new Exception("Het bestand kan niet gevonden worden, neem contact op met de beheerder!") {};
            }

            XmlNodeList itemNodes = xmlDoc.SelectNodes("//gegevens");

            foreach(XmlNode itemNode in itemNodes)
            {
                try
                {
                    switch (itemNode.Name)
                    {
                        case "teams":
                            _teams(itemNode);
                            break;
                        case "scholen":
                            _scholen(itemNode);
                            break;
                        case "locaties":
                            _locaties(itemNode);
                            break;
                        case "toernooien":
                            _toernooien(itemNode);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception exception)
                {

                    throw new Exception("Fouten in het bestand! controleer het bestand op fouten: " + exception.Message) { };
                }

            }
        }
        private void _teams(XmlNode itemNode)
        {
            XmlNodeList teamNodes = itemNode.ChildNodes;

            foreach(XmlNode teamNode in teamNodes)
            {
                TeamsCollection.Add(teamNode.Attributes["naam"]);
            }
        }

        private void _scholen(XmlNode itemNode)
        {
            XmlNodeList schoolNodes = itemNode.ChildNodes;
            XmlNodeList spelerNodes;

            foreach (XmlNode schoolNode in schoolNodes)
            {
                ScholenCollection.Add(schoolNode.Attributes["naam"]);

                spelerNodes = schoolNode.ChildNodes;

                foreach (XmlNode spelerNode in spelerNodes)
                {
                    SpelersCollection.Add(spelerNode.Attributes["nummer"], spelerNode.Attributes["naam"], spelerNode.Attributes["team"], spelerNode.Attributes["school"]);
                }
            }
        }

        private void _locaties(XmlNode itemNode)
        {
            XmlNodeList locatieNodes = itemNode.ChildNodes;
            XmlNodeList veldNodes;

            foreach (XmlNode locatieNode in locatieNodes)
            {
                LocatiesCollection.Add(locatieNode.Attributes["naam"], locatieNode.Attributes["plaats"]);

                veldNodes = locatieNode.ChildNodes;

                foreach (XmlNode veldNode in veldNodes)
                {
                    VeldenCollection.Add(veldNode.Attributes["naam"]);
                }
            }
        }

        private void _toernooien(XmlNode itemNode)
        {
            XmlNodeList toernooiNodes = itemNode.ChildNodes;
            XmlNodeList inschrijvingNodes;
            XmlNodeList wedstrijdNodes;
            string doelgroep;

    // to do: bepalen welke doelgroep het is en aan die collectie toevoegen.

            foreach (XmlNode toernooiNode in toernooiNodes)
            {
                ToernooienCollection.Add(toernooiNode.Attributes["naam"], toernooiNode.Attributes["datum"], toernooiNode.Attributes["locatie"]);
            }
        }

    }
}

/*
 * voorbeeld xml
 * normale simpele xml lees functie

XmlDocument xmlDoc = new XmlDocument();
xmlDoc.LoadXml("<user name=\"John Doe\" age=\"42\"></user>");
if(xmlDoc.DocumentElement.Attributes["name"] != null)
    Console.WriteLine(xmlDoc.DocumentElement.Attributes["name"].Value);
if(xmlDoc.DocumentElement.Attributes["age"] != null)
    Console.WriteLine(xmlDoc.DocumentElement.Attributes["age"].Value);
Console.ReadKey();

 * nog een voorbeeld
 * gebruik van Xpath en betere controle voor xml lees functie.

    static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://rss.cnn.com/rss/edition_world.rss");
            XmlNodeList itemNodes = xmlDoc.SelectNodes("//rss/channel/item");
            foreach(XmlNode itemNode in itemNodes)
            {
                XmlNode titleNode = itemNode.SelectSingleNode("title");
                XmlNode dateNode = itemNode.SelectSingleNode("pubDate");
                if((titleNode != null) && (dateNode != null))
                    Console.WriteLine(dateNode.InnerText + ": " + titleNode.InnerText);
            }
            Console.ReadKey();   
        }
*/
