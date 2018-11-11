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

namespace Task2WInForm
{
    public partial class MobileOperatorForm : Form
    {
        public MobileOperatorForm()
        {
            InitializeComponent();
            Check_btn.Enabled = false;
            resBox.ReadOnly = true;
            radio_class1.Checked = true;
            yearMade_box.Enabled = false;
            Clear_btn.Enabled = false;
        }
        List<Car> car = new List<Car>();
        private void Check_btn_Click(object sender, EventArgs e)
        {
            if (radio_class1.Checked == true)
            {
                resBox.Text = Convert.ToString(car[car.Count-1].GetQ());
                dataGridView.Rows.Add(name_box.Text, enginePower_box.Text, seatsCount_box.Text, "отсутствует", resBox.Text);
            }
            else if (radio_class2.Checked == true)
            {
                resBox.Text = Convert.ToString(car[car.Count-1].GetQ());
                dataGridView.Rows.Add(name_box.Text, enginePower_box.Text, seatsCount_box.Text, yearMade_box.Text, resBox.Text);
            }
            Check_btn.Enabled = false;
            Clear_btn.Enabled = true;
        }
        private void Choose_btn_Click(object sender, EventArgs e)
        {
            if (radio_class1.Checked == true && name_box.Text != "" && enginePower_box.Text != "" && seatsCount_box.Text != "")
            {
                Check_btn.Enabled = true;
                Car car1 = new Car(name_box.Text, Convert.ToInt32(enginePower_box.Text), Convert.ToInt32(seatsCount_box.Text));
                car.Add(car1);
            }
            else if (radio_class2.Checked == true && yearMade_box.Text!="" && name_box.Text != "" && enginePower_box.Text != "" && seatsCount_box.Text != "")
            {
                Check_btn.Enabled = true;
                PersonalCar personalCar = new PersonalCar(name_box.Text, Convert.ToInt32(enginePower_box.Text), Convert.ToInt32(seatsCount_box.Text), Convert.ToInt32(yearMade_box.Text));
                car.Add(personalCar);
            }
            else
            {
                label2.Text = "Вы указали не все данные";
            }
        }

        private void Radio_class_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_class1.Checked == true)
            {
                yearMade_box.Enabled = false;
            }
            else
            {
                yearMade_box.Enabled = true;
            }
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 8) && (e.KeyChar != 46) && (e.KeyChar <= 47 || e.KeyChar >= 58))
            {
                e.Handled = true;
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            Clear_btn.Enabled = false;
            
        }

        private void MobileOperatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
