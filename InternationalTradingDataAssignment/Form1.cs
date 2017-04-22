using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternationalTradingDataAssignment
{
    public partial class Form1 : Form
    {
        public CSVDAO dao = new CSVDAO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupView();
        }

        private void countriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( countriesList.SelectedItems.Count != 0)
            {
                LoadCountryData(countriesList.SelectedItems[0].Text);
            }
        }


        public void SetupView()
        {
            dao.ReadCSV("../../countries.csv");

            ListViewItem lvi;
            foreach (Country country in dao.countries)
            {
                lvi = new ListViewItem(new String[] { country.Name.Replace("_", " ") });
                countriesList.Items.Add(lvi);
            }

        }

        public void LoadCountryData(string name)
        {
            // Select data of requested Country from store
            Country c = new Country();
            foreach (Country country in dao.countries) { if (country.Name == name) { c = country; } }

            // Load data from instance of class into Layout Views
            cNameTextBox.Text = c.Name;
            cGDPGrowthTextBox.Text = c.GdpGrowth.ToString();
            cInflationTextBox.Text = c.Inflation.ToString();
            cTradeBalanceTextBox.Text = c.TradeBalance.ToString();
            cHDIRankingTextBox.Text = c.HdiRanking.ToString();

            // Clear Main Trade Partners ListView
            cMainTradePartnersList.Items.Clear();

            // Load Main Trade Partners' data
            for (int i = 0; i < c.MainTradePartners.Length; i++)
            {
                // Select data of requested Country from store
                Country ca = new Country();
                foreach (Country country in dao.countries) { if (country.Name == c.MainTradePartners[i]) { ca = country; } }

                // Create and add new instances of ListViewItem into the Main Trade Partners ListView
                cMainTradePartnersList.Items.Add(new ListViewItem(new String[] {
                    ca.Name,
                    ca.GdpGrowth.ToString(),
                    ca.Inflation.ToString(),
                    ca.TradeBalance.ToString(),
                    ca.HdiRanking.ToString()
                }));
            }
        }


    }
}
