using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal struct Запись
    {
        public string surname;
        public string name;

        public int group;
        public int R1;
        public int R2;
        public int R3;
        public int R4;
        public int R5;

        public override string ToString()
        {
            return $"{surname} {name} {group}        {R1} {R2} {R3} {R4} {R5}";
        }
    }
}
