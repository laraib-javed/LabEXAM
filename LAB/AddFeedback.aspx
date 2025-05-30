<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFeedback.aspx.cs" Inherits="LAB.AddFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student Name:
            <asp:TextBox ID="StudentName" runat="server"></asp:TextBox><br />
            <asp:Label ID="StudentNameError" runat="server" ></asp:Label><br />

            Course Name:
            <asp:TextBox ID="CourseName" runat="server"></asp:TextBox><br />
            <asp:Label ID="CourseNameError" runat="server"></asp:Label><br />

            Comments:
            <asp:TextBox ID="Comments" runat="server"></asp:TextBox><br />
            <asp:Label ID="CommentsError" runat="server"></asp:Label><br />

            Phone:
            <asp:TextBox ID="Phone" runat="server"></asp:TextBox><br />
            <asp:Label ID="PhoneError" runat="server" ></asp:Label><br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit Feedback" OnClick="btnSubmit_Click" /><br />
        </div>
        </form>
</body>
</html>
