<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="serachproduct.aspx.cs" Inherits="admin_serachproduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="page-wrapper">
    <div id="page-inner">
        <h2>Enter <b>product Id</b> or <b>Name</b> which you want to search..</h2>
        <asp:TextBox ID="pro_id" placeholder="product id" runat="server"></asp:TextBox><br /><b>or</b><br />
        <asp:TextBox ID="pro_name" placeholder="product name" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="Button2" runat="server" Text="search" onclick="Button1_Click" />
        <asp:Button ID="Button1" runat="server" Text="reset" onclick="reset" />
        <asp:GridView ID="GridView1" runat="server">
                    
        </asp:GridView>
        
        <asp:Repeater ID="d1" runat="server">
                <ItemTemplate>
                    
                    <%# Eval("product_name") %>
                    <%# Eval("price") %>
                </ItemTemplate>
        </asp:Repeater>
    </div>
            <!-- /. PAGE INNER  -->
</div>
        <!-- /. PAGE WRAPPER  -->        
</asp:Content>

