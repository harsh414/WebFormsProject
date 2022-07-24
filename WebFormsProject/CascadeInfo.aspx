<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="CascadeInfo.aspx.cs" Inherits="WebFormsProject.CascadeInfo" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <asp:DropDownList ID="ddlStates" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlStates_SelectedIndexChanged">
             <asp:ListItem Value="1" Text="Maharashtra"></asp:ListItem>
             <asp:ListItem Value="2" Text="Delhi"></asp:ListItem>
         </asp:DropDownList>
         <hr />
         <asp:GridView ID="gvCities" runat="server" BackColor="#DEBA84" 
             BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
             CellSpacing="2">
             <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
             <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
             <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
             <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
             <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
             <SortedAscendingCellStyle BackColor="#FFF1D4" />
             <SortedAscendingHeaderStyle BackColor="#B95C30" />
             <SortedDescendingCellStyle BackColor="#F1E5CE" />
             <SortedDescendingHeaderStyle BackColor="#93451F" />
         </asp:GridView>
        
    
        
</asp:Content>