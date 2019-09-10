using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dswartout1730ex1d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text =
                (Convert.ToDecimal(txtAmountAustralia.Text)
                * Convert.ToDecimal(txtRateAustralia.Text)).ToString("0.00");
        }

        private void guatemalaTextChanged(object sender, EventArgs e)
        {
            txtUSDGuatemala.Text =
                (Convert.ToDecimal(txtAmountGuatemala.Text)
                * Convert.ToDecimal(txtRateGuatemala.Text)).ToString("0.00");
        }

        private void euroTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text =
                (Convert.ToDecimal(txtAmountEuro.Text)
                * Convert.ToDecimal(txtRateEuro.Text)).ToString("0.00");
        }

        private void britainTextChanged(object sender, EventArgs e)
        {
            txtUSDBritain.Text =
                (Convert.ToDecimal(txtAmountBritain.Text)
                * Convert.ToDecimal(txtRateBritain.Text)).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtUSDTotal.Text = (
                Convert.ToDecimal(txtUSDAustralia.Text)
                + Convert.ToDecimal(txtUSDGuatemala.Text)
                + Convert.ToDecimal(txtUSDEuro.Text)
                + Convert.ToDecimal(txtUSDBritain.Text)
                ).ToString("0.00");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtAmountGuatemala.Text = "0.00";
            txtAmountEuro.Text = "0.00";
            txtAmountBritain.Text = "0.00";
            txtRateAustralia.Text = "0.685588";
            txtRateGuatemala.Text = "0.130313";
            txtRateEuro.Text = "1.10437";
            txtRateBritain.Text = "1.23442";
            txtUSDAustralia.Text = "0";
            txtUSDGuatemala.Text = "0";
            txtUSDEuro.Text = "0";
            txtUSDBritain.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
