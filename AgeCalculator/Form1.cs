using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DOB = dateTimePicker1.Value;
            DateTime currentDate = dateTimePicker2.Value;

            int years = currentDate.Year - DOB.Year;
            int months = currentDate.Month - DOB.Month;
            int days = currentDate.Day - DOB.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            label4.Text = $"You are {years} years, {months} months, and {days} days old.";

        }
    }
}
