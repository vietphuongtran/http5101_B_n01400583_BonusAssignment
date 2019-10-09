<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question3_Raffle_Bundle.aspx.cs" Inherits="BonusAssignment_HTTP5101_B_n01400583.RaffleBundle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Raffle Bundle</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="student_fname">First name:</label>
            <asp:TextBox runat="server" ID="student_fname"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="student_fname" ErrorMessage="Please enter your first name" EnableClientScript="true"></asp:RequiredFieldValidator>
        </div>
        <div>
            <label for="student_lname">Last name:</label>
            <asp:TextBox runat="server" ID="student_lname"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="student_lname" ErrorMessage="Please enter your last name" EnableClientScript="true"></asp:RequiredFieldValidator>
        </div>
        <div>
            <label for="student_booking_amount">Please enter the amount of ticket you want to buy:</label>
            <asp:TextBox runat="server" ID="student_booking_amount"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="student_booking_amount" ErrorMessage="Please enter a number" EnableClientScript="True"></asp:RequiredFieldValidator>
            <asp:CompareValidator runat="server" ControlToValidate="student_booking_amount" ErrorMessage="Please enter a positive integer number" Operator="GreaterThan" ValueToCompare="0" EnableClientScript="true" Type="Integer"></asp:CompareValidator>
        </div>
        <div>
             <asp:Button runat="server" text="Submit" />
        </div>
        <div>
                <asp:ValidationSummary runat="server" ShowSummary="true"/>
        </div>
        <div runat="server" id="bundle_summary"></div>
    </form>
</body>
</html>
