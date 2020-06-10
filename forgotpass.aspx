<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="forgotpass.aspx.cs" Inherits="forgotpass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!-- breadcrumbs -->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="index.aspx"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Forget password</li>
			</ol>
		</div>
	</div>
<!-- //breadcrumbs -->
<!-- forgot -->
	<div class="login">
		<div class="container">
			<h2>Forgot Password</h2>
		
			<div class="login-form-grids animated wow slideInUp" data-wow-delay=".5s">
				<%-- <form id="form1" runat="server">  --%>
                    <asp:TextBox runat="server" ID="user_id" placeholder="User_Id"></asp:TextBox>
                    <asp:TextBox runat="server" ID="Email" placeholder=" Registered Email"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
					<div class="forgot">
						<p>Will Send Your Password on User Registered Email Account...</p>
					</div>
                <asp:Button ID="Login" runat="server" Text="send" onclick="send"  />
					
			    <%-- <form> --%>
			</div>
			<h4>For New People</h4>
			<p><a href="register.aspx">Register Here</a> (Or) go back to <a href="index.aspx">Home<span class="glyphicon glyphicon-menu-right" aria-hidden="true"></span></a></p>
		</div>
	</div>
<!-- //forgot -->
</asp:Content>

