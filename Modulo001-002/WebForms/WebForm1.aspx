<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Mensagem" Text="" runat="server" />
        <asp:Button Text="clique aqui" runat="server" OnClick="Botao_Click" />
    </div>
    </form>
</body>
</html>
