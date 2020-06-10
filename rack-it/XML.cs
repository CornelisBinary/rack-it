using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Data;

namespace rack_it
{

    // check functie toevoegen die alleen de structuur controleert !!!
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

            XmlNode hoofdNode = xmlDoc.SelectSingleNode("//gegevens");
            foreach (XmlNode itemNode in hoofdNode.ChildNodes)
            {
                //throw new Exception(itemNode.Name);
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
                TeamsCollection.Add(teamNode.Attributes["naam"].Value);
            }
        }

        private void _scholen(XmlNode itemNode)
        {
            XmlNodeList schoolNodes = itemNode.ChildNodes;
            XmlNodeList spelerNodes;

            foreach (XmlNode schoolNode in schoolNodes)
            {
                ScholenCollection.Add(schoolNode.Attributes["naam"].Value);

                spelerNodes = schoolNode.ChildNodes;

                foreach (XmlNode spelerNode in spelerNodes)
                {
                    SpelersCollection.Add(spelerNode.Attributes["nummer"].Value, spelerNode.Attributes["naam"].Value, spelerNode.Attributes["team"].Value, spelerNode.Attributes["school"].Value);
                }
            }
        }

        private void _locaties(XmlNode itemNode)
        {
            XmlNodeList locatieNodes = itemNode.ChildNodes;
            XmlNodeList veldNodes;

            foreach (XmlNode locatieNode in locatieNodes)
            {
                LocatiesCollection.Add(locatieNode.Attributes["naam"].Value, locatieNode.Attributes["plaats"].Value);

                veldNodes = locatieNode.ChildNodes;

                foreach (XmlNode veldNode in veldNodes)
                {
                    VeldenCollection.Add(veldNode.Attributes["naam"].Value);
                }
            }
        }

        private void _toernooien(XmlNode itemNode)
        {
            XmlNodeList toernooiNodes = itemNode.ChildNodes;
            XmlNodeList inschrijvingNodes;
            XmlNodeList wedstrijdNodes;
            string toernooiNaam;
            string doelgroep;

            foreach (XmlNode toernooiNode in toernooiNodes)
            {
                toernooiNaam = toernooiNode.Attributes["naam"].Value;
                doelgroep = toernooiNode.FirstChild.Attributes["doelgroep"].Value;

                ToernooienCollection.Add(toernooiNode.Attributes["naam"].Value, toernooiNode.Attributes["datum"].Value, toernooiNode.Attributes["locatie"].Value, doelgroep);

                inschrijvingNodes = toernooiNode.FirstChild.ChildNodes;
                wedstrijdNodes = toernooiNode.LastChild.ChildNodes;

                if (inschrijvingNodes != null)
                {
                    switch (doelgroep)
                    {
                        case "teams":
                            foreach (XmlNode inschrijvingNode in inschrijvingNodes)
                            {
                                InschrijvingenTeamsCollection.Add(toernooiNaam, inschrijvingNode.Attributes["naam"].Value);
                            }
                            break;

                        case "spelers":
                            foreach (XmlNode inschrijvingNode in inschrijvingNodes)
                            {
                                InschrijvingenSpelersCollection.Add(toernooiNaam, inschrijvingNode.Attributes["naam"].Value);
                            }
                            break;

                        default:
                            throw new Exception("Geen of verkeerde doelgroep aangegeven in het XML-bestand!") { };
                    }
                }
                if (wedstrijdNodes != null)
                {
                    foreach (XmlNode wedstrijdNode in wedstrijdNodes)
                    {
                        if (wedstrijdNode.HasChildNodes)
                        {
                            WedstrijdenCollection.Add(toernooiNaam, wedstrijdNode.Attributes["afvalfase"].Value, wedstrijdNode.Attributes["nummer"].Value, wedstrijdNode.Attributes["veld"].Value,
                              wedstrijdNode.FirstChild.Attributes["winnaar"].Value, wedstrijdNode.FirstChild.Attributes["verliezer"].Value, wedstrijdNode.FirstChild.Attributes["eindstand"].Value);
                        }
                    }
                }
            }
        }

    }
}

/*
 * voorbeeld xml
 * normale simpele xml lees functie

XmlDocument xmlDoc = new XmlDocument();
xmlDoc.LoadXml("<user name=\"John Doe\" age=\"42\"></user>");
if(xmlDoc.DocumentElement.Attributes["name"].Value != null)
    Console.WriteLine(xmlDoc.DocumentElement.Attributes["name"].Value.Value);
if(xmlDoc.DocumentElement.Attributes["age"].Value != null)
    Console.WriteLine(xmlDoc.DocumentElement.Attributes["age"].Value.Value);
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
