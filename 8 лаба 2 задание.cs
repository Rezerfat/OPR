using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Binary1
{
    public string cel_part;
    public string drob_part2;

    public string Sum(string binary1, string binary2)
    {
        // Перевод первого числа в десятичную форму


        goto E2;
    F2:

        binary1 = Console.ReadLine();


    E2:
        foreach (char t in binary1)
        {
            if (!(t == '1' || t == '0' || t == ','))
            {
                Console.WriteLine("Вы некорретно ввели двоичное число 1. Повторите попытку");
                goto F2;
            }
        }




        string[] parts1 = binary1.Split(",");

        char[] one_word1 = parts1[0].ToArray();
        char[] two_word1;


        if (parts1.Length == 1)
        {
            two_word1 = "".ToArray();
        }

        else
            two_word1 = parts1[1].ToArray();



        double one_sum1 = 0, two_sum1 = 0;

        for (int i = 0; i < one_word1.Length; i++) {

            int k = one_word1.Length - (i + 1);

            char a = one_word1[i];
            string b = a.ToString();

            one_sum1 = Math.Pow(2, k) * (Convert.ToInt32(b))  + one_sum1;
        }

        for (int i = 0; i < two_word1.Length; i++)
        {

            int k = - ( i + 1);

            char a = two_word1[i];
            string b = a.ToString();

            two_sum1 = Math.Pow(2, k) * (Convert.ToInt32(b)) + two_sum1;
        }

        double one_final_sum = one_sum1 + two_sum1;


        // Перевод второго числа в десятичную форму


        goto E3;
    F3:

        binary2 = Console.ReadLine();


    E3:
        foreach (char a in binary2)
        {
            if (!(a == '1' || a == '0' || a == ','))
            {
                Console.WriteLine("Вы некорретно ввели двоичное число 2. Повторите попытку");
                goto F3;
            }
        }




        string[] parts2 = binary2.Split(",");

        char[] one_word2 = parts2[0].ToArray();
        char[] two_word2;


        if (parts2.Length == 1)
        {
            two_word2 = "".ToArray();
        }

        else
            two_word2 = parts2[1].ToArray();



        double one_sum2 = 0, two_sum2 = 0;

        for (int i = 0; i < one_word2.Length; i++)
        {

            int k = one_word2.Length - (i + 1);

            char a = one_word2[i];
            string b = a.ToString();

            one_sum2 = Math.Pow(2, k) * (Convert.ToInt32(b)) + one_sum2;
        }

        for (int i = 0; i < two_word2.Length; i++)
        {

            int k = -(i + 1);

            char a = two_word2[i];
            string b = a.ToString();

            two_sum2 = Math.Pow(2, k) * (Convert.ToInt32(b)) + two_sum2;
        }

        double two_final_sum = one_sum2 + two_sum2;

        // Сложение двух чисел в десятичной форме

        double sum = one_final_sum + two_final_sum;

        // Перевод в двоичную форму

        string cel_part, drob_part = "";

        cel_part = Convert.ToString((int)sum, 2);

        string[] s = Convert.ToString(sum).Split(",");

        string _part2;

        double drob_double_part;
        if (s.Length == 2)
        {
            _part2 = "0," + s[1];

            drob_double_part = Convert.ToDouble(_part2);
        }
        else
        {
            _part2 = "0";

            drob_double_part = Convert.ToDouble(_part2);
        }
        


        for (int i = 0; i < 6; i++)
        {
            drob_double_part *= 2;

            drob_part = Convert.ToString((int)(drob_double_part)) + drob_part;

            drob_double_part -= (int)drob_double_part;
        }


        return $"{cel_part},{drob_part}";
    }


    public string Det(string binary1, string binary2)
    {

        // Перевод первого числа в десятичную форму


        goto E2;
    F2:

        binary1 = Console.ReadLine();


    E2:
        foreach (char t in binary1)
        {
            if (!(t == '1' || t == '0' || t == ','))
            {
                Console.WriteLine("Вы некорретно ввели двоичное число 1. Повторите попытку");
                goto F2;
            }
        }




        string[] parts1 = binary1.Split(",");

        char[] one_word1 = parts1[0].ToArray();
        char[] two_word1;


        if (parts1.Length == 1)
        {
            two_word1 = "".ToArray();
        }

        else
            two_word1 = parts1[1].ToArray();



        double one_sum1 = 0, two_sum1 = 0;

        for (int i = 0; i < one_word1.Length; i++)
        {

            int k = one_word1.Length - (i + 1);

            char a = one_word1[i];
            string b = a.ToString();

            one_sum1 = Math.Pow(2, k) * (Convert.ToInt32(b)) + one_sum1;
        }

        for (int i = 0; i < two_word1.Length; i++)
        {

            int k = -(i + 1);

            char a = two_word1[i];
            string b = a.ToString();

            two_sum1 = Math.Pow(2, k) * (Convert.ToInt32(b)) + two_sum1;
        }

        double one_final_sum = one_sum1 + two_sum1;


        // Перевод второго числа в десятичную форму


        goto E3;
    F3:

        binary2 = Console.ReadLine();


    E3:
        foreach (char a in binary2)
        {
            if (!(a == '1' || a == '0' || a == ','))
            {
                Console.WriteLine("Вы некорретно ввели двоичное число 2. Повторите попытку");
                goto F3;
            }
        }




        string[] parts2 = binary2.Split(",");

        char[] one_word2 = parts2[0].ToArray();
        char[] two_word2;


        if (parts2.Length == 1)
        {
            two_word2 = "".ToArray();
        }

        else
            two_word2 = parts2[1].ToArray();



        double one_sum2 = 0, two_sum2 = 0;

        for (int i = 0; i < one_word2.Length; i++)
        {

            int k = one_word2.Length - (i + 1);

            char a = one_word2[i];
            string b = a.ToString();

            one_sum2 = Math.Pow(2, k) * (Convert.ToInt32(b)) + one_sum2;
        }

        for (int i = 0; i < two_word2.Length; i++)
        {

            int k = -(i + 1);

            char a = two_word2[i];
            string b = a.ToString();

            two_sum2 = Math.Pow(2, k) * (Convert.ToInt32(b)) + two_sum2;
        }

        double two_final_sum = one_sum2 + two_sum2;

        // Умножение двух чисел в десятичной форме

        double sum = one_final_sum * two_final_sum;

        // Перевод в двоичную форму

        string cel_part, drob_part = "";

        cel_part = Convert.ToString((int)sum, 2);

        string[] s = Convert.ToString(sum).Split(",");

        string _part2;

        double drob_double_part;
        if (s.Length == 2)
        {
            _part2 = "0," + s[1];

            drob_double_part = Convert.ToDouble(_part2);
        }
        else
        {
            _part2 = "0";

            drob_double_part = Convert.ToDouble(_part2);
        }



        for (int i = 0; i < 6; i++)
        {
            drob_double_part *= 2;

            drob_part = Convert.ToString((int)(drob_double_part)) + drob_part;

            drob_double_part -= (int)drob_double_part;
        }


        return $"{cel_part},{drob_part}";
    }

    public string Vvod(string number)
    {

        goto E1;

         F1:

        number = Console.ReadLine();


        E1:
        foreach (char s in number)
        {
            if (!(s == '1' || s == '0' || s == ','))
            {
                Console.WriteLine("Вы некорретно ввели двоичное число. Повторите попытку");
                goto F1;
            }
        }

      
        string[] parts1 = number.Split(",");
        char[] two_word1;
        char[] one_word1 = parts1[0].ToArray();

        if (parts1.Length == 1)
        {
            two_word1 = "".ToArray();
        }

        else
            two_word1 = parts1[1].ToArray();


        double one_sum1 = 0, two_sum1 = 0;

        for (int i = 0; i < one_word1.Length; i++)
        {

            int k = one_word1.Length - (i + 1);

            char a = one_word1[i];
            string b = a.ToString();

            one_sum1 = Math.Pow(2, k) * (Convert.ToInt32(b)) + one_sum1;
        }

        for (int i = 0; i < two_word1.Length; i++)
        {

            int k = -(i + 1);

            char a = two_word1[i];
            string b = a.ToString();

            two_sum1 = Math.Pow(2, k) * (Convert.ToInt32(b)) + two_sum1;
        }

        double one_final_sum = one_sum1 + two_sum1;

        return $"Результат: {one_final_sum}";
    }

    public string Vivod(double number)
    {
        string cel_part, drob_part = "";

        cel_part = Convert.ToString((int)number, 2);

        string[] s = Convert.ToString(number).Split(",");
        string _part2;
        if (s.Length == 2)
        {
            _part2 = "0," + s[1];
        }
        else _part2 = "0";
        double drob_double_part = Convert.ToDouble(_part2);


        for (int i = 0; i < 6; i++)
        {
            drob_double_part *= 2;

            drob_part = Convert.ToString((int)(drob_double_part)) + drob_part;

            drob_double_part -= (int)drob_double_part;
        }

        return $"Результат {cel_part},{drob_part}";
    }

}



namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Binary1 binary1 = new Binary1();
                
                Console.WriteLine("Введите число, чтобы выбрать одно из следующих действий:");
                Console.WriteLine();
                Console.WriteLine("1. Перевести двоичное число в десятичное" );
                Console.WriteLine("2. Перевести десятичное число в двоичное");
            Console.WriteLine("3. Сложить два двоичных числа");
            Console.WriteLine("4. Умножить два двоичных числа");

            int choice;
            R1:
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели некорретное число. Повторите попытку");
                goto R1;
            }
            switch(choice)
            {
                case 1:

                    Console.WriteLine("Введите двоичное число");
                    string str_number = Console.ReadLine();
                    Console.WriteLine(binary1.Vvod(str_number).ToString());
                    break;

                case 2:

                    Console.WriteLine("Введите десятичное число");
                W:
                    double number;
                    try
                    {
                        number = double.Parse(Console.ReadLine());
                    }
                    catch {
                        Console.WriteLine("Вы некорретно ввели десятичное число. Повторите попытку");
                        goto W;
                    }
                    Console.WriteLine(binary1.Vivod(number).ToString());
                    break;

                case 3:

                    Console.WriteLine("Введите два двоичных числа");
                    string str_number1 = (Console.ReadLine()); 
                    string str_number2 = (Console.ReadLine());
                    Console.WriteLine(binary1.Sum(str_number1, str_number2).ToString());
                    break;

                case 4:

                    Console.WriteLine("Введите два двоичных числа");
                    str_number1 = (Console.ReadLine());
                    str_number2 = (Console.ReadLine());
                    Console.WriteLine(binary1.Det(str_number1, str_number2).ToString());
                    break;
            }
        }
    }
}
