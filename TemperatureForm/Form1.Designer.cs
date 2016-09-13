namespace TemperatureForm
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
            this.FtoC = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.FarhenBox = new System.Windows.Forms.TextBox();
            this.CelsiusBox = new System.Windows.Forms.TextBox();
            this.FtoCOutput = new System.Windows.Forms.Label();
            this.CtoFOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FtoC
            // 
            this.FtoC.Location = new System.Drawing.Point(29, 74);
            this.FtoC.Name = "FtoC";
            this.FtoC.Size = new System.Drawing.Size(117, 35);
            this.FtoC.TabIndex = 0;
            this.FtoC.Text = "Fahrenheit to Celsius";
            this.FtoC.UseVisualStyleBackColor = true;
            this.FtoC.Click += new System.EventHandler(this.FtoC_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 42);
            this.button4.TabIndex = 1;
            this.button4.Text = "Celsius to Fahrenhiet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FarhenBox
            // 
            this.FarhenBox.Location = new System.Drawing.Point(29, 32);
            this.FarhenBox.Name = "FarhenBox";
            this.FarhenBox.Size = new System.Drawing.Size(117, 20);
            this.FarhenBox.TabIndex = 2;
            this.FarhenBox.Text = "Enter Fahrenheit Value";
            // 
            // CelsiusBox
            // 
            this.CelsiusBox.Location = new System.Drawing.Point(29, 158);
            this.CelsiusBox.Name = "CelsiusBox";
            this.CelsiusBox.Size = new System.Drawing.Size(117, 20);
            this.CelsiusBox.TabIndex = 3;
            this.CelsiusBox.Text = "Enter Celsius Value";
            // 
            // FtoCOutput
            // 
            this.FtoCOutput.AutoSize = true;
            this.FtoCOutput.Location = new System.Drawing.Point(203, 39);
            this.FtoCOutput.Name = "FtoCOutput";
            this.FtoCOutput.Size = new System.Drawing.Size(123, 13);
            this.FtoCOutput.TabIndex = 4;
            this.FtoCOutput.Text = "Calculated Celsius Value";
            // 
            // CtoFOutput
            // 
            this.CtoFOutput.AutoSize = true;
            this.CtoFOutput.Location = new System.Drawing.Point(203, 165);
            this.CtoFOutput.Name = "CtoFOutput";
            this.CtoFOutput.Size = new System.Drawing.Size(140, 13);
            this.CtoFOutput.TabIndex = 5;
            this.CtoFOutput.Text = "Calculated Fahrenhiet Value";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 285);
            this.Controls.Add(this.CtoFOutput);
            this.Controls.Add(this.FtoCOutput);
            this.Controls.Add(this.CelsiusBox);
            this.Controls.Add(this.FarhenBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.FtoC);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button FtoC;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox FarhenBox;
        private System.Windows.Forms.TextBox CelsiusBox;
        private System.Windows.Forms.Label FtoCOutput;
        private System.Windows.Forms.Label CtoFOutput;
    }
}

