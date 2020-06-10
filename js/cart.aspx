<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="cart.aspx.cs" Inherits="js_cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Button ID="Button1" runat="server" Text="Button" OnClick="displaycart" />
    
        <asp:DataList ID="d1" runat="server">
            <ItemTemplate>
                <p>
        <asp:Label ID="Label2" runat="server" Text='<%# Eval("product_id") %> '></asp:Label>
        <asp:Label ID="Label1" runat="server" Text='<%# Eval("product_name")%> '></asp:Label>
        
                </p>
            </ItemTemplate>
        </asp:DataList>
    
</asp:Content>

