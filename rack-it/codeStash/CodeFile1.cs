//DataRow defaultValues = (DataRow)((DataRowView)spelersBindingSource.Current).Row;

//teams_NaamComboBox.SelectedValue = defaultValues["teams_naam"].ToString();
//scholen_NaamComboBox.SelectedValue = defaultValues["Scholen_naam"].ToString();


// afvalschema genereer row

/* float offsetWaarde = (30 * AfvalFase);
          float afstandBeginY = offsetWaarde -10;
          float afstandY;
          */
/* int standaardXAfstand = 80;

int veldTeller = 1;
int VeldTeller = 0;
*/
/*afstandY = offsetWaarde * (i-1);

papier.DrawString(spelers[i - 1], font, kwast, standaardXAfstand * AfvalFase, afstandBeginY + afstandY);

if (veldTeller == 2)
{

papier.DrawString(velden[VeldTeller], font, kwast, standaardXAfstand * AfvalFase, (afstandBeginY / (float)0.75 * (float)0.25) + afstandY);

veldTeller = 0;
VeldTeller++;
}
veldTeller++;
*/

// weergave row frmtoernooiweergave

/*
*  float round;
    for (int i = 1; i <= 6; i++)
    {
        afvalschema.AfvalFase++;

        if (i == 3 || i == 5)
        {
            i++;
        }

        round = 8 / i;
        afvalschema.MaakActieveFase(spelers.GetRange(0, (int)Math.Round(round, 0)), pbAfvalschema.CreateGraphics());
    }*/

/*     Afvalschema afvalschema = new Afvalschema(new List<string> { "piet", "henk", "tuin", "musket", "doeplet", "henk", "tuin", "musket" },
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
 */
