namespace Convertor
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
            this.lblCelsius = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.comboBoxConversion = new System.Windows.Forms.ComboBox();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsius.Location = new System.Drawing.Point(342, 117);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(142, 22);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "Degrees Celsius";
            this.lblCelsius.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(529, 116);
            this.txtCelsius.Multiline = true;
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(192, 41);
            this.txtCelsius.TabIndex = 1;
            this.txtCelsius.TextChanged += new System.EventHandler(this.txtCelsius_TextChanged);
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(529, 173);
            this.txtKelvin.Multiline = true;
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(192, 41);
            this.txtKelvin.TabIndex = 2;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(529, 234);
            this.txtFahrenheit.Multiline = true;
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(192, 41);
            this.txtFahrenheit.TabIndex = 3;
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelvin.Location = new System.Drawing.Point(342, 174);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(132, 22);
            this.lblKelvin.TabIndex = 4;
            this.lblKelvin.Text = "Degrees Kelvin";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit.Location = new System.Drawing.Point(342, 235);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(169, 22);
            this.lblFahrenheit.TabIndex = 5;
            this.lblFahrenheit.Text = "Degrees Fahrenheit";
            // 
            // comboBoxConversion
            // 
            this.comboBoxConversion.FormattingEnabled = true;
            this.comboBoxConversion.Items.AddRange(new object[] {
            "Convert from Celsius to Kelvin & Fahrenheit",
            "Convert from Kelvin to Celsius & Fahrenheit",
            "Convert from Fahrenheit to Celsius & Kelvin"});
            this.comboBoxConversion.Location = new System.Drawing.Point(57, 40);
            this.comboBoxConversion.Name = "comboBoxConversion";
            this.comboBoxConversion.Size = new System.Drawing.Size(340, 28);
            this.comboBoxConversion.TabIndex = 6;
            this.comboBoxConversion.Text = "Convert from Celsius to Kelvin & Fahrenheit";
            this.comboBoxConversion.SelectedIndexChanged += new System.EventHandler(this.comboBoxConversion_SelectedIndexChanged_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxConversion);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.lblCelsius);
            this.Name = "Form1";
            this.Text = "Conversion calculation (between Celsius, Kelvin & Fahrenheit)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.ComboBox comboBoxConversion;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}

