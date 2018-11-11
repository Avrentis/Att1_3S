using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Task1Console
{
    class Program
    {
        private static void Write(string s)
        {
            Console.WriteLine();
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            List<Year> years = new List<Year>();
            while (true)
            {
                try
                {
                    Write("Что вы хотите сделать(1-установить дату, 2-вывести день по дате, 3-рассчитать кол-во дней, 4-рассчитать кол-во месяцев)");
                    int x = Convert.ToInt32(Console.ReadLine());
                    int day = 1, month = 1, year1 = 1;
                    Year year = null;
                    switch (x)
                    {
                        case 1:
                            Write("Введите день");
                            day = Convert.ToInt32(Console.ReadLine());
                            Write("Введите месяц");
                            month = Convert.ToInt32(Console.ReadLine());
                            Write("Введите год");
                            if (day >= 31 || month >= 12)
                            {
                                Write("Данные введены неверно");
                                break;
                            }
                            year1 = Convert.ToInt32(Console.ReadLine());
                            year = new Year(Convert.ToInt32(year1));
                            year.CreateDate();
                            years.Add(year);
                            break;
                        case 2:
                            if (years.Count == 0)
                            {
                                Write("Сначала установите дату");
                                break;
                            }
                            Write(Year.PrintDay(day, month, years[years.Count - 1]));
                            break;
                        case 3:
                            Write("Введите день даты1");
                            int day1 = Convert.ToInt32(Console.ReadLine());
                            Write("Введите месяц даты1");
                            int month1 = Convert.ToInt32(Console.ReadLine());
                            Write("Введите год даты1");
                            if (day >= 31 || month >= 12)
                            {
                                Write("Данные введены неверно");
                                break;
                            }
                            int year2 = Convert.ToInt32(Console.ReadLine());
                            year = new Year(Convert.ToInt32(year2));
                            year.CreateDate();
                            years.Add(year);
                            Write("Введите день даты2");
                            int day2 = Convert.ToInt32(Console.ReadLine());
                            Write("Введите месяц даты2");
                            int month2 = Convert.ToInt32(Console.ReadLine());
                            Write("Введите год даты2");
                            if (day >= 31 || month >= 12)
                            {
                                Write("Данные введены неверно");
                                break;
                            }
                            int year3 = Convert.ToInt32(Console.ReadLine());
                            int d = year3 - year2;
                            for (int i = 1; i < d; i++)
                            {
                                years.Add(new Year(year2 + i));
                            }
                            year = new Year(Convert.ToInt32(year3));
                            year.CreateDate();
                            years.Add(year);
                            Write(Convert.ToString(Math.Abs(Year.CountDaysInDates(years, Convert.ToInt32(day1), Convert.ToInt32(month1), Convert.ToInt32(year2), Convert.ToInt32(day2), Convert.ToInt32(month2), Convert.ToInt32(year3)))));
                            years.Clear();
                            break;
                        case 4:
                            Write("Введите день даты1");
                            int day4 = Convert.ToInt32(Console.ReadLine());
                            Write("Введите месяц даты1");
                            int month4 = Convert.ToInt32(Console.ReadLine());
                            Write("Введите год даты1");
                            if (day >= 31 || month >= 12)
                            {
                                Write("Данные введены неверно");
                                break;
                            }
                            int year4 = Convert.ToInt32(Console.ReadLine());
                            year = new Year(Convert.ToInt32(year4));
                            year.CreateDate();
                            years.Add(year);
                            Write("Введите день даты2");
                            int day5 = Convert.ToInt32(Console.ReadLine());
                            Write("Введите месяц даты2");
                            int month5 = Convert.ToInt32(Console.ReadLine());
                            Write("Введите год даты2");
                            if (day >= 31 || month >= 12)
                            {
                                Write("Данные введены неверно");
                                break;
                            }
                            int year5 = Convert.ToInt32(Console.ReadLine());
                            d = year5 - year4;
                            for (int i = 1; i < d; i++)
                            {
                                years.Add(new Year(year4 + i));
                            }
                            year = new Year(Convert.ToInt32(year5));
                            year.CreateDate();
                            years.Add(year);
                            Write(Convert.ToString(Math.Abs(Year.CountMonthsInDates(years, Convert.ToInt32(day4), Convert.ToInt32(month4), Convert.ToInt32(year4), Convert.ToInt32(day5), Convert.ToInt32(month5), Convert.ToInt32(year5)))));
                            years.Clear();
                            break;
                    }
                }
                catch (Exception)
                {
                    Write("Ошибка при введении данных, попробуйте снова");
                }
            }
        }
    }
}
