using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Квадрат : Figure4
    {
        public double a;
        public Квадрат() 
        {
            Console.WriteLine("Площадь квадрата равна a^2 ");
        }

        public double Area(double a)
        {
            return a*a;
        }
    }
}
