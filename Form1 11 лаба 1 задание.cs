using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Задание_1
{
    public partial class Form1 : Form
    {
        public int n, k;
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Pol.Maximum = 1000;
            n = Pol.Value;
            Mean_n.Text = n.ToString();

            k = n * (n + 1) / 2;

            Mean.Text = k.ToString();

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Mean2.Text = sum.ToString();
        }
    }
}
