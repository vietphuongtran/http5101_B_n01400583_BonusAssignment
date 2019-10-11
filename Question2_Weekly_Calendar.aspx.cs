using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment_HTTP5101_B_n01400583
{
    public partial class Weekly_Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                
                
                
                {
                    monthly_summary.InnerHtml = "";
                    //I want to loop through the date (Oct 1 is a Tuesday, Oct 2 is Wednesday, ...Oct 31)
                    //Oct 1, Oct 2...Oct 31 can be created by running a loop from 1 - 31
                    //How can I create is a Tuesday, is a Wednesday, is a Thursday?
                    //1) loop i = i + 1 31 times can displayed as the question required but not ideal as the code is not factored.
                    //2 ) using i = i + 7 in only displayed like Oct 1 then jumped to Oct 8 (not as exactly as required)
                    //I want to display the message It's time to work and It's time to have fun according to the user choice
                    //using .SelectedValue so whatever user chooses will appear in the InnerHtml.

                    //This is not an ideal , the code is not factored, but the closest to the requirement I could think of so far.
                    /*for (int i = 1; i<2; i = i+1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Tuesday. It is time to " + user_calendar_tuesday.SelectedValue + "<br>";
                    }
                    for (int i = 2; i < 3; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Wednesday. It is time to " + user_calendar_wednesday.SelectedValue + "<br>";
                    }
                    for (int i = 3; i < 4; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Thursday. It is time to " + user_calendar_thursday.SelectedValue + "<br>";
                    }
                    for (int i = 4; i < 5; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Friday. It is time to " + user_calendar_friday.SelectedValue + "<br>";
                    }
                    for (int i = 5; i < 6; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Saturday. It is time to " + user_calendar_saturday.SelectedValue + "<br>";
                    }
                    for (int i = 6; i < 7; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Sunday. It is time to " + user_calendar_sunday.SelectedValue + "<br>";
                    }
                    for (int i = 7; i < 8; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Monday. It is time to " + user_calendar_monday.SelectedValue + "<br>";
                    }
                    for (int i = 8; i < 9; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Tuesday. It is time to " + user_calendar_tuesday.SelectedValue + "<br>";
                    }
                    for (int i = 9; i < 10; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Wednesday. It is time to " + user_calendar_wednesday.SelectedValue + "<br>";
                    }
                    for (int i = 10; i < 11; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Thursday. It is time to " + user_calendar_thursday.SelectedValue + "<br>";
                    }
                    for (int i = 11; i < 12; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Friday. It is time to " + user_calendar_friday.SelectedValue + "<br>";
                    }
                    for (int i = 12; i < 13; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Saturday. It is time to " + user_calendar_saturday.SelectedValue + "<br>";
                    }
                    for (int i = 13; i < 14; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Sunday. It is time to " + user_calendar_sunday.SelectedValue + "<br>";
                    }
                    for (int i = 14; i < 15; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Monday. It is time to " + user_calendar_monday.SelectedValue + "<br>";
                    }
                    for (int i = 15; i < 16; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Tuesday. It is time to " + user_calendar_tuesday.SelectedValue + "<br>";
                    }
                    for (int i = 16; i < 17; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Wednesday. It is time to " + user_calendar_wednesday.SelectedValue + "<br>";
                    }
                    for (int i = 17; i < 18; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Thursday. It is time to " + user_calendar_thursday.SelectedValue + "<br>";
                    }
                    for (int i = 18; i < 19; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Friday. It is time to " + user_calendar_friday.SelectedValue + "<br>";
                    }
                    for (int i = 19; i < 20; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Saturday. It is time to " + user_calendar_saturday.SelectedValue + "<br>";
                    }
                    for (int i = 20; i < 21; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Sunday. It is time to " + user_calendar_sunday.SelectedValue + "<br>";
                    }
                    for (int i = 21; i < 22; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Monday. It is time to " + user_calendar_monday.SelectedValue + "<br>";
                    }
                    for (int i = 22; i < 23; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Tuesday. It is time to " + user_calendar_tuesday.SelectedValue + "<br>";
                    }
                    for (int i = 23; i < 24; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Wednesday. It is time to " + user_calendar_wednesday.SelectedValue + "<br>";
                    }
                    for (int i = 24; i < 25; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Thursday. It is time to " + user_calendar_thursday.SelectedValue + "<br>";
                    }
                    for (int i = 25; i < 26; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Friday. It is time to " + user_calendar_friday.SelectedValue + "<br>";
                    }
                    for (int i = 26; i < 27; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Saturday. It is time to " + user_calendar_saturday.SelectedValue + "<br>";
                    }
                    for (int i = 27; i < 28; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Sunday. It is time to " + user_calendar_sunday.SelectedValue + "<br>";
                    }
                    for (int i = 28; i < 29; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Monday. It is time to " + user_calendar_monday.SelectedValue + "<br>";
                    }
                    for (int i = 29; i < 30; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Tuesday. It is time to " + user_calendar_tuesday.SelectedValue + "<br>";
                    }
                    for (int i = 30; i < 31; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Wednesday. It is time to " + user_calendar_wednesday.SelectedValue + "<br>";
                    }
                    for (int i = 31; i < 32; i = i + 1)
                    {
                        monthly_summary.InnerHtml += "Oct " + i + " is a Thursday. It is time to " + user_calendar_thursday.SelectedValue + "<br>";
                    }

                    //This method only displayed Oct 1 then jumped to Oct 8
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

                    //This can give me "...is a Tuesday. It's time to work/ have fun
                    //But the month loop from 1 - 31 while the date stand still. i.e Oct 1 is a Tuesday, Oct 2 is a Tuesday...Oct 31...

                    int count = 1;
                    foreach (ListItem user_working_day in user_working_days.Items)                    
                    {
                        if (user_working_day.Selected == true)
                            for (int i = 1; i <= 31; i = i++)
                            {
                                monthly_summary.InnerHtml += "Oct " + i + " is a " + user_working_day.Value + ". It's time to work <br>";
                            }
                        else
                            for (int i = 1; i <= 31; i = i++)
                            {
                                monthly_summary.InnerHtml += "Oct " + i + "is a " + user_working_day.Value + ". It's time to havefun <br>";
                            }
                    }      
                }
            }
        }
    }
}
