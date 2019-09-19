using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dswartout1730ex1f
{
    public partial class frmCurrencyV2 : Form
    {
        public frmCurrencyV2()
        {
            InitializeComponent();
        }

        private void FrmCurrencyV2_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnGuatemala.BackgroundImage = picGuatemalaDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            txtRate.Text = "0.685588";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtUSD.Text = "0.00";
            txtTotal.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnGuatemala.BackgroundImage = picGuatemalaDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            txtRate.Text = "0.685588";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnEU_Click(object sender, EventArgs e)
        {
            btnEU.BackgroundImage = picEU.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnGuatemala.BackgroundImage = picGuatemalaDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            txtRate.Text = "1.10437";
            lblCurrency.Text = btnEU.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnGuatemala_Click(object sender, EventArgs e)
        {
            btnGuatemala.BackgroundImage = picGuatemala.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            txtRate.Text = "0.130313";
            lblCurrency.Text = btnGuatemala.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnUK_Click(object sender, EventArgs e)
        {
            btnUK.BackgroundImage = picUK.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnGuatemala.BackgroundImage = picGuatemalaDim.Image;
            txtRate.Text = "1.23442";
            lblCurrency.Text = btnUK.Text + ": ";
            txtCurrency.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSD.Text =
                (Convert.ToDecimal(txtCurrency.Text)
                * Convert.ToDecimal(txtRate.Text)).ToString("0.00");
        }

        private void TxtCurrency_Click(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtUSD.Text;
            txtTotal.Text = (Convert.ToDecimal(txtTotal.Text)
                + Convert.ToDecimal(txtUSD.Text)).ToString("0.00");
            txtCurrency.Focus();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnGuatemala.BackgroundImage = picGuatemalaDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            txtRate.Text = "0.685588";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtUSD.Text = "0.00";
            txtTotal.Text = "0.00";
            lblEquation.Text = "";
            txtCurrency.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
