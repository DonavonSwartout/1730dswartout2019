using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dswartout1730ex2b
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = amountAustralia * rateAustralia;
            txtUSDAustralia.Text = (usdAustralia).ToString("0.00");

            decimal amountGuatemala = Convert.ToDecimal(txtAmountGuatemala.Text);
            decimal rateGuatemala = Convert.ToDecimal(txtRateGuatemala.Text);
            decimal usdGuatemala = amountGuatemala * rateGuatemala;
            txtUSDGuatemala.Text = (usdGuatemala).ToString("0.00");

            decimal amountEuro = Convert.ToDecimal(txtAmountEuro.Text);
            decimal rateEuro = Convert.ToDecimal(txtRateEuro.Text);
            decimal usdEuro = amountEuro * rateEuro;
            txtUSDEuro.Text = (usdEuro).ToString("0.00");

            decimal amountBritain = Convert.ToDecimal(txtAmountBritain.Text);
            decimal rateBritain = Convert.ToDecimal(txtRateBritain.Text);
            decimal usdBritain = amountBritain * rateBritain;
            txtUSDBritain.Text = (usdBritain).ToString("0.00");



            txtUSDTotal.Text = (usdAustralia + usdGuatemala + usdEuro + usdBritain).ToString("0.00");
        }

        private void BtnReset_Click_1(object sender, EventArgs e)
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

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
