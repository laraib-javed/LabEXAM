<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewFeedback.aspx.cs" Inherits="LAB.ViewFeedback" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Feedback</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="FeedbackID">
                <Columns>
                    <asp:BoundField DataField="FeedbackID" HeaderText="Feedback ID" />
                    <asp:BoundField DataField="StudentName" HeaderText="Student Name" />
                    <asp:BoundField DataField="CourseName" HeaderText="Course Name" />
                    <asp:BoundField DataField="Comments" HeaderText="Comments" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:Button ID="btnDelete" runat="server" Text="Delete Record" OnClick="btnDelete_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Update Record" OnClick="btnEdit_Click" />
        </div>
    </form>
</body>
</html>
