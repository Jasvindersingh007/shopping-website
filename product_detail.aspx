<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true"
    CodeFile="product_detail.aspx.cs" Inherits="product_detail" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Repeater ID="d1" runat="server">
        <ItemTemplate>
            <!-- breadcrumbs -->
            <div class="breadcrumbs">
                <div class="container">
                    <ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
                        <li><a href="index.aspx"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>
                            Home</a></li>
                        <li class="active">Singlepage</li>
                    </ol>
                </div>
            </div>
            <!-- //breadcrumbs -->
            <div class="products">
                <div class="container">
                    <div class="agileinfo_single">
                        <div class="col-md-4 agileinfo_single_left">
                            <img id="example" src="admin/<%# Eval("imagename") %>" alt=" " class="img-responsive">
                        </div>
                        <div class="col-md-8 agileinfo_single_right">
                            <h2>
                                <%# Eval("product_name") %></h2>
                            <div class="rating1">
                                <span class="starRating">
                                    <input id="rating5" type="radio" name="rating" value="5">
                                    <label for="rating5">
                                        5</label>
                                    <input id="rating4" type="radio" name="rating" value="4">
                                    <label for="rating4">
                                        4</label>
                                    <input id="rating3" type="radio" name="rating" value="3" checked="">
                                    <label for="rating3">
                                        3</label>
                                    <input id="rating2" type="radio" name="rating" value="2">
                                    <label for="rating2">
                                        2</label>
                                    <input id="rating1" type="radio" name="rating" value="1">
                                    <label for="rating1">
                                        1</label>
                                </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
                            <div class="w3agile_description">
                                <h4>
                                    Description :</h4>
                                <p>
                                    Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt
                                    mollit anim id est laborum.Duis aute irure dolor in reprehenderit in voluptate velit
                                    esse cillum dolore eu fugiat nulla pariatur.</p>
                            </div>
                            <div class="snipcart-item block">
                                <div class="snipcart-thumb agileinfo_single_right_snipcart">
                                    <h4 class="m-sing">
                                        $
                                        <%# Eval("price") %>
                                        <span>$
                                            <%# Eval("old_price") %></span></h4>
                                </div>
                                <div class="snipcart-details agileinfo_single_right_details">
                                    <%--<form id="form1" runat="server"> --%>
                                    </ItemTemplate>
    </asp:Repeater>
    <fieldset>
                                        Qty<asp:DropDownList ID="DropDownList1" runat="server" Style="margin-bottom: 10px; margin: 10px;">
                                            <asp:ListItem Selected="True" Value="1">1</asp:ListItem>
                                            <asp:ListItem Value="2">2</asp:ListItem>
                                            <asp:ListItem Value="3">3</asp:ListItem>
                                            <asp:ListItem Value="4">4</asp:ListItem>
                                            <asp:ListItem Value="5">5</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:Button ID="Button2" runat="server" Text="Add to cart" OnClick="cart" class="button"
                                            Style="" />
                                    </fieldset>
                                    <%--</form>--%>
                                </div>
                            </div>
                        </div>
                        <div class="clearfix">
                        </div>
                    </div>
                </div>
            </div>
            <!-- new -->
        
    <asp:Button ID="Button1" runat="server" Text="display user id and email" OnClick="Button1_Click" />
</asp:Content>
