<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestTwilio.aspx.cs" Inherits="Web.TestTwilio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="smsid" runat="server">
    </div>
    <label for="email">Enter email id</label>&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <label for="pass">
        <br />
        Enter password</label>&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<div id="emails" runat="server">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </div>
    </form>
</body>
</html>
