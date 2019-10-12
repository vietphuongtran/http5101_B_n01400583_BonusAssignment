using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment_HTTP5101_B_n01400583
{
    public partial class Weekly_Calendar_Testing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    monthly_summary.InnerHtml = " ";

                    //I) I want to loop through the date (Oct 1 is a Tuesday, Oct 2 is Wednesday, ...Oct 31)
                    //Oct 1, Oct 2...Oct 31 can be created by running a loop from 1 - 31

                    //II) How can I create Oct 1 is a Tuesday, Oct 2 is a Wednesday, Oct 3 is a Thursday?
                    //1) using i = i + 7 in the lopp can help me assign the date to the day of week but the display is like Oct 1 is a Tuesday then jumped to Oct 8 is a Tuesday (not as exactly as required)
                    //2) I noticed that the date of Monday (7,14,21,28) is always divisible by 7, the date of Tuesday (1, 8, 15, 22, 29) divided by 7 will always have the remainder of 1
                    //Similarly for Wednesday (remainder:2), Thursday (remainder:3), Friday(4). Saturday(5), Sunday(6)
                    //Therefore, I can use that with the for loop to assign Oct 1 is a Tuesday, Oct 2 is a Wednesday

                    //II) I want to display the message It's time to work and It's time to have fun according to the user choice
                    //using .SelectedValue so whatever user chooses in the dropdownlist of the form will appear in the InnerHtml.

                    for (int i = 1; i <= 31; i++) //This will give me a date using a loop from 1 to 31 (i.e. Oct 1 - Oct 31)
                        //While that loop is running I can assign the date to the corresponding day of the week using the pattern I discovered above.
                    {
                        //Monday is 7, 14, 21, 28 so if the date (i) is divisible by 7 it must be a Monday
                        if (i % 7 == 0) 
                        {
                            monthly_summary.InnerHtml += "Oct " + i + " is a Monday. It is time to " + user_calendar_monday.SelectedValue + "<br>";
                        }
                        //Tuesday is 8, 15, 22, 29 so if a date divided by 7 having the remainder of 1 it must be Tuesday
                        if (i % 7 == 1) 
                        {
                            monthly_summary.InnerHtml += "Oct " + i + " is a Tuesday. It is time to " + user_calendar_tuesday.SelectedValue + "<br>";
                        }
                        //Similarly Wednesday must be a date having the remainder of 2 when divided by 7
                        if (i % 7 == 2) 
                        {
                            monthly_summary.InnerHtml += "Oct " + i + " is a Wednesday. It is time to " + user_calendar_wednesday.SelectedValue + "<br>";
                        }
                        //Thursday will have the remainder of 3 when divided by 7
                        if (i % 7 == 3)
                        {
                            monthly_summary.InnerHtml += "Oct " + i + " is a Thursday. It is time to " + user_calendar_thursday.SelectedValue + "<br>";
                        }
                        //Friday will have the remainder of 4 when divided by 7
                        if (i % 7 == 4)                        
                        {
                            monthly_summary.InnerHtml += "Oct " + i + " is a Friday. It is time to " + user_calendar_friday.SelectedValue + "<br>";
                        }
                        //Saturday will have the remainder of 5 when divided by 7
                        if (i % 7 == 5)
                        {
                            monthly_summary.InnerHtml += "Oct " + i + " is a Saturday. It is time to " + user_calendar_saturday.SelectedValue + "<br>";
                        }
                        //Sunday will have the remainder of 6
                        if (i % 7 == 6)
                        {
                            monthly_summary.InnerHtml += "Oct " + i + " is a Sunday. It is time to " + user_calendar_sunday.SelectedValue + "<br>";
                        }


                        //This method only displayed Oct 1 then jumped to Oct 8 so I would not recommend to do it
                        /*for (int i = 1; i <= 31; i = i + 7)
                        {
                            monthly_summary.InnerHtml += "Oct " + i + " is a Tuesday. It is time to " + user_calendar_tuesday.SelectedValue + "<br>";
                        }
                        for (int i = 2; i <= 31; i = i + 7)
                        {
                            monthly_summary.InnerHtml += "Oct " + i + " is a Wednesday. Wednesday is time to "+ user_calendar_wednesday.SelectedValue + "<br>";
                        }

                        for (int i = 3; i <= 31; i = i + 7)
                        {
                            monthly_summary.InnerHtml += "Oct " + i + " is a Thursday. Thursday is time to "+ user_calendar_thursday.SelectedValue + "<br>";
                        }

                        for (int i = 4; i <= 31; i = i +7)
                        {
                            monthly_summary.InnerHtml += "Oct " + i + " is a Friday. Friday is time to " + user_calendar_friday.SelectedValue + "<br>";
                        }

                        for (int i = 5; i <= 31; i = i + 7)
                        {
                            monthly_summary.InnerHtml += "Oct " + i + " is a Saturday. Saturday is time to " + user_calendar_friday.SelectedValue + "<br>";
                        }

                        for (int i = 6; i <= 31; i = i + 7)
                        {
                            monthly_summary.InnerHtml += "Oct " + i + " is a Sunday. Sunday is time to " + user_calendar_friday.SelectedValue + "<br>";
                        }

                        for (int i = 7; i <= 31; i = i + 7)
                        {
                            monthly_summary.InnerHtml += "Oct " + i + " is a Monday. Monday is time to " + user_calendar_monday.SelectedValue + "<br>";
                        }*/
                    }
                }
            }
        }
    }
}