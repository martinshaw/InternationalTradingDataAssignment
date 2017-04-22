using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace InternationalTradingDataAssignment
{
    public class CSVDAO
    {
        public string[] headers = new string[6]; //column headers
        public List<Country> countries = new List<Country>();

        public CSVDAO()
        {

        }

        public void ReadCSV(string Path)
        {
            const int MAX_LINES_FILE = 50000;
            string[] AllLines = new string[MAX_LINES_FILE];


        
            //reads from bin/DEBUG subdirectory of project directory
            AllLines = File.ReadAllLines(Path);
            foreach (string line in AllLines)
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
                    countries.Add(c);

                    
                }

            }
            
        }
    }
}
