<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Epicode_U4_W3_D3._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click"/>

            <asp:DropDownList ID="Pizze" runat="server">
                <asp:ListItem Value="5"   Text="5,00€ - Margherita"></asp:ListItem>
                <asp:ListItem Value="6,5" Text="6,50€ - Diavola"   ></asp:ListItem>
                <asp:ListItem Value="7"   Text="7,00€ - Bosciaiola"></asp:ListItem>
                <asp:ListItem Value="7"   Text="7,00€ - 4 Formaggi"></asp:ListItem>
            </asp:DropDownList>

            <asp:CheckBoxList ID="Ingredienti" runat="server">
                <asp:ListItem Value="2,00" Text="2.00 € - Mozzarella di bufala"></asp:ListItem>
                <asp:ListItem Value="1,00" Text="1.00 € - Salame"></asp:ListItem>
                <asp:ListItem Value="1,00" Text="1.00 € - Salsiccia"></asp:ListItem>
                <asp:ListItem Value="1,00" Text="1.00 € - Peperoni"></asp:ListItem>
            </asp:CheckBoxList>

            <asp:Button ID="Aggiungi" runat="server" Text="Aggiungi" OnClick="Aggiungi_Click"/>
            <asp:Button ID="Completa" runat="server" Text="Completa ordine" OnClick="Completa_Click"/>

            <div ID="Totale" runat="server">

            </div>

        </div>
    </form>
</body>
</html>
