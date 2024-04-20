namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Фигура[] фигуры = { new Ромб(), new Квадрат(), new Round() };
           // Console.WriteLine();

            Console.WriteLine("Введите число на клавиатуре, чтобы выбрать фигуру, посмотреть его свойства и найти площадь");
            Console.WriteLine("1. Ромб");
            Console.WriteLine("2. Квадрат");
            Console.WriteLine("3. Круг");
            int choice;
            F1:
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Вы некорретно ввели число. Повторите попытку");
                goto F1;
            }
            switch (choice) {

                case 1:
                   
                    Console.WriteLine();
                    Ромб ромб = new Ромб();

                    Console.WriteLine("Введите длину первой и второй диагонали");
                    double d1;
                    double d2;
                    D1:
                    try
                    {
                        d1 = double.Parse(Console.ReadLine());
                    }
                    catch {
                        Console.WriteLine("Вы некорретно ввели значение первой диагонали. Повторите попытку");
                        goto D1;
                    }
                    D2:
                    try
                    {
                        d2 = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Вы некорретно ввели значение второй диагонали. Повторите попытку");
                        goto D2;
                    }

                    ромб.Area();
                    Console.WriteLine(ромб.Area(d1, d2));

                    break;

                case 2:

                    Console.WriteLine();
                    Квадрат квадрат = new Квадрат();

                    Console.WriteLine("Введите длину стороны квадрата");

                    double a;

                A1:
                    try
                    {
                        a = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Вы некорретно ввели значение стороны. Повторите попытку");
                        goto A1;
                    }

                    квадрат.Area();
                    Console.WriteLine(квадрат.Area(a));

                    break;

                case 3:

                    Console.WriteLine();
                    Round round = new Round();

                    Console.WriteLine("Введите радиус круга");

                    double R;


                R1:
                    try
                    {
                        R = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Вы некорретно ввели значение радиуса. Повторите попытку");
                        goto R1;
                    }


                    round.Area();
                    Console.WriteLine(round.Area(R));

                    break;
            }
        }
    }
}
