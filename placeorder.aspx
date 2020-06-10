<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="placeorder.aspx.cs" Inherits="placeorder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!-- breadcrumbs -->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="index.aspx"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">PlaceOrder Page</li>
			</ol>
		</div>
	</div>
<!-- //breadcrumbs -->
<div class="checkout">
        <div class="container">
            <h2>
                Your shopping cart contains: <span><asp:Label ID="Label50" runat="server" Text=""></asp:Label> Products </span></h2>
            <div class="checkout-left">
                <div class="checkout-left-basket">
                    <h4>
                        Continue to basket</h4>
                    <ul>
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <li>
                                    <%# Eval("product_name")%><i>-</i> <span>$
                                        <%# Eval("itemtotal") %></span></li>
                            </ItemTemplate>
                            <FooterTemplate>
                                <li>Total Service Charges <i>-</i> <span>$15.00</span></li>
                                <li>Total <i>-</i> <span>$
                                    <%#grandtotal() %></span></li>
                            </FooterTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <div class="checkout-right-basket">
                    <p>Once you hit placeOrder button your order will be placed & plz note that this site is for dummy purpose...</p>
                    <p> And your delivery address is</p> <h2><asp:Label ID="Label1" runat="server" Text="And your delivery address is c">bdf</asp:Label> </h2>
                <br />
                    <a  href="" ><span class="glyphicon glyphicon-menu-left" aria-hidden="true">
                    </span><asp:Button OnClick="submit" ID="Button1" runat="server" Text="Place Order" style="border:none; background:inherit;" ></asp:Button></a>
                    
                    
                </div>
                <div class="clearfix">
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>

