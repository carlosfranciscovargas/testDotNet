<%@ Page Title="" Language="C#" MasterPageFile="~/masterStructura.Master" AutoEventWireup="true" CodeBehind="verclimaactual.aspx.cs" Inherits="administraClima.clima.verclimaactual" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="socialLoginForm">

        <table cellpadding="0" cellspacing="1" class="auto-style2">
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label1" runat="server" Text="Zona" CssClass="label"></asp:Label>
                    <asp:DropDownList ID="drlizona" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drlizona_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style8">
                    
                    
                    <asp:Label ID="lblfechahora" runat="server"></asp:Label>
                    
                    
                </td>
               
            </tr>
            
                <td colspan="2" style="align-items">
                    <div>
    <asp:GridView ID="GridView1" runat="server" 
        DataKeyNames="ideclima"  EnableModelValidation="True" Width="397px" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" style="margin-top: 21px">
        <Columns>
            <asp:BoundField />
            <asp:BoundField DataField="temperatura" HeaderText="temperatura" />
            <asp:BoundField DataField="presipitacion" HeaderText="presipitacion" />
            <asp:BoundField DataField="viento" HeaderText="viento" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
        </div>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
        </table>
        
    </div>
    
</asp:Content>
