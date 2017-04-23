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

        public string selectedCountryName;
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




        // Programmatically style the Layout Elements,
        // reducing the need to manually change property values[TODO]
        public void StyleLayout()
        {
            // Declare colours and styles for reproducability[TODO]
            Color __backgroundColor = Color.FromArgb(255, 255, 255, 255);
            Color __menuColor = Color.FromArgb(255, 224, 224, 224);
            Color __textColor = Color.FromArgb(255, 0, 0, 0);
            System.Drawing.Font __labelTBFontStyle = new System.Drawing.Font(SystemFonts.DefaultFont.FontFamily, 10, FontStyle.Regular);
            BorderStyle __textBoxBorderStyle = BorderStyle.FixedSingle;

            // Apply those colors and styles to the Layout Elements
            this.BackColor = __backgroundColor;
            this.mainMenu.BackColor = __menuColor;
            this.countriesList.BackColor = __backgroundColor;
            this.cMainTradePartnersList.BackColor = __backgroundColor;
            this.cSaveCountryButton.BackColor = __menuColor;

            this.cNameTextBox.BackColor = __backgroundColor;
            this.cGDPGrowthTextBox.BackColor = __backgroundColor;
            this.cInflationTextBox.BackColor = __backgroundColor;
            this.cTradeBalanceTextBox.BackColor = __backgroundColor;
            this.cHDIRankingTextBox.BackColor = __backgroundColor;

            this.cNameTextBox.ForeColor = __textColor;
            this.cGDPGrowthTextBox.ForeColor = __textColor;
            this.cInflationTextBox.ForeColor = __textColor;
            this.cTradeBalanceTextBox.ForeColor = __textColor;
            this.cHDIRankingTextBox.ForeColor = __textColor;

            this.countriesList.Margin = new Padding(10);
            this.countriesList.HeaderStyle = ColumnHeaderStyle.None;

            this.countriesList.Font = __labelTBFontStyle;
            this.cNameLabel.Font = __labelTBFontStyle;
            this.cGDPGrowthLabel.Font = __labelTBFontStyle;
            this.cInflationLabel.Font = __labelTBFontStyle;
            this.cTradeBalanceLabel.Font = __labelTBFontStyle;
            this.cHDIRankingLabel.Font = __labelTBFontStyle;
            this.cMainTradePartnersPanel.Font = __labelTBFontStyle;

            this.cNameTextBox.Font = __labelTBFontStyle;
            this.cGDPGrowthTextBox.Font = __labelTBFontStyle;
            this.cInflationTextBox.Font = __labelTBFontStyle;
            this.cTradeBalanceTextBox.Font = __labelTBFontStyle;
            this.cHDIRankingTextBox.Font = __labelTBFontStyle;

            this.cNameTextBox.BorderStyle = __textBoxBorderStyle;
            this.cGDPGrowthTextBox.BorderStyle = __textBoxBorderStyle;
            this.cInflationTextBox.BorderStyle = __textBoxBorderStyle;
            this.cTradeBalanceTextBox.BorderStyle = __textBoxBorderStyle;
            this.cHDIRankingTextBox.BorderStyle = __textBoxBorderStyle;

        }

        public void SetupView()
        {
            dao.ReadCSV();

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

            // Store current Country Name for use during DAO operations
            selectedCountryName = c.Name;

            disableEditable();

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

        public void enableEditable()
        {
            // Enable editable status of Text Box Layout Views
            cNameTextBox.Enabled = true;
            cGDPGrowthTextBox.Enabled = true;
            cInflationTextBox.Enabled = true;
            cTradeBalanceTextBox.Enabled = true;
            cHDIRankingTextBox.Enabled = true;

            // Enable font style to Italic from Regular
            System.Drawing.Font __editableTBFontStyle = new System.Drawing.Font(SystemFonts.DefaultFont.FontFamily, 10, FontStyle.Italic);
            cNameTextBox.Font = __editableTBFontStyle;
            cGDPGrowthTextBox.Font = __editableTBFontStyle;
            cInflationTextBox.Font = __editableTBFontStyle;
            cTradeBalanceTextBox.Font = __editableTBFontStyle;
            cHDIRankingTextBox.Font = __editableTBFontStyle;
        }

        public void disableEditable()
        {
            // Reset editable status of Text Box Layout Views
            cNameTextBox.Enabled = false;
            cGDPGrowthTextBox.Enabled = false;
            cInflationTextBox.Enabled = false;
            cTradeBalanceTextBox.Enabled = false;
            cHDIRankingTextBox.Enabled = false;

            // Reset font style to Regular from Italic
            System.Drawing.Font __labelTBFontStyle = new System.Drawing.Font(SystemFonts.DefaultFont.FontFamily, 10, FontStyle.Regular);
            cNameTextBox.Font = __labelTBFontStyle;
            cGDPGrowthTextBox.Font = __labelTBFontStyle;
            cInflationTextBox.Font = __labelTBFontStyle;
            cTradeBalanceTextBox.Font = __labelTBFontStyle;
            cHDIRankingTextBox.Font = __labelTBFontStyle;
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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableEditable();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedCountryName == null)
            {
                MessageBox.Show("You must select a Country from the menu, to remove it!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                dao.RemoveCountry(selectedCountryName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
