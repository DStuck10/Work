using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work
{
    public partial class WorkForm : Form
    {
        public WorkForm()
        {
            InitializeComponent();
        }

        double daysofWork = 0;
        double daysofWorkTwo = 0;
        
        private void checkBoxSundayOne_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSundayOne.Checked)
            {
                daysofWork += 1;
            }
            else
            {
                daysofWork -= 1;
            }
        }

        private void checkBoxMondayOne_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMondayOne.Checked)
            {
                daysofWork += 1;
            }
            else
            {
                daysofWork -= 1;
            }
        }

        private void checkBoxTuesdayOne_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTuesdayOne.Checked)
            {
                daysofWork += 1;
            }
            else
            {
                daysofWork -= 1;
            }
        }

        private void checkBoxWednesdayOne_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWednesdayOne.Checked)
            {
                daysofWork += 1;
            }
            else
            {
                daysofWork -= 1;
            }
        }

        private void checkBoxThursdayOne_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxThursdayOne.Checked)
            {
                daysofWork += 1;
            }
            else
            {
                daysofWork -= 1;
            }
        }

        private void checkBoxFridayOne_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFridayOne.Checked)
            {
                daysofWork += 1;
            }
            else
            {
                daysofWork -= 1;
            }
        }

        private void checkBoxSaturdayOne_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSaturdayOne.Checked)
            {
                daysofWork += 1;
            }
            else
            {
                daysofWork -= 1;
            }
        }    

        private void checkBoxSundayTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSundayTwo.Checked)
            {
                daysofWorkTwo += 1;
            }
            else
            {
                daysofWorkTwo -= 1;
            }
        }

        private void checkBoxMondayTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMondayTwo.Checked)
            {
                daysofWorkTwo += 1;
            }
            else
            {
                daysofWorkTwo -= 1;
            }
        }

        private void checkBoxTuesdayTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTuesdayTwo.Checked)
            {
                daysofWorkTwo += 1;
            }
            else
            {
                daysofWorkTwo -= 1;
            }
        }

        private void checkBoxWednesdayTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWednesdayTwo.Checked)
            {
                daysofWorkTwo += 1;
            }
            else
            {
                daysofWorkTwo -= 1;
            }
        }

        private void checkBoxThursdayTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxThursdayTwo.Checked)
            {
                daysofWorkTwo += 1;
            }
            else
            {
                daysofWorkTwo -= 1;
            }
        }

        private void checkBoxFridayTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFridayTwo.Checked)
            {
                daysofWorkTwo += 1;
            }
            else
            {
                daysofWorkTwo -= 1;
            }
        }

        private void checkBoxSaturdayTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSaturdayTwo.Checked)
            {
                daysofWorkTwo += 1;
            }
            else
            {
                daysofWorkTwo -= 1;
            }
        }

        private void WorkForm_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblErrorTwo.Text = "";
            lblHours.Text = "";
            lblHoursTwo.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Checking to see if any user input is entered
            if (comboBoxStartTime.Text == "" && daysofWork == 0)
            {
                lblError.Text = "Enter Time and days of work";
            }
            else
            {
                // Checking to see if time is entered
                if (comboBoxStartTime.Text == "" && daysofWork != 0)
                {
                    lblError.Text = "Please enter time of work";
                }
                else
                {
                    if (daysofWork == 0)
                    {
                        // Checking to see if time is entered and days are not entered
                        if (comboBoxStartTime.Text != "")
                        {
                            lblError.Text = "Please select days of work";
                            lblHours.Text = "";
                        }
                    }
                    else
                    {
                        // If no errors this will calculate the time of work
                        lblError.Text = "";
                        double startHours = 0, endHours = 0, hours = 0, hoursTimesDays = 0;
                        int startIndex = comboBoxStartTime.Text.IndexOf(":");
                        int endIndex = comboBoxEndTime.Text.IndexOf(":");
                        // Getting the value of the starting hour in combo box 1
                        startHours = Convert.ToDouble(comboBoxStartTime.Text.Substring(0, startIndex));
                        // Getting the value of the ending hour in combo box 1
                        endHours = Convert.ToDouble(comboBoxEndTime.Text.Substring(0, endIndex));
                        hours = (endHours - startHours);
                        hoursTimesDays = hours * daysofWork;
                        lblHours.Text = Convert.ToString(hoursTimesDays) + " Hours";
                    }
                }
            }

            ////////
            ////////
            //////// Second set of input

            // Check to see if any input is entered
            if (comboBoxStartTimeTwo.Text == "" && daysofWorkTwo == 0)
            {
                lblErrorTwo.Text = "Enter time and days of work";
            }
            else
            {
                // Check to see if time is entered
                if (comboBoxStartTimeTwo.Text == "" && daysofWorkTwo != 0)
                {
                    lblErrorTwo.Text = "Please enter time of work";
                }
                else
                {
                    // Check to see if time is enter and date is not entered
                    if (daysofWorkTwo == 0)
                    {
                        if (comboBoxStartTimeTwo.Text != "")
                        {
                            lblErrorTwo.Text = "Please select days of work";
                            lblHoursTwo.Text = "";
                        }
                    }
                    else
                    {
                        // If no errors then this will calculate the time of work
                        lblErrorTwo.Text = "";
                        double startHoursTwo = 0, endHoursTwo = 0, hoursTwo = 0, hoursTimesDaysTwo = 0;
                        int startIndexTwo = comboBoxStartTimeTwo.Text.IndexOf(":");
                        int endIndexTwo = comboBoxEndTimeTwo.Text.IndexOf(":");
                        // Getting the value of the starting hour in combo box 2
                        startHoursTwo = Convert.ToDouble(comboBoxStartTimeTwo.Text.Substring(0, startIndexTwo));
                        // Getting gthe value of the ending hour in combo box 2
                        endHoursTwo = Convert.ToDouble(comboBoxEndTimeTwo.Text.Substring(0, endIndexTwo));
                        hoursTwo = (endHoursTwo - startHoursTwo);
                        hoursTimesDaysTwo = hoursTwo * daysofWorkTwo;
                        lblHoursTwo.Text = Convert.ToString(hoursTimesDaysTwo) + " Hours";
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
