using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Ромб : Figure4
    {
        public double d1, d2;
        public Ромб()
        {
            Console.WriteLine("Площадь ромба равна 1/2 * d1 * d2");
        }
        public double Area(double d1, double d2)
        {
            return 0.5 * d1 * d2;
        }
    }
}
