using Microsoft.VisualBasic;

public class Date
{
    public uint year;
    public uint month;
    public uint day;
    public uint days;

    public uint Dyear
    {
        get { return year; }
        set { year = value; }
    }
 
    public uint Dmonth
    {
        get { return month; }
        set { month = value; }
    }
    public uint Dday
    {
        get { return day; }
        set { day = value; }
    }
    public uint Ddays
    {
        get { return days; }
        set { days = value; }
    }
    public Date(uint year_, uint month_, uint day_, uint days_)
    {
        year = year_;
        month = month_;
        day = day_;
        days = days_;
    }

    public Date(uint year_)
    {
        year = year_;
    }

    public Date Add(Date days_) 
    {
        uint year_result = year + days_.Ddays / 365;

        uint a = days_.Ddays % 365;

        uint month_result = month + a / 31;

        uint b = a % 31;

        if (month_result > 12)
        {
            uint t = month_result / 12;
            year_result = year_result + t;
            month_result = month_result % 12;
        }

        uint day_result = day + b;

        if (day_result > 31)
        {
            uint t = day_result / 31;
            month_result = month_result + t;

            if (month_result > 12)
            {
                uint k = month_result / 12;
                year_result = year_result + k;
                month_result = month_result % 12;
            }

            day_result = day_result % 31;
        }

        return new Date(year_result, month_result, day_result, 0);
    }

    public Date Sub(Date days_)
    {
        uint year_result = year - days_.Ddays / 365;

        uint a = (days_.Ddays % 365) / 31;

        uint month_result;

        if (Convert.ToInt32(month) - a  < 1)
        {
            year_result -= 1;
            month_result = Convert.ToUInt32(12 - (Math.Abs(month - (a / 31))));
        }
        else month_result = month - (a / 31);

        uint day_result;

        uint b = (days_.Ddays % 365) % 31;

        if (Convert.ToInt32(day) - b < 1)
        {
            if (month_result - 1 < 1)
            {
                year_result -= 1;
                month_result = Convert.ToUInt32(12 - (Math.Abs(month - a)));
                day_result = Convert.ToUInt32(31 - (Math.Abs(month - a)));
            }
            else
            {
                month_result -= 1;
                day_result = Convert.ToUInt32(31 - (Math.Abs(Convert.ToInt32(day) - b)));
            }
        }
        else { 
            day_result = day - b; 
        }

        return new Date(year_result, month_result, day_result, 0);
    }

    public string Vis_year(uint year)
    {
        if (year % 4 == 0) return "Год високосный";
        else return "Год не високосный";
    }
    public string year_get(uint year)
    {
        return Convert.ToString(year);
    }
    public string month_get(uint month)
    {
        return Convert.ToString(month);
    }
    public string day_get(uint day)
    {
        return Convert.ToString(day);
    }

   public string Srav(uint year, uint month, uint day, uint year1, uint month1, uint day1)
    {
        if ((year == year1 && month == month1 && day == day1)) return "Даты равны";
        else if ((year == year1 && month == month1 && day < day1 || year == year1 && month < month1 && day == day1) || year < year1 && month == month1 && day == day1 || year == year1 && month < month1 && day < day1 || year < year1 && month == month1 && day < day1 || year < year1 && month < month1 && day == day1 || year < year1 && month < month1 && day < day1 || year < year1 && month > month1 && day < day1 || year < year1 && month > month1 && day > day1 || year < year1 && month < month1 && day > day1 || year < year1 && month > month1 && day < day1) return "Исходная дата меньше";
        else return "Исходная дата больше";
    } 

    public string Gave_year(uint year, uint year1, uint month, uint day)
    {
        year = year1;
        return $"Полученная дата: {year}.{month}.{day}";
    }
    public string Gave_month(uint year, uint month, uint month1, uint day)
    {
        month = month1;
        return $"Полученная дата: {year}.{month}.{day}";
    }
    public string Gave_day(uint year, uint month, uint day, uint day1)
    {
        day = day1;
        return $"Полученная дата: {year}.{month}.{day}";
    }

    public string Sub_Two(uint year, uint month, uint day, uint year1, uint month1, uint day1)
    {
        uint sum, month_sum, day_sum, year_sum;
        month = (month - 1) * 31;
        day = (day - 1);
        month1 = (month1 - 1) * 31;
        day1 = (day1 - 1);
        if (year >= year1)
        {
            sum = (year - year1) * 365 + month + day - (month1 + day1);
            return $"Количество дней между датами: {sum}";
        }
        else
        {
            sum = (year1 - year) * 365 + month1 + day1 - (month + day);
            return $"Количество дней между датами: {sum}";
        }
    }

    public override string ToString()
    {
        return $"{year}.{month}.{day}";
    }
}


namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint year, month, day;
        
            Console.WriteLine("Введите год, месяц, день исходной даты (месяц в виде числа)");
            
            Found17:
            Found1:
            try
            {
                Console.Write("Год: ");
                year = uint.Parse(Console.ReadLine());
                
            }
            catch {
                Console.WriteLine("Вы неправильно ввели число. Повторите заново");
                goto Found1;
            }

        Found2:
            try
            {
                Console.Write("Месяц: ");
                month = uint.Parse(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Диапазон чисел для месяца от 1 до 12. Повторите попытку");
                    goto Found2;
                }
            }
            catch
            {
                Console.WriteLine("Вы неправильно ввели число. Повторите заново");
                goto Found2;
            }

        Found3:
            try
            {
                Console.Write("День: ");
                day = uint.Parse(Console.ReadLine());
                if (day < 1 || day > 31)
                {
                    Console.WriteLine("Диапазон чисел для дня от 1 до 31. Повторите попытку");
                    goto Found3;
                }
            }
            catch
            {
                Console.WriteLine("Вы неправильно ввели число. Повторите заново");
                goto Found3;
            }
            Console.WriteLine();
            Console.WriteLine($"Полученная исходная дата: {year}.{month}.{day}");
            Console.WriteLine();


            
            while (true)
            {

                Console.WriteLine("Введите число, чтобы выбрать одно из следующих действий:");
                Console.WriteLine();
                Console.WriteLine("0. Введение новой исходной даты");
                Console.WriteLine("1. Вычисление даты через заданное количество дней от указанной");
                Console.WriteLine("2. Вычитание заданного количества дней из даты");
                Console.WriteLine("3. Определение високосного года");
                Console.WriteLine("4. Получение года");
                Console.WriteLine("5. Получение месяца");
                Console.WriteLine("6. Получение дня");
                Console.WriteLine("7. Присвоение года");
                Console.WriteLine("8. Присвоение месяца");
                Console.WriteLine("9. Присвоение дня");
                Console.WriteLine("10. Сравнить даты");
                Console.WriteLine("11. Вычисление количества дней между датами");
                Console.WriteLine("12. Выйти из программы");
                int choice;
            Found20:
                try
                {
                    
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Вы ввели неккоретное число. Повторите попытку");
                    goto Found20;
                }

                switch (choice)
                {
                    case 1:
                        uint days;
                        Console.WriteLine("Введите количество дней:");

                        Found4:
                        try
                        {
                            days = uint.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Вы ввели неккоретное число. Повторите попытку");
                            goto Found4;
                        }

                        Date date = new Date(year, month, day, days);
                        Console.WriteLine($"Результат: {date.Add(date)}");
                        break;

                    case 2:
                        Console.WriteLine("Введите количество дней:");

                    Found5:
                        uint days1;
                        Found6:
                        try
                        {
                            days1 = uint.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Вы ввели неккоретное число. Повторите попытку");
                            goto Found6;
                        }

                        Date date1 = new Date(year, month, day, days1);
                        Console.WriteLine($"Результат: {date1.Sub(date1)}");
                        break;

                    case 3:
                        Date date2 = new Date(year, month, day, 0);
                        Console.WriteLine(date2.Vis_year(year));
                        break;

                    case 4:
                        Date date3 = new Date(year, month, day, 0);
                        Console.WriteLine(date3.year_get(year));
                        break;

                    case 5:
                        Date date4 = new Date(year, month, day, 0);
                        Console.WriteLine(date4.month_get(month));
                        break;

                    case 6:
                        Date date5 = new Date(year, month, day, 0);
                        Console.WriteLine(date5.day_get(day));
                        break;

                    case 7:
                        uint year1;
                        Date date6 = new Date(year, month, day, 0);
                        Console.WriteLine("Введите новый год");
                    Found7:
                        try
                        {
                            year1 = uint.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Вы ввели неккоретное число. Повторите попытку");
                            goto Found7;
                        }
                        Console.WriteLine(date6.Gave_year(year, year1, month, day));
                        break;

                    case 8:
                        uint month1;
                        Date date7 = new Date(year, month, day, 0);
                        Console.WriteLine("Введите новый месяц");
                    Found8:
                        try
                        {
                            month1 = uint.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Вы ввели неккоретное число. Повторите попытку");
                            goto Found8;
                        }
                        Console.WriteLine(date7.Gave_month(year, month, month1, day));
                        break;

                    case 9:
                        uint day1;
                        Date date8 = new Date(year, month, day, 0);
                        Console.WriteLine("Введите новый день");
                    Found9:
                        try
                        {
                            day1 = uint.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Вы ввели неккоретное число. Повторите попытку");
                            goto Found9;
                        }
                        Console.WriteLine(date8.Gave_day(year, month, day, day1));
                        break;

                        case 10:
                        uint year2, month2, day2;
                        Date date9 = new Date(year, month, day, 0);
                        Console.WriteLine("Введите год, месяц, день даты, с которой необходимо сравнить исходную дату");

                    Found10:
                        try
                        {
                            Console.Write("Год: ");
                            year2 = uint.Parse(Console.ReadLine());

                        }
                        catch
                        {
                            Console.WriteLine("Вы неправильно ввели число. Повторите заново");
                            goto Found10;
                        }

                    Found11:
                        try
                        {
                            Console.Write("Месяц: ");
                            month2 = uint.Parse(Console.ReadLine());
                            if (month2 < 1 || month2 > 12)
                            {
                                Console.WriteLine("Диапазон чисел для месяца от 1 до 12. Повторите попытку");
                                goto Found11;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Вы неправильно ввели число. Повторите заново");
                            goto Found11;
                        }

                    Found12:
                        try
                        {
                            Console.Write("День: ");
                            day2 = uint.Parse(Console.ReadLine());
                            if (day2 < 1 || day2 > 31)
                            {
                                Console.WriteLine("Диапазон чисел для дня от 1 до 31. Повторите попытку");
                                goto Found12;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Вы неправильно ввели число. Повторите заново");
                            goto Found12;
                        }

                        Console.WriteLine($"Полученная дата: {year2}.{month2}.{day2}");
                        Console.WriteLine($"Исходная дата: {year}.{month}.{day}");

                        Console.WriteLine(date9.Srav(year, month, day, year2, month2, day2));
                        break;

                         case 11:
                        uint year3, month3, day3;
                        Date date10 = new Date(year, month, day, 0);
                        Console.WriteLine("Введите год, месяц, день даты, с которой будет производиться вычисление");

                    Found13:
                        try
                        {
                            Console.Write("Год: ");
                            year3 = uint.Parse(Console.ReadLine());

                        }
                        catch
                        {
                            Console.WriteLine("Вы неправильно ввели число. Повторите заново");
                            goto Found13;
                        }

                    Found14:
                        try
                        {
                            Console.Write("Месяц: ");
                            month3 = uint.Parse(Console.ReadLine());
                            if (month3 < 1 || month3 > 12)
                            {
                                Console.WriteLine("Диапазон чисел для месяца от 1 до 12. Повторите попытку");
                                goto Found14;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Вы неправильно ввели число. Повторите заново");
                            goto Found14;
                        }

                    Found15:
                        try
                        {
                            Console.Write("День: ");
                            day3 = uint.Parse(Console.ReadLine());
                            if (day3 < 1 || day3 > 31)
                            {
                                Console.WriteLine("Диапазон чисел для дня от 1 до 31. Повторите попытку");
                                goto Found15;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Вы неправильно ввели число. Повторите заново");
                            goto Found15;
                        }

                        Console.WriteLine($"Полученная дата: {year3}.{month3}.{day3}");
                        Console.WriteLine($"Исходная дата: {year}.{month}.{day}");

                        Console.WriteLine(date10.Sub_Two(year, month, day, year3, month3, day3));
                        break;

                    case 12:
                        goto Found16;
                        break;

                    case 0:
                        Console.WriteLine("Введите год, месяц, день новой исходной даты");

                        goto Found17;
                        break;
                }
            }
        Found16:;
        }
    }
}
