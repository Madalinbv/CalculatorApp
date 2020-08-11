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
           public partial class FormHomepage : Form
        {
            FormAbout formAbout;
            FormCalculator formCalculator;
            public FormHomepage()
            {
                InitializeComponent();
                formAbout = new FormAbout();
                formAbout.Visible = false;
                formCalculator.Visible = false;
            }

            private void ButtonAboutForm_Click(object sender, EventArgs e)
            {
                if (formAbout.Visible == true)
                    formAbout.Visible = false;
                else
                    formAbout.Visible = true;

            }

            private void ButtonCalculatorForm_Click(object sender, EventArgs e)
            {
                if (formCalculator.Visible == true)
                    formCalculator.Visible = false;
                else
                    formCalculator.Visible = true;

            }
        }
    }
