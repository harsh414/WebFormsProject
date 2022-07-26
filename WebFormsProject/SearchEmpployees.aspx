<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SearchEmpployees.aspx.cs" Inherits="WebFormsProject.SearchEmpployees" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" CssClass="margin-top:2rem">
        <div class="form-group">
            <asp:Label runat="server">Department</asp:Label>
             <asp:DropDownList ID="ddlDepart" AutoPostBack="True" OnSelectedIndexChanged="ddlDepart_SelectedIndexChanged" runat="server" CssClass="form-control">
                
             </asp:DropDownList>
        </div>
        <asp:GridView ID="gvEmployees" runat="server" BackColor="#DEBA84" 
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

    </div>
</asp:Content>
 
