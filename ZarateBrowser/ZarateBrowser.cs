using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarateBrowser
{
    public partial class ZarateBrowser : Form
    {
        public ZarateBrowser()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl.Text);
        }

        private void ZarateBrowser_Load(object sender, EventArgs e)
        {

        }

        private void FtoCButton_Click(object sender, EventArgs e)
        {
            TempService.Service1Client TempService = new TempService.Service1Client();
            double fahrValue = Convert.ToDouble(this.fahrnIn.Text);
            double celsValue = TempService.FahrenheitToCelsius(fahrValue);
            celciusOut.Text = celsValue.ToString();
        }

        private void CtoFButton_Click(object sender, EventArgs e)
        {
            TempService.Service1Client TempService = new TempService.Service1Client();
            double celsValue = Convert.ToDouble(this.CelciusIn.Text);
            double fahrValue = TempService.CelsiusToFahrenheit(celsValue);
            FahrenOut.Text = fahrValue.ToString();
        }

        public class TempService
        {
        }
    }
}
