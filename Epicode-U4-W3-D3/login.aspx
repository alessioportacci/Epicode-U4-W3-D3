<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Epicode_U4_W3_D3.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="Username" runat="server"></asp:TextBox> 
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Accedi" OnClick="Button1_Click"/>

        </div>
    </form>
</body>
</html>
