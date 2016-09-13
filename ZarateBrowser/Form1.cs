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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textURL.Text);
        }

        private void FahrnToCelciusButton_Click(object sender, EventArgs e)
        {
            TempService.Service1Client TempService = new TempService.Service1Client();
            double fahrnValue = Convert.ToDouble(this.FahrenTextBox.Text);
            double celsValue = TempService.FahrenheitToCelsius(fahrnValue);
            CelciusOutputLabel.Text = celsValue.ToString();
        }

        private void CelciusToFahrenButton_Click(object sender, EventArgs e)
        {
            TempService.Service1Client TempService = new TempService.Service1Client();
            double celsValue = Convert.ToDouble(this.CelciusTextBox.Text);
            double fahrnValue = TempService.CelsiusToFahrenheit(celsValue);
            FahrenOutputLabel.Text = fahrnValue.ToString();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            EncryptService.ServiceClient CryptService = new EncryptService.ServiceClient();
            string encryptStringIn = Convert.ToString(this.EncryptTextBoxIn.Text);
            string encryptedString = CryptService.Encrypt(encryptStringIn);
            EncryptionOutput.Text = encryptedString.ToString();
            string decryptedString = CryptService.Decrypt(encryptedString);
            DecryptedLabelOut.Text = decryptedString.ToString();

        }

        private void GetQuoteButton_Click(object sender, EventArgs e)
        {
            StockQuoteService.ServiceClient QuoteService = new StockQuoteService.ServiceClient();
            string symbol = Convert.ToString(this.StockQuoteTextBox.Text);
            string quote = QuoteService.getStockquote(symbol);
            StockQuoteOutput.Text = quote.ToString();
        }
    }
}
