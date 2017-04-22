using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void dataTableContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
