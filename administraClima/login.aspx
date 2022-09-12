<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="administraClima.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/estilo.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div id="header" style="padding=1;border=1;">
        <h1>CONTROL DEL CLIMA </h1> <br />
    </div>
    <div id="loginForm">
        <form runat="server">

        <table cellpadding="0" cellspacing="1" class="auto-style2">
            <tr>
                <td>
                    <asp:Label ID="lblusuario" runat="server" Text="Usuario" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtusurio" runat="server" Width="248px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtusurio" ErrorMessage="campo obligatorio">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="label">
                    <asp:Label ID="lblpassword" runat="server" Text="Password:  "></asp:Label>
                </td>
                <td class="auto-style3">
                     <asp:TextBox ID="txtpassword" runat="server" Width="241px" TextMode="Password"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" ErrorMessage="campo obligatorio">*</asp:RequiredFieldValidator>
                     <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtpassword" ErrorMessage="usuario o clave incorrectos" OnServerValidate="CustomValidator1_ServerValidate">*</asp:CustomValidator>
                </td>
            </tr>
            <tr >
                <td colspan="2" style="align-items">
                  <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" />
                </td>
            </tr>
            <tr>
                <td colspan="2">  
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

                </td>
            </tr>
        </table>
            </form>
    </div>
</body>
</html>
