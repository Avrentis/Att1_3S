using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadDays_box.ReadOnly = true;
            ReadMonths_box.ReadOnly = true;
            dayOfTheWeek_box.ReadOnly = true;
        }
        List<Year> years = new List<Year>();
        private void SelectDate_btn_Click(object sender, EventArgs e)
        {
            err_lbl.Text = "";
            try
            {
                Year year = new Year(Convert.ToInt32(chooseYear1.Text));
                year.CreateDate();
                years.Add(year);
            }
            catch (Exception)
            {
                err_lbl.Text = "Данные введены неверно";
            }
        }

        private void PrintDay_btn_Click(object sender, EventArgs e)
        {
            err_lbl.Text = "";
            try
            {
                Year year = null;
                bool check = false;
                if (years.Count != 0)
                {
                    for (int i = 0; i < years.Count; i++)
                    {
                        if (years[i].CurrentYear == Convert.ToInt32(chooseYear1.Text))
                        {
                            year = years[i];
                            check = true;
                        }
                    }
                    if (!check)
                    {
                        for (int j = 0; j < Convert.ToInt32(chooseYear1.Text) - years[years.Count - 1].CurrentYear;)
                        {
                            year = new Year(years[years.Count - 1].CurrentYear + 1);
                            years.Add(year);
                        }
                    }
                }
                if (years.Count == 0)
                {
                    year = new Year(Convert.ToInt32(chooseYear1.Text));
                    years.Add(year);
                }
                int day = Convert.ToInt32(ChooseDay1.Text);
                int month = Convert.ToInt32(chooseMonth1.Text);
                dayOfTheWeek_box.Text = Year.PrintDay(day, month, year);
            }
            catch (Exception)
            {
                err_lbl.Text = "Данные введены неверно";
            }

        }

        private void CalculateDays_btn_Click(object sender, EventArgs e)
        {
            err_lbl.Text = "";
            try
            {
                CheckAddList();
                ReadDays_box.Text = Convert.ToString(Math.Abs(Year.CountDaysInDates(years, Convert.ToInt32(ChooseDay1.Text), Convert.ToInt32(chooseMonth1.Text), Convert.ToInt32(chooseYear1.Text), Convert.ToInt32(chooseDay2.Text), Convert.ToInt32(chooseMonth2.Text), Convert.ToInt32(chooseYear2.Text))));
            }
            catch (Exception)
            {
                err_lbl.Text = "Данные введены неверно";
            }
        }

        private void CalculateMonths_btn_Click(object sender, EventArgs e)
        {
            err_lbl.Text = "";
            try
            {
                CheckAddList();
                ReadMonths_box.Text = Convert.ToString(Math.Abs(Year.CountMonthsInDates(years, Convert.ToInt32(ChooseDay1.Text), Convert.ToInt32(chooseMonth1.Text), Convert.ToInt32(chooseYear1.Text), Convert.ToInt32(chooseDay2.Text), Convert.ToInt32(chooseMonth2.Text), Convert.ToInt32(chooseYear2.Text))));
            }
            catch (Exception)
            {
                err_lbl.Text = "Данные введены неверно";
            }
        }
        private void CheckAddList()
        {
            Year year = null;
            bool check1 = false;
            bool check2 = false;
            if (years.Count != 0)
            {
                for (int i = 0; i < years.Count; i++)
                {
                    if (years[i].CurrentYear == Convert.ToInt32(chooseYear1.Text))
                    {
                        year = years[i];
                        check1 = true;
                    }
                }
                if (!check1)
                {
                    for (int j = 0; j < Convert.ToInt32(chooseYear1.Text) - years[years.Count - 1].CurrentYear;)
                    {
                        year = new Year(years[years.Count - 1].CurrentYear + 1);
                        years.Add(year);
                    }
                }
            }
            if (years.Count == 0)
            {
                year = new Year(Convert.ToInt32(chooseYear1.Text));
                years.Add(year);
            }
            if (years.Count != 0)
            {
                for (int i = 0; i < years.Count; i++)
                {
                    if (years[i].CurrentYear == Convert.ToInt32(chooseYear2.Text))
                    {
                        year = years[i];
                        check2 = true;
                    }
                }
                if (!check2)
                {
                    for (int j = 0; j < Convert.ToInt32(chooseYear2.Text) - years[years.Count - 1].CurrentYear;)
                    {
                        year = new Year(years[years.Count - 1].CurrentYear + 1);
                        years.Add(year);
                    }
                }
            }
        }
    }
}
