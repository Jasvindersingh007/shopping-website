<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="addproduct.aspx.cs" Inherits="admin_addproduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="page-wrapper">
    <div id="page-inner">
        <asp:TextBox ID="pro_id" placeholder="product id" runat="server"></asp:TextBox><br /><br />
        <asp:TextBox ID="pro_name" placeholder="product name" runat="server"></asp:TextBox><br /><br />
        <asp:TextBox ID="stock" placeholder="stock" runat="server"></asp:TextBox><br /><br />
        <asp:TextBox ID="price" placeholder="price" runat="server"></asp:TextBox><br /><br />
        <asp:TextBox ID="old_price" placeholder="old price" runat="server"></asp:TextBox><br /><br />
        <asp:FileUpload ID="f1" runat="server" /><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
       
    </div>
            <!-- /. PAGE INNER  -->
</div>
        <!-- /. PAGE WRAPPER  -->        
</asp:Content>

