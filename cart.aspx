<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true"
    CodeFile="cart.aspx.cs" Inherits="cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- breadcrumbs -->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="index.aspx"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Cart Page</li>
			</ol>
		</div>
	</div>
<!-- //breadcrumbs -->
<div class="checkout">
        <div class="container">
            <h2>
                Your shopping cart contains: <span><asp:Label ID="Label50" runat="server" Text=""></asp:Label> Products </span></h2>
            <div class="checkout-right">
                <table class="timetable_sub">
                    <thead>
                        <tr>
                            <th>
                                SL No.
                            </th>
                            <th>
                                Product
                            </th>
                            <th>
                                Quality
                            </th>
                            <th>
                                Product Name
                            </th>
                            <th>
                                Price
                            </th>
                            <th>
                                grandtotal
                            </th>
                            <th>
                                Remove
                            </th>
                        </tr>
                    </thead>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr class="rem1">
                                <td class="invert">
                                    <%# Container.ItemIndex+1 %>
                                    <asp:Label ID="Label2" runat="server" hidden Text='<%# Eval("cart_id") %>' />
                                </td>
                                <td class="invert-image">
                                    <a href="single.html">
                                        <img src="admin/<%# Eval("imagename") %>" alt=" " class="img-responsive" width="25%"
                                            height="25%" /></a>
                                </td>
                                <td class="invert">
                                    <div class="quantity">
                                        <div class="quantity-select">
                                            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="minus"><div class="entry value-minus">
                                                &nbsp;</div>
                                            </asp:LinkButton>
                                            <div class="entry value">
                                                <span><%# Eval("qty") %></span>
                                            </div>
                                            <asp:LinkButton ID="plus" runat="server" OnClick="plus"><div class="entry value-plus" onclick="plus">
                                                &nbsp;
                                            </div></asp:LinkButton>
                                        </div>
                                    </div>
                                </td>
                                <td class="invert">
                                    <%# Eval("product_name") %>
                                    <asp:Label ID="Label1" runat="server" hidden Text='<%# Eval("product_id") %>' />
                                </td>
                                <td class="invert">
                                    $
                                    <%# Eval("price") %>
                                </td>
                                <td class="invert">
                                    $
                                    <%# Eval("itemtotal") %>
                                </td>
                                <td class="invert">
                                    <div class="rem">
                                        <asp:LinkButton ID="LinkButton1" runat="server" class="close1" OnClick="remove" />
                                    </div>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
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
                    <a href="order.aspx"><span class="glyphicon glyphicon-menu-left" aria-hidden="true">
                    </span>Continue checkout</a>
                <br />
                <br />
                    <a href="index.aspx"><span class="glyphicon glyphicon-menu-left" aria-hidden="true">
                    </span>Continue Shopping</a>
                </div>
                <div class="clearfix">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
