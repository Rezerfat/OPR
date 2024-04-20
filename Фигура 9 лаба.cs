using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal abstract class Фигура
    {
        public Фигура()
        {
            Console.WriteLine("Геометрическая фигура");
            Console.WriteLine("Двумерная фигура");
        }
       public abstract void Area();
       
    }
}

