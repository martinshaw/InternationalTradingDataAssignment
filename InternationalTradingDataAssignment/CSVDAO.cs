using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace InternationalTradingDataAssignment
{
    public class CSVDAO
    {
        const int MAX_LINES_FILE = 50000;
        const string PATH = "countries.csv";

        public string[] headers = new string[6]; //column headers
        public AVLTree<Country> countries = new AVLTree<Country>();

        public CSVDAO()
        {

        }

        public void ReadCSV()
        {
            string[] allLines = new string[MAX_LINES_FILE];

            allLines = File.ReadAllLines(PATH);
            foreach (string line in allLines)
            {
                if (line.StartsWith("Country")) //found first line - headers
                {
                    headers = line.Split(',');
                }
                else
                {
                    // Split data from lines into arrays
                    string[] columns = line.Split(',');

                    // Remove squared brackets and split Main Trade Partner data
                    string[] partners = columns[5].Replace("[", "").Replace("]", "").Split(';');

                    // Build instance of Country class with data
                    Country c = new Country();
                    c.Name = columns[0];
                    c.GdpGrowth = float.Parse(columns[1]);
                    c.Inflation = float.Parse(columns[2]);
                    c.TradeBalance = float.Parse(columns[3]);
                    c.HdiRanking = float.Parse(columns[4]);
                    c.MainTradePartners = partners;
                    countries.InsertItem(c);
                }

            }
            
        }

        public void EditCountry(
            string originalName,
            string name,
            string gdpGrowth,
            string inflation,
            string tradeBalance,
            string hdiRanking
        )
        {
            Boolean error = false;
            string[] allLines = new string[MAX_LINES_FILE];
            string[] newLines = new string[MAX_LINES_FILE];
            int newIndex = 0;

            allLines = File.ReadAllLines(PATH);
            for (int i = 0; i < allLines.Length; i++)
            {
                // Identify line to be changed by comparing with specified name
                if (allLines[i].Split(',')[0] == originalName)
                {
                    if (name == null || name == "" || name == " ") { error = true; MessageBox.Show("Cannot save changes with an empty Name field!"); }
                    if (gdpGrowth == null || gdpGrowth == "" || gdpGrowth == " ") { error = true; MessageBox.Show("Cannot save changes with an empty GDP Growth field!"); }
                    if (inflation == null || inflation == "" || inflation == " ") { error = true; MessageBox.Show("Cannot save changes with an empty Inflation field!"); }
                    if (tradeBalance == null || tradeBalance == "" || tradeBalance == " ") { error = true; MessageBox.Show("Cannot save changes with an empty Trade Balance field!"); }
                    if (hdiRanking == null || hdiRanking == "" || hdiRanking == " ") { error = true; MessageBox.Show("Cannot save changes with an empty HDI Ranking field!"); }

                    if (error == true)
                    {
                        newLines[newIndex] = allLines[i];
                        newIndex++;
                    }
                    else
                    {
                        newLines[newIndex] = name + "," +
                            gdpGrowth.ToString() + "," +
                            inflation.ToString() + "," +
                            tradeBalance.ToString() + "," +
                            hdiRanking.ToString() + "," +
                            allLines[i].Split(',')[5];
                        newIndex++;
                        MessageBox.Show("Country\'s data has been edited & stored!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

                // Identify line to be changed by comparing with names of Main Trading Partners
                else if (allLines[i].Split(',')[5].IndexOf(originalName) > -1)
                {
                    string partners = allLines[i].Split(',')[5];
                    if (partners.IndexOf(";" + originalName) > -1) { partners = partners.Replace(";" + originalName, ";" + name); }
                    else if (partners.IndexOf(originalName + ";") > -1) { partners = partners.Replace(originalName + ";", name + ";"); }
                    else if (partners.IndexOf(";" + originalName + ";") > -1) { partners = partners.Replace(";" + originalName + ";", ";" + name + ";"); }
                    else if (partners.IndexOf(originalName) > -1) { partners = partners.Replace(originalName, name); }
                    newLines[newIndex] = allLines[i].Split(',')[0] + "," +
                        allLines[i].Split(',')[1] + "," +
                        allLines[i].Split(',')[2] + "," +
                        allLines[i].Split(',')[3] + "," +
                        allLines[i].Split(',')[4] + "," +
                        partners;
                    newIndex++;
                }

                else {
                    newLines[newIndex] = allLines[i];
                    newIndex++;
                }
            }

            string[] finishedLines = new string[newLines.Count(s => s != null)];
            for (int ifl = 0; ifl < finishedLines.Length; ifl++)
            {
                finishedLines[ifl] = newLines[ifl];
            }

            File.WriteAllLines(PATH, finishedLines);

        }

        public void RemoveCountry(string name)
        {
            string[] allLines = new string[MAX_LINES_FILE];
            string[] newLines = new string[MAX_LINES_FILE];
            int newIndex = 0;

            allLines = File.ReadAllLines(PATH);
            for (int i = 0; i < allLines.Length; i++)
            {
                // Identify line to be changed by comparing with names of Main Trading Partners
                if (allLines[i].Split(',')[5].IndexOf(name) > -1)
                {
                    string partners = allLines[i].Split(',')[5];
                    if (partners.IndexOf(";" + name) > -1) { partners = partners.Replace(";" + name, ""); }
                    else if (partners.IndexOf(name + ";") > -1) { partners = partners.Replace(name + ";", ""); }
                    else if (partners.IndexOf(";" + name + ";") > -1) { partners = partners.Replace(";" + name + ";", ";"); }
                    else if (partners.IndexOf(name) > -1) { partners = partners.Replace(name, ""); }
                    newLines[newIndex] = allLines[i].Split(',')[0] + "," + 
                        allLines[i].Split(',')[1] + "," +
                        allLines[i].Split(',')[2] + "," +
                        allLines[i].Split(',')[3] + "," +
                        allLines[i].Split(',')[4] + "," +
                        partners;
                    newIndex++;
                }

                // Identify line to be changed by comparing with specified name
                else if (allLines[i].Split(',')[0] != name)
                {
                    newLines[newIndex] = allLines[i];
                    newIndex++;
                }
            }

            string[] finishedLines = new string[newLines.Count(s => s != null)];
            for(int ifl = 0; ifl < finishedLines.Length; ifl++)
            {
                finishedLines[ifl] = newLines[ifl];
            }

            File.WriteAllLines(PATH, finishedLines);

            MessageBox.Show("Country\'s data has been removed!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
