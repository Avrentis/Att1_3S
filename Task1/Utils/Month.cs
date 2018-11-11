using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Month
    {
        public MonthOfTheYear Name { get; set; }
        public List<Day> CountDays { get; set; } = new List<Day>();
        public static int CountDecembers { get; set; } = 0;
        public static int StartDay { get; set; }
        public Month(MonthOfTheYear name)
        {
            this.Name = name;
            if ((int)Name <= 7)
            {
                if ((int)Name == 1 && CountDecembers == 0)
                {
                    StartDay = RandomDay();
                    GenerateDays(31);
                }
                else if ((int)Name == 1 && CountDecembers > 0)
                    GenerateDays(31);
                if ((int)Name == 2)
                {
                    GenerateDays(28);
                }
                if ((int)Name != 1 && (int)Name % 2 != 0)
                {
                    GenerateDays(31);
                }
                if ((int)Name % 2 == 0 && (int)Name != 2)
                {
                    GenerateDays(30);
                }
            }
            else
            {
                if ((int)Name % 2 != 0)
                {
                    GenerateDays(30);
                }
                else if ((int)Name % 2 == 0 && (int)Name != 12)
                {
                    GenerateDays(31);
                }
                else if((int)Name == 12)
                {
                    GenerateDays(31);
                    CountDecembers++;
                }
            }
        }
        Random rnd = new Random();
        private int RandomDay()
        {
            return rnd.Next(1, 8);
        }
        private void GenerateDays(int k)
        {
            Day startDay = new Day((DayOfTheWeek)StartDay, CountDays.Count + 1);
            while (StartDay < 8)
            {
                CountDays.Add(new Day((DayOfTheWeek)StartDay, CountDays.Count + 1));
                StartDay++;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 8; j++)
                {
                    CountDays.Add(new Day((DayOfTheWeek)j, CountDays.Count + 1));
                }
            }
            for (int i = 1; k > CountDays.Count; i++)
            {
                if (i > 7)
                {
                    CountDays.Add(new Day((DayOfTheWeek)(i - 7), CountDays.Count + 1));
                }
                else
                    CountDays.Add(new Day((DayOfTheWeek)i, CountDays.Count + 1));
            }
            if((int)CountDays[CountDays.Count - 1].Name == 7)
            {
                StartDay = 1;
            }
            else
                StartDay = (int)CountDays[CountDays.Count - 1].Name+1;
        }
    }
}
