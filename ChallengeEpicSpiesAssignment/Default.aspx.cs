using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DateTime previousEnd = previousEndDateCalendar.TodaysDate;
                DateTime startNew = previousEnd.AddDays(14);
                DateTime newEnd = previousEnd.AddDays(21);
            }

        }

        protected void assignSpyButton_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                DateTime newpreviousEnd = previousEndDateCalendar.SelectedDate;
                DateTime newStartNew = newStartDateCalendar.SelectedDate;
                DateTime newEndDate = projectedNewEndDateCalendar.SelectedDate;

               
                int shortDate = newpreviousEnd.Subtract(newStartNew).Days;

                int jobdays = newEndDate.Subtract(newStartNew).Days;
                int dayWage = 500;
                int jobBonus = 1000;
                int paycheck = jobdays * dayWage;



                if (jobdays >= 14 && jobdays <= 20)

                {
                    double result = paycheck;

                    string result2 = String.Format("Assignment of  {0} to assignment Project: {1}  for {2:C}",
                        spyCodeTextBox.Text,
                        newAssignmentNameTextBox.Text,
                        result);

                    resultLabel.Text = result2;
                }

                else if (jobdays >= 21)
                {
                    double result = (paycheck + jobBonus);

                    string result2 = String.Format("Assignment of  {0} to assignment Project: {1}  for {2:C}",
                        spyCodeTextBox.Text,
                        newAssignmentNameTextBox.Text,
                        result);

                    resultLabel.Text = result2;
                }
                else if (shortDate < 14)
                {
                    resultLabel.Text =
                        "Error: Must allow at least two weeks between previous assignment and the new assignment.";
                }
            }



        }

    }
}
