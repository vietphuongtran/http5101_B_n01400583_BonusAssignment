using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment_HTTP5101_B_n01400583
{
    public partial class Coordinate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    coordinatesummary.InnerHtml = "";
                    int Horizontal_Coordinate = Convert.ToInt32(x_coordinate.Text);
                    int Vertical_Coordinate = Convert.ToInt32(y_coordinate.Text);
                    string Quadrant_1 = "Your point is in Quadrant I";
                    string Quadrant_2 = "Your point is in Quadrant II";
                    string Quadrant_3 = "Your point is in Quadrant III";
                    string Quadrant_4 = "Your point is in Quadrant IV";
                    //If x ! = 0 && y !=0 then there will be 4 scenarios: 
                    //1. if x > 0 AND y > 0 => Quadrant 1
                    //2. if x < 0 AND y > 0 => Quadrant 2
                    //3. if x < 0 AND y < 0 => Quadrant 3
                    //4. if x > 0 AND y < 0 => Quadrant 4
                    if (Horizontal_Coordinate > 0 && Vertical_Coordinate > 0)
                    {
                        //scenario 1
                        coordinatesummary.InnerHtml = Quadrant_1;
                    }
                    if (Horizontal_Coordinate < 0 && Vertical_Coordinate > 0)
                    {
                        //scenario 2
                        coordinatesummary.InnerHtml = Quadrant_2;
                    }                    
                    if (Horizontal_Coordinate < 0 && Vertical_Coordinate < 0)
                    {
                        //scenario 3
                        coordinatesummary.InnerHtml = Quadrant_3;
                    }
                    if (Horizontal_Coordinate > 0 && Vertical_Coordinate < 0)
                    {
                        //scenario 4
                        coordinatesummary.InnerHtml = Quadrant_4;
                    }

                }
            }




        }
                
                
                
    }
}