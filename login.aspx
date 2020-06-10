<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!-- breadcrumbs -->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="index.aspx"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Login Page</li>
			</ol>
		</div>
	</div>
<!-- //breadcrumbs -->
<!-- login -->
	<div class="login">
		<div class="container">
			<h2>Login Form</h2>
		
			<div class="login-form-grids animated wow slideInUp" data-wow-delay=".5s">
				<%-- <form id="form1" runat="server">  --%>
                    <asp:TextBox runat="server" ID="Email" placeholder="Email Address"></asp:TextBox>
                    <asp:TextBox runat="server" ID="pass" placeholder="Password"></asp:TextBox>
					
					<div class="forgot">
						<%--to dipay on same pGE<a href="#" onclick="window.open('forgotpass.aspx','FP','width=500,height=50,top=300,left=500,fullscreen=no,resizeable=0');">Forgot Password?</a>--%>
						<a href="forgotpass.aspx">Forgot Password?</a>
					</div>
                <asp:Button ID="Login" runat="server" Text="Login" onclick="Login_Click" />
					
			    <%-- <form> --%>
			</div>
			<h4>For New People</h4>
			<p><a href="register.aspx">Register Here</a> (Or) go back to <a href="index.aspx">Home<span class="glyphicon glyphicon-menu-right" aria-hidden="true"></span></a></p>
		</div>
	</div>
<!-- //login -->
</asp:Content>

