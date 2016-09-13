using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void EncryptionButton_Click(object sender, EventArgs e)
    {
        EncryptionService.ServiceClient EncryptService = new EncryptionService.ServiceClient();
        string inputString = Convert.ToString(EncryptTextBox.Text);
        string encryptedString = EncryptService.Encrypt(inputString);
        EncryptOutLabel.Text = encryptedString.ToString();
        string decryptedString = EncryptService.Decrypt(encryptedString);
        DecryptOutLabel.Text = decryptedString.ToString();
    }

    protected void GetQuoteButton_Click(object sender, EventArgs e)
    {
        StockQuoteService.ServiceClient QuoteService = new StockQuoteService.ServiceClient();
        string inputSymbol = Convert.ToString(StockQuoteTextBox.Text);
        string stockQuote = QuoteService.getStockquote(inputSymbol);
        QuoteOutput.Text = stockQuote.ToString();
    }
}