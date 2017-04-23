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
        public Boolean DEBUG = true;

        public CSVDAO dao = new CSVDAO();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StyleLayout();
                SetupView();
            }
            catch (Exception ex)
            {
                if (DEBUG == true)
                {
                    MessageBox.Show(ex.StackTrace, "ERROR: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void countriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (countriesList.SelectedItems.Count != 0)
            {
                LoadCountryData(countriesList.SelectedItems[0].Text);
            }
        }
        private void cMainTradePartnersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cMainTradePartnersList.SelectedItems.Count != 0)
            {
                LoadCountryData(cMainTradePartnersList.SelectedItems[0].Text);
            }

        }
        private void formTextBoxes_KeyDown(object sender, EventArgs e)
        {
            cSaveCountryButton.Visible = true;
        }


        // Programmatically style the Layout Elements,
        // reducing the need to manually change property values[TODO]
        public void StyleLayout()
        {
            // Declare colours and styles for reproducability[TODO]
            Color __backgroundColor = Color.FromArgb(255, 255, 255, 255);
            Color __menuColor = Color.FromArgb(255, 224, 224, 224);
            System.Drawing.Font __labelFontStyle = new System.Drawing.Font(SystemFonts.DefaultFont.FontFamily, 10, FontStyle.Regular);
            BorderStyle __textBoxBorderStyle = BorderStyle.FixedSingle;

            // Apply those colors and styles to the Layout Elements
            this.BackColor = __backgroundColor;
            this.mainMenu.BackColor = __menuColor;
            this.countriesList.BackColor = __backgroundColor;
            this.cMainTradePartnersList.BackColor = __backgroundColor;
            this.cSaveCountryButton.BackColor = __menuColor;

            this.countriesList.Margin = new Padding(10);
            this.countriesList.HeaderStyle = ColumnHeaderStyle.None;

            this.countriesList.Font = __labelFontStyle;
            this.cNameLabel.Font = __labelFontStyle;
            this.cGDPGrowthLabel.Font = __labelFontStyle;
            this.cInflationLabel.Font = __labelFontStyle;
            this.cTradeBalanceLabel.Font = __labelFontStyle;
            this.cHDIRankingLabel.Font = __labelFontStyle;
            this.cMainTradePartnersPanel.Font = __labelFontStyle;

            this.cNameTextBox.BorderStyle = __textBoxBorderStyle;
            this.cGDPGrowthTextBox.BorderStyle = __textBoxBorderStyle;
            this.cInflationTextBox.BorderStyle = __textBoxBorderStyle;
            this.cTradeBalanceTextBox.BorderStyle = __textBoxBorderStyle;
            this.cHDIRankingTextBox.BorderStyle = __textBoxBorderStyle;

        }

        public void SetupView()
        {
            dao.ReadCSV("../../countries.csv");

            ListViewItem lvi;
            List<Country> buffer = new List<Country>();
            dao.countries.InOrder(ref buffer);
            foreach(Country _c in buffer)
            {
                lvi = new ListViewItem(new String[] { _c.Name });
                countriesList.Items.Add(lvi);
            }




            cSaveCountryButton.Visible = false;

        }

        public void LoadCountryData(string name)
        {
            // Select data of requested Country from store
            Country c = new Country();
            List<Country> buffer = new List<Country>();
            dao.countries.InOrder(ref buffer);
            foreach (Country _c in buffer)
            {
                if(_c.Name == name) { c = _c; }
            }

            // Load data from instance of class into Layout Views
            cNameTextBox.Text = c.Name;
            cGDPGrowthTextBox.Text = c.GdpGrowth.ToString();
            cInflationTextBox.Text = c.Inflation.ToString();
            cTradeBalanceTextBox.Text = c.TradeBalance.ToString();
            cHDIRankingTextBox.Text = c.HdiRanking.ToString();

            // Clear Main Trade Partners ListView
            cMainTradePartnersList.Items.Clear();

            // Load Main Trade Partners' data
            foreach(string partner in c.MainTradePartners)
            {
                // Select data of requested Country from store
                Country ca = new Country();
                foreach (Country _ca in buffer)
                {
                    if (partner == _ca.Name) { ca = _ca; }
                }

                // Create and add new instances of ListViewItem into the Main Trade Partners ListView
                cMainTradePartnersList.Items.Add(new ListViewItem(new String[] {
                    ca.Name,
                    ca.GdpGrowth.ToString(),
                    ca.Inflation.ToString(),
                    ca.TradeBalance.ToString(),
                    ca.HdiRanking.ToString()
                }));
            }

            cSaveCountryButton.Visible = false;

        }

    }
}
