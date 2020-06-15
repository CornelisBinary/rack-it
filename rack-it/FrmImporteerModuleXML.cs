using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace rack_it
{
    public partial class FrmImporteerModuleXML : rack_it.FrmVoegToeBase
    {
        XML Xml;
        string fileName;

        public FrmImporteerModuleXML()
        {
            InitializeComponent();
        }

        private void FrmImporteerModuleXML_Load(object sender, EventArgs e)
        {
            // vullen dataset met gegevens uit de database.
            teamsTableAdapter.Fill(this.rack_itDataSet.teams);

            scholenTableAdapter.Fill(this.rack_itDataSet.scholen);
            spelersTableAdapter.Fill(this.rack_itDataSet.spelers);

            locatiesTableAdapter.Fill(this.rack_itDataSet.locaties);
            veldenTableAdapter.Fill(this.rack_itDataSet.velden);

            toernooienTableAdapter.Fill(this.rack_itDataSet.toernooien);
            inschrijvingspelersTableAdapter.Fill(this.rack_itDataSet.inschrijvingspelers);
            inschrijvingteamsTableAdapter.Fill(this.rack_itDataSet.inschrijvingteams);
            wedstrijdenTableAdapter.Fill(this.rack_itDataSet.wedstrijden);
        }

        private void btnImportXml_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!String.Equals(Path.GetExtension(openFileDialog1.FileName),
                                   ".xml",
                                   StringComparison.OrdinalIgnoreCase))
                {
                    // Invalid file type selected; display an error.
                    MessageBox.Show("zorg ervoor dat je een Xml-bestand selecteert!",
                                    "Verkeerd bestandstype!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    fileName = openFileDialog1.FileName;

                    btnCheckXml.Enabled = true;
                }
            }
        }

        private void btnCheckXml_Click(object sender, EventArgs e)
        {

            Xml = new XML();

            Xml.ReadXml(fileName);

            saveFileDialog1.FileName = fileName;

            btnCreate.Enabled = true;

            btnCheckXml.Enabled = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // teams 
                foreach (DataRow dataRow in Xml.TeamsCollection)
                {
                    if (!rack_itDataSet.teams.Rows.Contains(dataRow["Naam"].ToString())) { rack_itDataSet.teams.Rows.Add(dataRow.ItemArray); };
                }
                // scholen + spelers(leerlingen)
                foreach (DataRow dataRow in Xml.ScholenCollection)
                {
                    if (!rack_itDataSet.scholen.Rows.Contains(dataRow["Naam"].ToString())) { rack_itDataSet.scholen.Rows.Add(dataRow.ItemArray); };
                }
                foreach (DataRow dataRow in Xml.SpelersCollection)
                {
                    if (!rack_itDataSet.spelers.Rows.Contains(dataRow["nummer"].ToString())) { rack_itDataSet.spelers.Rows.Add(dataRow.ItemArray); };
                }
                // locaties + velden
                foreach (DataRow dataRow in Xml.LocatiesCollection)
                {
                    if (!rack_itDataSet.locaties.Rows.Contains(dataRow["Naam"].ToString())) { rack_itDataSet.locaties.Rows.Add(dataRow.ItemArray); };
                }
                foreach (DataRow dataRow in Xml.VeldenCollection)
                {
                    if (!rack_itDataSet.velden.Rows.Contains(new object[] { dataRow[0].ToString(), dataRow[1].ToString() })) { rack_itDataSet.velden.Rows.Add(dataRow.ItemArray); };
                }
                // toernooien + wedstrijden + inschrijvingen teams en spelers(leerlingen)
                foreach (DataRow dataRow in Xml.ToernooienCollection)
                {
                    if (!rack_itDataSet.toernooien.Rows.Contains(dataRow["Naam"].ToString())) {rack_itDataSet.toernooien.Rows.Add(dataRow.ItemArray);};
                }

                foreach (DataRow dataRow in Xml.InschrijvingenSpelersCollection)
                {
                    if (!rack_itDataSet.inschrijvingspelers.Rows.Contains(new object[] { dataRow[0].ToString(), dataRow[1].ToString() })) { rack_itDataSet.inschrijvingspelers.Rows.Add(dataRow.ItemArray); };
                }
                foreach (DataRow dataRow in Xml.InschrijvingenTeamsCollection)
                {
                    if (!rack_itDataSet.inschrijvingteams.Rows.Contains(new object[] { dataRow[0].ToString(), dataRow[1].ToString()})) { rack_itDataSet.inschrijvingteams.Rows.Add(dataRow.ItemArray); };
                }

                foreach (DataRow dataRow in Xml.WedstrijdenCollection)
                {
                    if (!rack_itDataSet.wedstrijden.Rows.Contains(new object[] { dataRow[0].ToString(), dataRow[1].ToString(), dataRow[2].ToString()})) { rack_itDataSet.wedstrijden.Rows.Add(dataRow.ItemArray); };
                }

                // database updaten.
                this.Validate();
                this.tableAdapterManager.UpdateAll(this.rack_itDataSet);

                // beëindigen van import.
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
