﻿using System;
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
    public partial class Information : Form
    {
        int height;
        int count;
        string countryName;

        public Information(int _height, int _count, string _countryName)
        {
            this.height = _height;
            this.count = _count;
            this.countryName = _countryName;
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            infoDepthValue.Text = this.height.ToString();
            infoCountValue.Text = this.count.ToString();
            infoGDPValue.Text = this.countryName.ToString();
        }

        private void closeModalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
