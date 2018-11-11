using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Year
    {
        public int CurrentYear;
        public List<Month> CountMounths { get; set; } = new List<Month>();
        public Year(int currentYear)
        {
            this.CurrentYear = currentYear;
            for (int i = 1; i < 13; i++)
            {
                CountMounths.Add(new Month((MonthOfTheYear)i));
            }
        }
        public void CreateDate()
        {

        }
        public static string PrintDay(int day, int month, Year year)
        {
            return year.CountMounths[month - 1].CountDays[day - 1].Name.ToString();
        }
        public static int CountDaysInDates(List<Year> years, int day1, int month1, int year1, int day2, int month2, int year2)
        {
            int k = 0;
            int m = 0;
            for(int i = 0; i < years.Count; i++)
            {
                if (years[i].CurrentYear == year1)
                {
                    k = i;
                }
                if (years[i].CurrentYear == year2)
                {
                    m = i;
                }
            }
            int sum = 0;
            int d = years[m].CurrentYear- years[k].CurrentYear;
            for (int i = 0; i< d; i++)
            {
                for(int j = 0; j < years[i].CountMounths.Count; j++)
                {
                    sum += years[k+i].CountMounths[j].CountDays.Count;
                }
            }
                for(int i = 0; i < month1; i++)
                {
                    sum-=years[k].CountMounths[i].CountDays.Count;
                }
                for (int j = 0; j < month2; j++)
                {
                    sum += years[k].CountMounths[j].CountDays.Count;
                }
                for (int i = 0; i < day1; i++)
                {
                    sum -= 1;
                }
                for (int i = 0; i < day2; i++)
                {
                    sum += 1;
                }
            return sum;
        }
        public static int CountMonthsInDates(List<Year> years, int day1, int month1, int year1, int day2, int month2, int year2)
        {
            int k = 0;
            int m = 0;
            for(int i = 0; i < years.Count; i++)
            {
                if (years[i].CurrentYear == year1)
                {
                    k = i;
                }
                if (years[i].CurrentYear == year2)
                {
                    m = i;
                }
            }
            int sum = 0;
            int d = years[m].CurrentYear- years[k].CurrentYear;
            for (int i = 0; i < d; i++)
            {
                sum += years[k + i].CountMounths.Count;
            }
            for (int i = 0; i < month1; i++)
            {
                sum -= 1;
            }
            for (int j = 0; j < month2; j++)
            {
                sum += 1;
            }
            return sum;
        }
    }
}
