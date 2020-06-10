<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!-- breadcrumbs -->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="index.aspx"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Order Page</li>
			</ol>
		</div>
	</div>
<!-- //breadcrumbs -->
<!-- login -->
	<div class="login">
		<div class="container">
			<h2>veirfy address</h2>
		
			<div class="login-form-grids animated wow slideInUp" data-wow-delay=".5s">
				<%-- <form id="form1" runat="server">  --%>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    <p>update address or continue to place order</p>
                    <asp:TextBox runat="server" ID="Address" placeholder=" Address"></asp:TextBox>
                <asp:Button ID="Login" runat="server" Text="Confirm Address" OnClick="update"/>
					
			    <%-- <form> --%>
			</div>
			
		</div>
	</div>
<!-- //login -->
         
</asp:Content>

