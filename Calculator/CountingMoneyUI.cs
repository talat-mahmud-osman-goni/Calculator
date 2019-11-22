using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CountingMoneyUI : Form
    {
        public CountingMoneyUI()
        {
            InitializeComponent();
        }

        private void CountingMoneyUI_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 aForm1 = new Form1();
            aForm1.Show();
            this.Hide();
        }

        private void CountingMoneyUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txt1000_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAm1000.Text = (1000 * Convert.ToDouble(txt1000.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm1000.Text = "0";
            }
        }

        private void txt500_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAm500.Text = (500 * Convert.ToDouble(txt500.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm500.Text = "0";
            }
        }

        private void txtAm1000_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtdisplay.Text = (Convert.ToDouble(txtAm1000.Text) + Convert.ToDouble(txtAm500.Text) + Convert.ToDouble(txtAm100.Text) + Convert.ToDouble(txtAm50.Text) + Convert.ToDouble(txtAm20.Text) + Convert.ToDouble(txtAm10.Text) + Convert.ToDouble(txtAm5.Text) + Convert.ToDouble(txtAm2.Text) + Convert.ToDouble(txtAm1.Text)).ToString();

            }
            catch (Exception)
            {
                txtdisplay.Text = "0";
            }
            try
            {
                txtAm1000.Text = (1000 * Convert.ToDouble(txt1000.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm1000.Text = "0";
            }


        }

        private void txtAm500_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtdisplay.Text = (Convert.ToDouble(txtAm1000.Text) + Convert.ToDouble(txtAm500.Text) + Convert.ToDouble(txtAm100.Text) + Convert.ToDouble(txtAm50.Text) + Convert.ToDouble(txtAm20.Text) + Convert.ToDouble(txtAm10.Text) + Convert.ToDouble(txtAm5.Text) + Convert.ToDouble(txtAm2.Text) + Convert.ToDouble(txtAm1.Text)).ToString();

            }
            catch (Exception)
            {
                txtdisplay.Text = "0";
            }
            try
            {
                txtAm500.Text = (500 * Convert.ToDouble(txt500.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm500.Text = "0";
            }
        }

        private void txt100_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAm100.Text = (100 * Convert.ToDouble(txt100.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm100.Text = "0";
            }
        }

        private void txtAm100_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtdisplay.Text = (Convert.ToDouble(txtAm1000.Text) + Convert.ToDouble(txtAm500.Text) + Convert.ToDouble(txtAm100.Text) + Convert.ToDouble(txtAm50.Text) + Convert.ToDouble(txtAm20.Text) + Convert.ToDouble(txtAm10.Text) + Convert.ToDouble(txtAm5.Text) + Convert.ToDouble(txtAm2.Text) + Convert.ToDouble(txtAm1.Text)).ToString();

            }
            catch (Exception)
            {
                txtdisplay.Text = "0";
            }
            try
            {
                txtAm100.Text = (100 * Convert.ToDouble(txt100.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm100.Text = "0";
            }
        }

        private void txt50_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAm50.Text = (50 * Convert.ToDouble(txt50.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm50.Text = "0";
            }
        }

        private void txtAm50_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtdisplay.Text = (Convert.ToDouble(txtAm1000.Text) + Convert.ToDouble(txtAm500.Text) + Convert.ToDouble(txtAm100.Text) + Convert.ToDouble(txtAm50.Text) + Convert.ToDouble(txtAm20.Text) + Convert.ToDouble(txtAm10.Text) + Convert.ToDouble(txtAm5.Text) + Convert.ToDouble(txtAm2.Text) + Convert.ToDouble(txtAm1.Text)).ToString();

            }
            catch (Exception)
            {
                txtdisplay.Text = "0";
            }
            try
            {
                txtAm50.Text = (50 * Convert.ToDouble(txt50.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm50.Text = "0";
            }
        }

        private void txt20_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAm20.Text = (20 * Convert.ToDouble(txt20.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm20.Text = "0";
            }
        }

        private void txtAm20_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtdisplay.Text = (Convert.ToDouble(txtAm1000.Text) + Convert.ToDouble(txtAm500.Text) + Convert.ToDouble(txtAm100.Text) + Convert.ToDouble(txtAm50.Text) + Convert.ToDouble(txtAm20.Text) + Convert.ToDouble(txtAm10.Text) + Convert.ToDouble(txtAm5.Text) + Convert.ToDouble(txtAm2.Text) + Convert.ToDouble(txtAm1.Text)).ToString();

            }
            catch (Exception)
            {
                txtdisplay.Text = "0";
            }
            try
            {
                txtAm20.Text = (20 * Convert.ToDouble(txt20.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm20.Text = "0";
            }
        }

        private void txt10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAm10.Text = (10 * Convert.ToDouble(txt10.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm10.Text = "0";
            }
        }

        private void txtAm10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtdisplay.Text = (Convert.ToDouble(txtAm1000.Text) + Convert.ToDouble(txtAm500.Text) + Convert.ToDouble(txtAm100.Text) + Convert.ToDouble(txtAm50.Text) + Convert.ToDouble(txtAm20.Text) + Convert.ToDouble(txtAm10.Text) + Convert.ToDouble(txtAm5.Text) + Convert.ToDouble(txtAm2.Text) + Convert.ToDouble(txtAm1.Text)).ToString();

            }
            catch (Exception)
            {
                txtdisplay.Text = "0";
            }
            try
            {
                txtAm10.Text = (10 * Convert.ToDouble(txt10.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm10.Text = "0";
            }
        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAm5.Text = (5 * Convert.ToDouble(txt5.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm5.Text = "0";
            }
        }

        private void txtAm5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtdisplay.Text = (Convert.ToDouble(txtAm1000.Text) + Convert.ToDouble(txtAm500.Text) + Convert.ToDouble(txtAm100.Text) + Convert.ToDouble(txtAm50.Text) + Convert.ToDouble(txtAm20.Text) + Convert.ToDouble(txtAm10.Text) + Convert.ToDouble(txtAm5.Text) + Convert.ToDouble(txtAm2.Text) + Convert.ToDouble(txtAm1.Text)).ToString();

            }
            catch (Exception)
            {
                txtdisplay.Text = "0";
            }
            try
            {
                txtAm5.Text = (5 * Convert.ToDouble(txt5.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm5.Text = "0";
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAm2.Text = (2 * Convert.ToDouble(txt2.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm2.Text = "0";
            }
        }

        private void txtAm2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtdisplay.Text = (Convert.ToDouble(txtAm1000.Text) + Convert.ToDouble(txtAm500.Text) + Convert.ToDouble(txtAm100.Text) + Convert.ToDouble(txtAm50.Text) + Convert.ToDouble(txtAm20.Text) + Convert.ToDouble(txtAm10.Text) + Convert.ToDouble(txtAm5.Text) + Convert.ToDouble(txtAm2.Text) + Convert.ToDouble(txtAm1.Text)).ToString();

            }
            catch (Exception)
            {
                txtdisplay.Text = "0";
            }
            try
            {
                txtAm2.Text = (2 * Convert.ToDouble(txt2.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm2.Text = "0";
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAm1.Text = (1 * Convert.ToDouble(txt1.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm1.Text = "0";
            }
        }

        private void txtAm1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtdisplay.Text = (Convert.ToDouble(txtAm1000.Text) + Convert.ToDouble(txtAm500.Text) + Convert.ToDouble(txtAm100.Text) + Convert.ToDouble(txtAm50.Text) + Convert.ToDouble(txtAm20.Text) + Convert.ToDouble(txtAm10.Text) + Convert.ToDouble(txtAm5.Text) + Convert.ToDouble(txtAm2.Text) + Convert.ToDouble(txtAm1.Text)).ToString();

            }
            catch (Exception)
            {
                txtdisplay.Text = "0";
            }
            try
            {
                txtAm1.Text = (1 * Convert.ToDouble(txt1.Text)).ToString();
            }
            catch (Exception)
            {
                txtAm1.Text = "0";
            }
        }
        private void reset()
        {
            txtdisplay.Text = "0";
            txt1000.Text = string.Empty;
            txtAm1000.Text = "0";
            txt500.Text = string.Empty;
            txtAm500.Text = "0";
            txt100.Text = string.Empty;
            txtAm100.Text = "0";
            txt50.Text = string.Empty;
            txtAm50.Text = "0";
            txt20.Text = string.Empty;
            txtAm20.Text = "0";
            txt10.Text = string.Empty;
            txtAm10.Text = "0";
            txt5.Text = string.Empty;
            txtAm5.Text = "0";
            txt2.Text = string.Empty;
            txtAm2.Text = "0";
            txt1.Text = string.Empty;
            txtAm1.Text = "0";
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void txtdisplay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtdisplay.Text = (Convert.ToDouble(txtAm1000.Text) + Convert.ToDouble(txtAm500.Text) + Convert.ToDouble(txtAm100.Text) + Convert.ToDouble(txtAm50.Text) + Convert.ToDouble(txtAm20.Text) + Convert.ToDouble(txtAm10.Text) + Convert.ToDouble(txtAm5.Text) + Convert.ToDouble(txtAm2.Text) + Convert.ToDouble(txtAm1.Text)).ToString();

            }
            catch (Exception)
            {
                txtdisplay.Text = "0";
            }
        }


    }
}
