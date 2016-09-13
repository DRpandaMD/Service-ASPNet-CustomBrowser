namespace ZarateBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textURL = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.FahrenTextBox = new System.Windows.Forms.TextBox();
            this.FahrnToCelciusButton = new System.Windows.Forms.Button();
            this.CelciusOutputLabel = new System.Windows.Forms.Label();
            this.CelciusTextBox = new System.Windows.Forms.TextBox();
            this.CelciusToFahrenButton = new System.Windows.Forms.Button();
            this.FahrenOutputLabel = new System.Windows.Forms.Label();
            this.StaticFahrLabel = new System.Windows.Forms.Label();
            this.StaticCelLabel = new System.Windows.Forms.Label();
            this.StaticCyptTextLabel = new System.Windows.Forms.Label();
            this.EncryptTextBoxIn = new System.Windows.Forms.TextBox();
            this.StaticEncryptLabel2 = new System.Windows.Forms.Label();
            this.EncryptionOutput = new System.Windows.Forms.Label();
            this.StaticEncryptLabel3 = new System.Windows.Forms.Label();
            this.DecryptedLabelOut = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.staticLabel1 = new System.Windows.Forms.Label();
            this.StockQuoteTextBox = new System.Windows.Forms.TextBox();
            this.GetQuoteButton = new System.Windows.Forms.Button();
            this.StockQuoteOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(2, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1210, 474);
            this.webBrowser1.TabIndex = 0;
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(2, 2);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(570, 20);
            this.textURL.TabIndex = 1;
            this.textURL.Text = "http://google.com";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(623, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GO!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // FahrenTextBox
            // 
            this.FahrenTextBox.Location = new System.Drawing.Point(13, 604);
            this.FahrenTextBox.Name = "FahrenTextBox";
            this.FahrenTextBox.Size = new System.Drawing.Size(120, 20);
            this.FahrenTextBox.TabIndex = 3;
            this.FahrenTextBox.Text = "Enter Farhenhiet Value";
            // 
            // FahrnToCelciusButton
            // 
            this.FahrnToCelciusButton.Location = new System.Drawing.Point(13, 630);
            this.FahrnToCelciusButton.Name = "FahrnToCelciusButton";
            this.FahrnToCelciusButton.Size = new System.Drawing.Size(120, 33);
            this.FahrnToCelciusButton.TabIndex = 4;
            this.FahrnToCelciusButton.Text = "Convert!";
            this.FahrnToCelciusButton.UseVisualStyleBackColor = true;
            this.FahrnToCelciusButton.Click += new System.EventHandler(this.FahrnToCelciusButton_Click);
            // 
            // CelciusOutputLabel
            // 
            this.CelciusOutputLabel.AutoSize = true;
            this.CelciusOutputLabel.Location = new System.Drawing.Point(163, 590);
            this.CelciusOutputLabel.Name = "CelciusOutputLabel";
            this.CelciusOutputLabel.Size = new System.Drawing.Size(76, 13);
            this.CelciusOutputLabel.TabIndex = 5;
            this.CelciusOutputLabel.Text = "Celcius Output";
            // 
            // CelciusTextBox
            // 
            this.CelciusTextBox.Location = new System.Drawing.Point(13, 709);
            this.CelciusTextBox.Name = "CelciusTextBox";
            this.CelciusTextBox.Size = new System.Drawing.Size(120, 20);
            this.CelciusTextBox.TabIndex = 6;
            this.CelciusTextBox.Text = "Enter Celcius Value";
            // 
            // CelciusToFahrenButton
            // 
            this.CelciusToFahrenButton.Location = new System.Drawing.Point(13, 735);
            this.CelciusToFahrenButton.Name = "CelciusToFahrenButton";
            this.CelciusToFahrenButton.Size = new System.Drawing.Size(120, 37);
            this.CelciusToFahrenButton.TabIndex = 7;
            this.CelciusToFahrenButton.Text = "Convert!";
            this.CelciusToFahrenButton.UseVisualStyleBackColor = true;
            this.CelciusToFahrenButton.Click += new System.EventHandler(this.CelciusToFahrenButton_Click);
            // 
            // FahrenOutputLabel
            // 
            this.FahrenOutputLabel.AutoSize = true;
            this.FahrenOutputLabel.Location = new System.Drawing.Point(166, 744);
            this.FahrenOutputLabel.Name = "FahrenOutputLabel";
            this.FahrenOutputLabel.Size = new System.Drawing.Size(92, 13);
            this.FahrenOutputLabel.TabIndex = 8;
            this.FahrenOutputLabel.Text = "Fahrenhiet Output";
            // 
            // StaticFahrLabel
            // 
            this.StaticFahrLabel.AutoSize = true;
            this.StaticFahrLabel.Location = new System.Drawing.Point(10, 573);
            this.StaticFahrLabel.Name = "StaticFahrLabel";
            this.StaticFahrLabel.Size = new System.Drawing.Size(124, 13);
            this.StaticFahrLabel.TabIndex = 9;
            this.StaticFahrLabel.Text = "Enter a Fahrenhiet Value";
            // 
            // StaticCelLabel
            // 
            this.StaticCelLabel.AutoSize = true;
            this.StaticCelLabel.Location = new System.Drawing.Point(12, 684);
            this.StaticCelLabel.Name = "StaticCelLabel";
            this.StaticCelLabel.Size = new System.Drawing.Size(108, 13);
            this.StaticCelLabel.TabIndex = 10;
            this.StaticCelLabel.Text = "Enter a Celcius Value";
            // 
            // StaticCyptTextLabel
            // 
            this.StaticCyptTextLabel.AutoSize = true;
            this.StaticCyptTextLabel.Location = new System.Drawing.Point(302, 589);
            this.StaticCyptTextLabel.Name = "StaticCyptTextLabel";
            this.StaticCyptTextLabel.Size = new System.Drawing.Size(105, 13);
            this.StaticCyptTextLabel.TabIndex = 11;
            this.StaticCyptTextLabel.Text = "Enter text to encrypt!";
            // 
            // EncryptTextBoxIn
            // 
            this.EncryptTextBoxIn.Location = new System.Drawing.Point(305, 603);
            this.EncryptTextBoxIn.Name = "EncryptTextBoxIn";
            this.EncryptTextBoxIn.Size = new System.Drawing.Size(123, 20);
            this.EncryptTextBoxIn.TabIndex = 12;
            // 
            // StaticEncryptLabel2
            // 
            this.StaticEncryptLabel2.AutoSize = true;
            this.StaticEncryptLabel2.Location = new System.Drawing.Point(302, 630);
            this.StaticEncryptLabel2.Name = "StaticEncryptLabel2";
            this.StaticEncryptLabel2.Size = new System.Drawing.Size(154, 13);
            this.StaticEncryptLabel2.TabIndex = 13;
            this.StaticEncryptLabel2.Text = "The encrypted Text Looks like:";
            // 
            // EncryptionOutput
            // 
            this.EncryptionOutput.AutoSize = true;
            this.EncryptionOutput.Location = new System.Drawing.Point(463, 630);
            this.EncryptionOutput.Name = "EncryptionOutput";
            this.EncryptionOutput.Size = new System.Drawing.Size(44, 13);
            this.EncryptionOutput.TabIndex = 14;
            this.EncryptionOutput.Text = "\"Temp\"";
            // 
            // StaticEncryptLabel3
            // 
            this.StaticEncryptLabel3.AutoSize = true;
            this.StaticEncryptLabel3.Location = new System.Drawing.Point(305, 647);
            this.StaticEncryptLabel3.Name = "StaticEncryptLabel3";
            this.StaticEncryptLabel3.Size = new System.Drawing.Size(114, 13);
            this.StaticEncryptLabel3.TabIndex = 15;
            this.StaticEncryptLabel3.Text = "Decrypted it looks like:";
            // 
            // DecryptedLabelOut
            // 
            this.DecryptedLabelOut.AutoSize = true;
            this.DecryptedLabelOut.Location = new System.Drawing.Point(448, 649);
            this.DecryptedLabelOut.Name = "DecryptedLabelOut";
            this.DecryptedLabelOut.Size = new System.Drawing.Size(44, 13);
            this.DecryptedLabelOut.TabIndex = 16;
            this.DecryptedLabelOut.Text = "\"Temp\"";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(451, 600);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 17;
            this.EncryptButton.Text = "Encrypt It!";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // staticLabel1
            // 
            this.staticLabel1.AutoSize = true;
            this.staticLabel1.Location = new System.Drawing.Point(623, 600);
            this.staticLabel1.Name = "staticLabel1";
            this.staticLabel1.Size = new System.Drawing.Size(135, 13);
            this.staticLabel1.TabIndex = 18;
            this.staticLabel1.Text = "Enter a Stock to get quote!";
            // 
            // StockQuoteTextBox
            // 
            this.StockQuoteTextBox.Location = new System.Drawing.Point(626, 617);
            this.StockQuoteTextBox.Name = "StockQuoteTextBox";
            this.StockQuoteTextBox.Size = new System.Drawing.Size(132, 20);
            this.StockQuoteTextBox.TabIndex = 19;
            this.StockQuoteTextBox.Text = "Stock Symbols";
            // 
            // GetQuoteButton
            // 
            this.GetQuoteButton.Location = new System.Drawing.Point(626, 649);
            this.GetQuoteButton.Name = "GetQuoteButton";
            this.GetQuoteButton.Size = new System.Drawing.Size(132, 23);
            this.GetQuoteButton.TabIndex = 20;
            this.GetQuoteButton.Text = "Get Quote";
            this.GetQuoteButton.UseVisualStyleBackColor = true;
            this.GetQuoteButton.Click += new System.EventHandler(this.GetQuoteButton_Click);
            // 
            // StockQuoteOutput
            // 
            this.StockQuoteOutput.AutoSize = true;
            this.StockQuoteOutput.Location = new System.Drawing.Point(626, 683);
            this.StockQuoteOutput.Name = "StockQuoteOutput";
            this.StockQuoteOutput.Size = new System.Drawing.Size(44, 13);
            this.StockQuoteOutput.TabIndex = 21;
            this.StockQuoteOutput.Text = "\"ouput\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 827);
            this.Controls.Add(this.StockQuoteOutput);
            this.Controls.Add(this.GetQuoteButton);
            this.Controls.Add(this.StockQuoteTextBox);
            this.Controls.Add(this.staticLabel1);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.DecryptedLabelOut);
            this.Controls.Add(this.StaticEncryptLabel3);
            this.Controls.Add(this.EncryptionOutput);
            this.Controls.Add(this.StaticEncryptLabel2);
            this.Controls.Add(this.EncryptTextBoxIn);
            this.Controls.Add(this.StaticCyptTextLabel);
            this.Controls.Add(this.StaticCelLabel);
            this.Controls.Add(this.StaticFahrLabel);
            this.Controls.Add(this.FahrenOutputLabel);
            this.Controls.Add(this.CelciusToFahrenButton);
            this.Controls.Add(this.CelciusTextBox);
            this.Controls.Add(this.CelciusOutputLabel);
            this.Controls.Add(this.FahrnToCelciusButton);
            this.Controls.Add(this.FahrenTextBox);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.textURL);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox FahrenTextBox;
        private System.Windows.Forms.Button FahrnToCelciusButton;
        private System.Windows.Forms.Label CelciusOutputLabel;
        private System.Windows.Forms.TextBox CelciusTextBox;
        private System.Windows.Forms.Button CelciusToFahrenButton;
        private System.Windows.Forms.Label FahrenOutputLabel;
        private System.Windows.Forms.Label StaticFahrLabel;
        private System.Windows.Forms.Label StaticCelLabel;
        private System.Windows.Forms.Label StaticCyptTextLabel;
        private System.Windows.Forms.TextBox EncryptTextBoxIn;
        private System.Windows.Forms.Label StaticEncryptLabel2;
        private System.Windows.Forms.Label EncryptionOutput;
        private System.Windows.Forms.Label StaticEncryptLabel3;
        private System.Windows.Forms.Label DecryptedLabelOut;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Label staticLabel1;
        private System.Windows.Forms.TextBox StockQuoteTextBox;
        private System.Windows.Forms.Button GetQuoteButton;
        private System.Windows.Forms.Label StockQuoteOutput;
    }
}

