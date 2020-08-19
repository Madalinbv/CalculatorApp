using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            decimal rezultat = termen1 * termen2;
            textBoxRezultat.Text = rezultat.ToString();

        }

        private void buttonAdunare_Click(object sender, EventArgs e)
        {
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            decimal rezultat = termen1 + termen2;
            textBoxRezultat.Text = rezultat.ToString();

        }

        private void buttonScadere_Click(object sender, EventArgs e)
        {
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            decimal rezultat = termen1 - termen2;
            textBoxRezultat.Text = rezultat.ToString();

        }

        private void buttonImpartire_Click(object sender, EventArgs e)
        {
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;
            /*decimal rezultat = termen1 / termen2;
            textBoxRezultat.Text = rezultat.ToString();*/
            try
              {
                  decimal rezultat = termen1 / termen2;
                  textBoxRezultat.Text = rezultat.ToString();
              }
            catch (DivideByZeroException exc)
              {
                  string message = "Do not divide by 0 :slight_smile: ";
                  string title = "Divide by 0";
                  MessageBox.Show(message, title);
              }
            /*if (termen2 == 0)
                {
                string message = "Division by 0!";
                string title = "Do not divide by 0";
                MessageBox.Show(message, title);
            }
            else
            {

                decimal rezultat = termen1 / termen2;
                textBoxRezultat.Text = rezultat.ToString();
            }*/

        }
    }
}
