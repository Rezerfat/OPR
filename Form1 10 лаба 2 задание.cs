using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            double Rg, R1 = 0, R2 = 0;
            try
            {
                R1 = double.Parse(R1Mean.Text);
            }
            catch
            {
                R1Mean.Text = "Вы ввели некорретное значение сопротивления!".ToString();
                
            }

            try
            {
                R2 = double.Parse(R2Mean.Text);
            }
            catch
            {
                R2Mean.Text = "Вы ввели некорретное значение сопротивления!".ToString();

            }

            Rg= (R1 * R2) / (R1 + R2);

            R.Text = Rg.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            double Rg, R1 = 0, R2 = 0;
            try
            {
                R1 = double.Parse(R1Mean.Text);
            }
            catch
            {
                R1Mean.Text = "Вы ввели некорретное значение сопротивления!".ToString();

            }

            try
            {
                R2 = double.Parse(R2Mean.Text);
            }
            catch
            {
                R2Mean.Text = "Вы ввели некорретное значение сопротивления!".ToString();

            }

            Rg = R1 + R2;

            R.Text = Rg.ToString();
        }

        private void R_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
