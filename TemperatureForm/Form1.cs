using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FtoC_Click(object sender, EventArgs e)
        {
            TempService.Service1Client TempService = new TempService.Service1Client();
            double fahrValue = Convert.ToDouble(this.FarhenBox.Text);
            double celsValue = TempService.FahrenheitToCelsius(fahrValue);
            FtoCOutput.Text = celsValue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TempService.Service1Client TempService = new TempService.Service1Client();
            double celsValue = Convert.ToDouble(this.CelsiusBox.Text);
            double fahrValue = TempService.CelsiusToFahrenheit(celsValue);
            CtoFOutput.Text = fahrValue.ToString();
        }
    }
}
