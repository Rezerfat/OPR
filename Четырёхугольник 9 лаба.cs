using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Figure4 : Фигура
    {
        public Figure4()
        {
            Console.WriteLine("Фигура состоит из прямых линий");
            Console.WriteLine("Фигура имеет 4 угла");
        }
        public override void Area() 
        {
            Console.WriteLine("Площадь равна: ");
        }
    }
}
