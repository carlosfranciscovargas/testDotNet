<%@ Page Title="" Language="C#" MasterPageFile="~/masterStructura.Master" AutoEventWireup="true" CodeBehind="adminclima.aspx.cs" Inherits="administraClima.clima.clima" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    
    <script src="../Scripts/jquery-1.7.1.js"></script>
        <script type="text/javascript">
            $(document).ready(function()
            {
                $("#ctl00_MainContent_txtfecha").css("display", "none");
                $('#party').change(function () {
                    
                       $("#ctl00_MainContent_txtfecha").val($('#party').val());
                });
            });
    </script>
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 54px;
            margin-left: 40px;
        }
        .auto-style4 {
            width: 191px;
        }
        .auto-style5 {
            font-weight: 700;
            width: 191px;
        }
        .auto-style7 {
            height: 54px;
            margin-left: 40px;
            width: 149px;
        }
        .auto-style8 {
            width: 149px;
        }
        .auto-style9 {
            width: 115px;
        }
        .auto-style10 {
            font-weight: 700;
            width: 115px;
        }
    </style>
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="socialLoginForm">

        <table cellpadding="0" cellspacing="1" class="auto-style2">
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label1" runat="server" Text="Zona" CssClass="label"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:DropDownList ID="drlizona" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drlizona_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">
                    
                    <asp:Label ID="Label3" runat="server" Text="Fecha(dd/mm/aaaa) : " CssClass="label"></asp:Label>
                    <br />
                     &nbsp;</td>
                <td>
                    
                     <input id="party" type="datetime-local" name="partydate" /><asp:TextBox ID="txtfecha" type="datetime-local"  runat="server" Width="0px"   Visible="true" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtfecha" ErrorMessage="campo obligatorio" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="Label2" runat="server" Text="Temperatura"></asp:Label>
                </td>
                <td class="auto-style7">
                    
                    <asp:TextBox ID="txtemperatura" runat="server"  Width="52px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtemperatura" ErrorMessage="campo obligatorio" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                </td>
                 <td class="auto-style5">
                    <asp:Label ID="Label4" runat="server" Text="Presipitacion"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtpresipitacion" runat="server" Width="106px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtpresipitacion" ErrorMessage="campo obligatorio" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
                <tr>
                <td class="auto-style10">
                    <asp:Label ID="Label5" runat="server" Text="Viento"></asp:Label>
                </td>
                <td class="auto-style7">
                                        <asp:TextBox ID="txtviento" runat="server" Width="50px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtviento" ErrorMessage="campo obligatorio" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>

                </td>
                 <td class="auto-style5">
                    
                </td>
                <td class="auto-style3">
                </td>
            </tr>
                <td colspan="2" style="align-items">
                    <asp:Button ID="btnagregar" runat="server" OnClick="btnagregar_Click" Text="Agregar" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="grupo1" />
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
        </table>
        <div>
    <asp:GridView ID="GridView1" runat="server" 
        OnRowEditing="GridView1_RowEditing" AutoGenerateColumns="False" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" DataKeyNames="ideclima" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDeleting="GridView1_RowDeleting" EnableModelValidation="True" Width="474px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
            <asp:BoundField DataField="ideclima" HeaderText="ideclima" ReadOnly="True" />
            <asp:BoundField DataField="idezona" HeaderText="idezona" />
            <asp:BoundField DataField="fechayhora" HeaderText="fechayhora" />
            <asp:BoundField DataField="temperatura" HeaderText="temperatura" />
            <asp:BoundField DataField="presipitacion" HeaderText="presipitacion" />
            <asp:BoundField DataField="viento" HeaderText="viento" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
        </div>
    </div>
    
</asp:Content>
