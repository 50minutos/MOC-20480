<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Cookie.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--
                Request - solicita dados do cliente
                Response - envio de dados para o cliente 

                Forms - dados de formulário usando POST
                QueryString - dados usando GET
                ServerVariables - dados do servidor
                Cookies - dados gravados na máquina do cliente
            --%>
            <h1>Exemplo de cookie</h1>
            <asp:MultiView ID="MV" ActiveViewIndex="0" runat="server">
                <asp:View ID="View1" runat="server">
                    <p>
                        Digite o seu nome:
                        <br />
                        <asp:TextBox id="Nome" runat="server" />
                    </p>
                    <p>
                        <asp:Button Text="clique aqui" runat="server" OnClick="Button_Click" />
                    </p>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <p>
                        <asp:Label ID="labelNome" runat="server" />
                    </p>
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
