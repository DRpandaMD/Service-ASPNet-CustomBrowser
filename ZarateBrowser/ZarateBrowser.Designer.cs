namespace ZarateBrowser
{
    partial class ZarateBrowser
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.FtoCButton = new System.Windows.Forms.Button();
            this.fahrnIn = new System.Windows.Forms.TextBox();
            this.celciusOut = new System.Windows.Forms.Label();
            this.CtoFButton = new System.Windows.Forms.Button();
            this.CelciusIn = new System.Windows.Forms.TextBox();
            this.FahrnOut = new System.Windows.Forms.Label();
            this.FahrenOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(2, 37);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1468, 759);
            this.webBrowser1.TabIndex = 0;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(18, 2);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(640, 26);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://";
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(724, -3);
            this.btnGO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(112, 35);
            this.btnGO.TabIndex = 2;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // FtoCButton
            // 
            this.FtoCButton.Location = new System.Drawing.Point(67, 906);
            this.FtoCButton.Name = "FtoCButton";
            this.FtoCButton.Size = new System.Drawing.Size(156, 53);
            this.FtoCButton.TabIndex = 3;
            this.FtoCButton.Text = "Convert! (F to C)";
            this.FtoCButton.UseVisualStyleBackColor = true;
            this.FtoCButton.Click += new System.EventHandler(this.FtoCButton_Click);
            // 
            // fahrnIn
            // 
            this.fahrnIn.Location = new System.Drawing.Point(67, 838);
            this.fahrnIn.Name = "fahrnIn";
            this.fahrnIn.Size = new System.Drawing.Size(156, 26);
            this.fahrnIn.TabIndex = 4;
            this.fahrnIn.Text = "Enter Fahrenhiet";
            // 
            // celciusOut
            // 
            this.celciusOut.AutoSize = true;
            this.celciusOut.Location = new System.Drawing.Point(255, 924);
            this.celciusOut.Name = "celciusOut";
            this.celciusOut.Size = new System.Drawing.Size(55, 20);
            this.celciusOut.TabIndex = 5;
            this.celciusOut.Text = "output";
            // 
            // CtoFButton
            // 
            this.CtoFButton.Location = new System.Drawing.Point(67, 1046);
            this.CtoFButton.Name = "CtoFButton";
            this.CtoFButton.Size = new System.Drawing.Size(156, 53);
            this.CtoFButton.TabIndex = 6;
            this.CtoFButton.Text = "Convert! (C to F)";
            this.CtoFButton.UseVisualStyleBackColor = true;
            this.CtoFButton.Click += new System.EventHandler(this.CtoFButton_Click);
            // 
            // CelciusIn
            // 
            this.CelciusIn.Location = new System.Drawing.Point(67, 1001);
            this.CelciusIn.Name = "CelciusIn";
            this.CelciusIn.Size = new System.Drawing.Size(156, 26);
            this.CelciusIn.TabIndex = 7;
            this.CelciusIn.Text = "Enter Celcius";
            // 
            // FahrnOut
            // 
            this.FahrnOut.AutoSize = true;
            this.FahrnOut.Location = new System.Drawing.Point(255, 1062);
            this.FahrnOut.Name = "FahrnOut";
            this.FahrnOut.Size = new System.Drawing.Size(0, 20);
            this.FahrnOut.TabIndex = 8;
            // 
            // FahrenOut
            // 
            this.FahrenOut.AutoSize = true;
            this.FahrenOut.Location = new System.Drawing.Point(259, 1062);
            this.FahrenOut.Name = "FahrenOut";
            this.FahrenOut.Size = new System.Drawing.Size(64, 20);
            this.FahrenOut.TabIndex = 9;
            this.FahrenOut.Text = "output2";
            // 
            // ZarateBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 1145);
            this.Controls.Add(this.FahrenOut);
            this.Controls.Add(this.FahrnOut);
            this.Controls.Add(this.CelciusIn);
            this.Controls.Add(this.CtoFButton);
            this.Controls.Add(this.celciusOut);
            this.Controls.Add(this.fahrnIn);
            this.Controls.Add(this.FtoCButton);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.webBrowser1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ZarateBrowser";
            this.Text = "ZarateBrowser";
            this.Load += new System.EventHandler(this.ZarateBrowser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Button FtoCButton;
        private System.Windows.Forms.TextBox fahrnIn;
        private System.Windows.Forms.Label celciusOut;
        private System.Windows.Forms.Button CtoFButton;
        private System.Windows.Forms.TextBox CelciusIn;
        private System.Windows.Forms.Label FahrnOut;
        private System.Windows.Forms.Label FahrenOut;
    }
}

