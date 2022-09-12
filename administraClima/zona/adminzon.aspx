<%@ Page Title="" Language="C#" MasterPageFile="~/masterStructura.Master" AutoEventWireup="true" CodeBehind="adminzon.aspx.cs" Inherits="administraClima.zona.adminzona" %>
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
                    <asp:Label ID="lblzona" runat="server" Text="Zona" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtzonao" runat="server" Width="248px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtzonao" ErrorMessage="campo obligatorio">*</asp:RequiredFieldValidator>
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
        OnRowEditing="GridView1_RowEditing" AutoGenerateColumns="False" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" DataKeyNames="idezona" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDeleting="GridView1_RowDeleting" EnableModelValidation="True" Width="474px">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
            <asp:BoundField DataField="idezona" HeaderText="idezona" ReadOnly="True" />
            <asp:BoundField DataField="zona" HeaderText="zona" />
        </Columns>
    </asp:GridView>
        </div>
</asp:Content>
