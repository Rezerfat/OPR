using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

      

        private void label5_Click(object sender, EventArgs e)
        {
        
            double I, U = 0, R = 0;
            string a = "Вы ввели некорретное значение напряжения!";
            
            try
            {
                U = double.Parse(UMean.Text);
            }
            catch {
                UMean.Text = "Вы ввели некорретное значения напряжения!".ToString();
              
            }

        //Found2:
            try
            {
                
                R = double.Parse(RMean.Text);
            }
            catch
            {
                RMean.Text = "Вы ввели некорретное значения сопротивления!".ToString();
          //      goto Found2;
            }

            I = R * U;

            IMean.Text = I.ToString();
        }
    }
}
