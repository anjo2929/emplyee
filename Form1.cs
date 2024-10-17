using System.Windows.Forms;
using System;

namespace employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        public class PartTimeEmployee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
            public string JobTitle { get; set; }
            public double BasicSalary { get; private set; }

            public void ComputeSalary(int hoursWorked, double ratePerHour)
            {
                BasicSalary = hoursWorked * ratePerHour;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Firstnametext.Text) ||
                       string.IsNullOrWhiteSpace(Lastnametext.Text) ||
                       string.IsNullOrWhiteSpace(departmenttextBox2.Text) ||
                       string.IsNullOrWhiteSpace(textjobtitle.Text) ||
                       string.IsNullOrWhiteSpace(ratePerHourTextBox.Text) ||
                       string.IsNullOrWhiteSpace(hoursWorkedTextBox.Text))
            {
                MessageBox.Show("Please fill in all ");
                return;
            }


            if (double.TryParse(ratePerHourTextBox.Text, out double ratePerHour) &&
            int.TryParse(hoursWorkedTextBox.Text, out int hoursWorked))
            {
                PartTimeEmployee employee = new PartTimeEmployee
                {
                    FirstName = Firstnametext.Text,
                    LastName = Lastnametext.Text,
                    Department = departmenttextBox2.Text,
                    JobTitle = textjobtitle.Text
                };


                employee.ComputeSalary(hoursWorked, ratePerHour);

                label8.Text = employee.FirstName; 
                label7.Text = employee.LastName; 
                salaryLabel.Text = employee.BasicSalary.ToString("");
            }
            else
            {
                MessageBox.Show("Please enter valid number for rate per hour and hours worked");
            }
        }
    }
}