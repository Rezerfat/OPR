using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Round : Фигура
    {
        public double R;
        public Round()
        {
            Console.WriteLine("Фигура, состоящая из множества точек, отдалённых от друг от друга на одинаковом расстоянии");
            Console.WriteLine($"Площадь круга равна PI * R^2");
        }
        public override void Area()
        {
            Console.WriteLine("Площадь равна: ");
        }

        public double Area(double R)
        {
            return Math.PI * R * R;
        }
    }
}
