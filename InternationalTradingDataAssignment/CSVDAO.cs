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
        public List<string> countryNames = new List<string>();

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
                    //split data using commas
                    string[] columns = line.Split(',');
                    Debug.Write(columns[0] + ","); //first string in line;
                    Debug.Write(columns[1] + ","); //2nd string in line;

                    // Add Country to List for debugging menu
                    countryNames.Add(columns[0]);


                    /*
                    string[] partners = columns[5].Split(';', '[', ']');
                    foreach (string tradePartner in partners)
                    {
                        if (tradePartner != "")
                        {
                            Debug.Write(":" + tradePartner);

                        }
                    }

                    */
                }

            }
            
        }
    }
}
