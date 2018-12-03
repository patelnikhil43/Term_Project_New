<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Messages.aspx.cs" Inherits="TermProjectSolution.Messages" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSendMessage" runat="server" Text="Type a friend's email adress and send them a message!"></asp:Label>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
            <br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblMessage" runat="server" Text="Message:"></asp:Label>
            <br />
            <asp:TextBox ID="txtMessage" TextMode="MultiLine" Rows="3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" />
            <br />
            <asp:Button ID="btnGetMessages" runat="server" Text="Get Messages" OnClick="btnGetMessages_Click" />
            <br />
        </div>
    </form>
</body>
</html>
