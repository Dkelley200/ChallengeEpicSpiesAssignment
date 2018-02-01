<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 242px;
            height: 300px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img class="auto-style1"  src="epic-spies-logo.jpg" height="190" /></div>
        <h2 class="auto-style2">Spy New Assignment Form</h2>
        <p>
            Spy Code Name:&nbsp;
            <asp:TextBox ID="spyCodeTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:&nbsp;
            <asp:TextBox ID="newAssignmentNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment:</p>
        <p>
            <asp:Calendar ID="previousEndDateCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment:</p>
        <p>
            <asp:Calendar ID="newStartDateCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected End Date of New Assignment:</p>
        <p>
            <asp:Calendar ID="projectedNewEndDateCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="assignSpyButton" runat="server" OnClick="assignSpyButton_Click" Text="Assign Spy" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
