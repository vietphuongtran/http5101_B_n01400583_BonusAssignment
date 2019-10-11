<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question2_Weekly_Calendar.aspx.cs" Inherits="BonusAssignment_HTTP5101_B_n01400583.Weekly_Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Weekly Calendar</title>
</head>
<body>
    <form id="form1" runat="server">
            <!--<div>
                <p>What is your monthly schedule?</p>
                <div>
                    <label>Monday</label>
                    <asp:DropDownList runat="server"  ID="user_calendar_monday">
                        <asp:ListItem Text="Work" Value="work"></asp:ListItem>
                        <asp:ListItem Text="Have fun" Value="have fun"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div>
                    <label>Tuesday</label>
                    <asp:DropDownList runat="server" ID="user_calendar_tuesday">
                        <asp:ListItem Text="Work" Value="work"></asp:ListItem>
                        <asp:ListItem Text="Have fun" Value="have fun"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div>
                    <label>Wednesday</label>
                    <asp:DropDownList runat="server" ID="user_calendar_wednesday">
                        <asp:ListItem Text="Work" Value="work"></asp:ListItem>
                        <asp:ListItem Text="Have fun" Value="have fund"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div>
                    <label>Thursday</label>
                    <asp:DropDownList runat="server" ID="user_calendar_thursday">
                        <asp:ListItem Text="Work" Value="work"></asp:ListItem>
                        <asp:ListItem Text="Have fun" Value="have fun"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div>
                    <label>Friday</label>
                    <asp:DropDownList runat="server" ID="user_calendar_friday">
                        <asp:ListItem Text="Work" Value="work"></asp:ListItem>
                        <asp:ListItem Text="Have fun" Value="have fun"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div>
                    <label>Saturday</label>
                    <asp:DropDownList runat="server" ID="user_calendar_saturday">
                    <asp:ListItem Text="Work" Value="work"></asp:ListItem>
                    <asp:ListItem Text="Have fun" Value="have fun"></asp:ListItem>
                </asp:DropDownList>
                </div>
                <div>
                    <label>Sunday</label>
                    <asp:DropDownList runat="server" ID="user_calendar_sunday">
                        <asp:ListItem Text="Work" Value="work"></asp:ListItem>
                        <asp:ListItem Text="Have fun" Value="have fun"></asp:ListItem>
                    </asp:DropDownList>
                </div>

                
            </div> -->
              <asp:CheckBoxList runat="server" ID="user_working_days">
                    <asp:ListItem Value="Monday">Monday</asp:ListItem>
                    <asp:ListItem Value="Tuesday">Tuesday</asp:ListItem>
                    <asp:ListItem Value="Wednesday">Wednesday</asp:ListItem>
                    <asp:ListItem Value="Thursday">Thursday</asp:ListItem>
                    <asp:ListItem Value="Friday">Friday</asp:ListItem>
                    <asp:ListItem Value="Saturday">Saturday</asp:ListItem>
                    <asp:ListItem Value="Sunday">Sunday</asp:ListItem>
                </asp:CheckBoxList>
            <div>
                <asp:Button runat="server" text="Submit" />
            </div>
            <div>
                <asp:ValidationSummary runat="server" ShowSummary="true"/>
            </div>
           <div runat="server" id="monthly_summary"></div>
    </form>
</body>
</html>
