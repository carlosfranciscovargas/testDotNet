<%@ Page Title="" Language="C#" MasterPageFile="~/masterStructura.Master" AutoEventWireup="true" CodeBehind="adminusuario.aspx.cs" Inherits="administraClima.zona.adminusuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 54px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="loginForm">

        <table cellpadding="0" cellspacing="1" class="auto-style2">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Usuario" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtusuario" runat="server" Width="248px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtusuario" ErrorMessage="campo obligatorio">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="label">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" Width="241px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" ErrorMessage="campo obligatorio">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="align-items">
                    <asp:Button ID="btnagregar" runat="server" OnClick="btnagregar_Click" Text="Agregar" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
        </table>

    </div>
    <div>
    <asp:GridView ID="GridView1" runat="server" 
        OnRowEditing="GridView1_RowEditing" AutoGenerateColumns="False" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" DataKeyNames="ideusuario" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDeleting="GridView1_RowDeleting" EnableModelValidation="True" Width="474px">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
            <asp:BoundField DataField="ideusuario" HeaderText="ideusuario" ReadOnly="True" />
            <asp:BoundField DataField="usuario" HeaderText="usuario" />
            <asp:BoundField DataField="contraseña" HeaderText="password" />
        </Columns>
    </asp:GridView>
        </div>
</asp:Content>
