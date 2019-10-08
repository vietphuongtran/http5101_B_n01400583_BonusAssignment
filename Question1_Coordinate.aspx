<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question1_Coordinate.aspx.cs" Inherits="BonusAssignment_HTTP5101_B_n01400583.Coordinate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Coordinate</title>
    </head>
    <body>
       <form id="form1" runat="server">
            <div>
                <label for="x_coordinate">Please enter a value for x:</label>
                <asp:Textbox runat="server" id="x_coordinate" name="x_coordinate"></asp:Textbox>
                <asp:CompareValidator runat="server" ControlToValidate="x_coordinate" ErrorMessage="Please do not enter 0" Operator="NotEqual" ValueToCompare="0" Type="Double"></asp:CompareValidator>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="x_coordinate" ErrorMessage="Please enter a number" EnableClientScript="true" Type="Double"></asp:RequiredFieldValidator>
            </div>
            <div>
                <label for="y_coordinate">Please enter a value for y:</label>
                <asp:Textbox runat="server" id="y_coordinate" name="y_coordinate"></asp:Textbox>
               <asp:CompareValidator runat="server" ControlToValidate="y_coordinate" ErrorMessage="Please do not enter 0" Operator="NotEqual" ValueToCompare="0" Type="Double"></asp:CompareValidator>
               <asp:RequiredFieldValidator runat="server" ControlToValidate="y_coordinate" ErrorMessage="Please enter a number"  EnableClientScript="true" Type="Double"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Button runat="server" text="Submit" />
            </div>
            <div>
                <asp:ValidationSummary runat="server" ShowSummary="true"/>
            </div>
           <div runat="server" id="coordinatesummary"></div>
        </form>
    </body>
</html>
