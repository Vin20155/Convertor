using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertor
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {
            double celsius, kelvin, fahrenheit;

            if (double.TryParse(txtCelsius.Text, out celsius))
            {
                // Convert Celsius to Kelvin & Fahrenheit
                kelvin = celsius + 273.15;
                fahrenheit = (celsius * 9 / 5) + 32;

                // Display results
                txtKelvin.Text = kelvin.ToString("F2");
                txtFahrenheit.Text = fahrenheit.ToString("F2");
            }
            else
            {
                // Clear Kelvin & Fahrenheit fields if input is invalid
                txtKelvin.Clear();
                txtFahrenheit.Clear();
            }
        }

        

        private void comboBoxConversion_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (comboBoxConversion.SelectedIndex == 0) // Celsius to Kelvin & Fahrenheit
            {
                lblCelsius.Enabled = true;
                txtCelsius.Enabled = true;

                lblKelvin.Enabled = false;
                txtKelvin.Enabled = false;

                lblFahrenheit.Enabled = false;
                txtFahrenheit.Enabled = false;
            }
            else if (comboBoxConversion.SelectedIndex == 1) // Kelvin to Celsius & Fahrenheit
            {
                lblCelsius.Enabled = false;
                txtCelsius.Enabled = false;

                lblKelvin.Enabled = true;
                txtKelvin.Enabled = true;

                lblFahrenheit.Enabled = false;
                txtFahrenheit.Enabled = false;
            }
            else if (comboBoxConversion.SelectedIndex == 2) // Fahrenheit to Celsius & Kelvin
            {
                lblCelsius.Enabled = false;
                txtCelsius.Enabled = false;

                lblKelvin.Enabled = false;
                txtKelvin.Enabled = false;

                lblFahrenheit.Enabled = true;
                txtFahrenheit.Enabled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
