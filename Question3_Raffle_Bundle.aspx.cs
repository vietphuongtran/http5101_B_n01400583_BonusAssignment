using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment_HTTP5101_B_n01400583
{
    public partial class RaffleBundle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    bundle_summary.InnerHtml = "";
                    int Student_Booking_Amount = Convert.ToInt32(student_booking_amount.Text);
                    string Bundle_1_Msg = "You have received a bundle of 1!";
                    string Bundle_2_Msg = "You have received a bundle of 2!";
                    string Bundle_Leftover_Msg = "Your leftover is ";
                    string Bundle_Final_Summary = "That's " + Student_Booking_Amount + " ticket(s)";
                    string Bundle_3_Msg = "You have received a bundle of 3!";
                    string Bundle_5_Msg = "You have received a bundle of 5!";
                    string Total_Ticket = "Your total ticket(s) is ";

                    string Total_Cost = "and your cost is " + 0.25 * Student_Booking_Amount +"CAD";

                    //for less than 50 ticket print out 3 message: Bundle_1_Msg, that is .. ticket and the total price;
                    //That is 1 ticket. That is 2 tickets... is done by running a loop starting from 1 to 50

                    if (Student_Booking_Amount <= 50)
                    {                     
                        for (int i = 1; i <= Student_Booking_Amount; i++)
                        {
                            bundle_summary.InnerHtml += Bundle_1_Msg;
                            bundle_summary.InnerHtml += "That is " + i + " " + "ticket(s)!" + "<br>";
                        }
                        bundle_summary.InnerHtml += Total_Ticket + " " + Student_Booking_Amount + " " + Total_Cost;
                    }
                    //from 51 - 150 ticket print out 4 messagse: Bundle_2_Msg, that is 2, 4, 6 ticket, the Leftover and the total price;
                    //That is 2, 4, 6 .... tickets is done by running a loop with i = i + 2
                    //The left over msg has 2 scenarios: 1 left over and 0 leftover

                    if (Student_Booking_Amount > 50 && Student_Booking_Amount <= 150)
                    {
                        for (int i = 2; i <= Student_Booking_Amount; i = i + 2)
                        {
                            bundle_summary.InnerHtml += Bundle_2_Msg;
                            bundle_summary.InnerHtml += "That is " + i + " " + "tickets!" + "<br>";
                        }
                        //Scenario 1
                        if (Student_Booking_Amount % 2 == 1)
                        {
                            bundle_summary.InnerHtml += Bundle_Leftover_Msg + "1 ticket. " + Bundle_Final_Summary + "<br>";
                            bundle_summary.InnerHtml += Total_Ticket + " " + Student_Booking_Amount + " " + Total_Cost;
                        }
                        //Scenario 2
                        else
                        {
                            bundle_summary.InnerHtml += Total_Ticket + " " + Student_Booking_Amount + " " + Total_Cost;
                        }
                       
                    }
                    //from 150 - 300 tickets print out 4 messages: Bundle_3_Msg, that is 3, 6, 9 tickets, the Leftover and the total price;
                    //That is 3, 6, 9 .... tickets is done by running a loop with i = i + 3
                    //The leftover ticket of bundle of 3 has 3 scenarios: 1 leftover, 2 leftover and 0 leftover
                    if (Student_Booking_Amount > 150 && Student_Booking_Amount <= 300)
                    {
                        for (int i = 3; i <= Student_Booking_Amount; i = i + 3)
                        {
                            bundle_summary.InnerHtml += Bundle_3_Msg;
                            bundle_summary.InnerHtml += "That is " + i + " " + "tickets!" + "<br>";
                        }
                        //Scenario 1
                        if (Student_Booking_Amount % 3 == 1)
                        {
                            bundle_summary.InnerHtml += Bundle_Leftover_Msg + "1 ticket. "+ Bundle_Final_Summary + "<br>";
                            bundle_summary.InnerHtml += Total_Ticket + " " + Student_Booking_Amount + " " + Total_Cost;
                        }
                        //Scenario 2
                        else if (Student_Booking_Amount % 3 == 2)
                        {
                            bundle_summary.InnerHtml += Bundle_Leftover_Msg + "2 tickets. " + Bundle_Final_Summary + "<br>";
                            bundle_summary.InnerHtml += Total_Ticket + " " + Student_Booking_Amount + " " + Total_Cost;
                        }
                        //Scenario 3
                        else
                        {
                            bundle_summary.InnerHtml += Total_Ticket + " " + Student_Booking_Amount + " " + Total_Cost;
                        }
                            
                    }
                    //from 301 tickets print out 4 messages: Bundle_3_Msg, that is 5, 10, 15 tickets, the Leftover and the total price;
                    //That is 5, 10, 15 .... tickets is done by running a loop with i = i + 5
                    //The leftover ticket of bundle of 5 has 5 scenarios: 1 leftover, 2 leftovers, 3 leftovers, 4 leftovers and 0 leftover
                    if (Student_Booking_Amount >=301)
                    {
                        for (int i=5; i <= Student_Booking_Amount; i = i + 5)
                        {
                            bundle_summary.InnerHtml += Bundle_5_Msg;
                            bundle_summary.InnerHtml += "That is " + i + " " + "tickets!" + "<br>";
                        }
                        //Scenario 1
                        if (Student_Booking_Amount % 5 == 1)
                        {
                            bundle_summary.InnerHtml += Bundle_Leftover_Msg + "1 ticket. " + Bundle_Final_Summary + "<br>";
                            bundle_summary.InnerHtml += Total_Ticket + " " + Student_Booking_Amount + " " + Total_Cost;
                        }
                        //Scenario 2
                        else if (Student_Booking_Amount % 5 == 2)
                        {
                            bundle_summary.InnerHtml += Bundle_Leftover_Msg + "2 tickets. " + Bundle_Final_Summary + "<br>";
                            bundle_summary.InnerHtml += Total_Ticket + " " + Student_Booking_Amount + " " + Total_Cost;
                        }
                        //Scenario 3
                        else if (Student_Booking_Amount % 5 == 3)
                        {
                            bundle_summary.InnerHtml += Bundle_Leftover_Msg + "3 tickets. " + Bundle_Final_Summary + "<br>";
                            bundle_summary.InnerHtml += Total_Ticket + " " + Student_Booking_Amount + " " + Total_Cost;
                        }
                        //Scenario 4
                        else if (Student_Booking_Amount % 5 == 4)
                        {
                            bundle_summary.InnerHtml += Bundle_Leftover_Msg + "4 tickets. " + Bundle_Final_Summary + "<br>";
                            bundle_summary.InnerHtml += Total_Ticket + " " + Student_Booking_Amount + " " + Total_Cost;
                        }
                        //Scenario 5
                        else
                        {
                            bundle_summary.InnerHtml += Total_Ticket + " " + Student_Booking_Amount + " " + Total_Cost;
                        }
                    }
                }
            }
        }
    }
}