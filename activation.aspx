<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="activation.aspx.cs" Inherits="activation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- breadcrumbs -->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="index.aspx"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Activation Page</li>
			</ol>
		</div>
	</div>
<!-- //breadcrumbs -->
<!-- register -->
	<div class="register">
		<div class="container">
			<h2>Activation</h2>
			<div class="login-form-grids">
				<h5>kindly check your email</h5>
				<%-- <form runat="server" id="userreg"> --%>
                <asp:TextBox ID="name" runat="server" placeholder="Activation Code..."></asp:TextBox>
                
                <asp:Button ID="Button1" runat="server" Text="Activate"></asp:Button>
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
					
				<%-- </form> --%>
			</div>
			<div class="register-home">
				<a href="index.aspx">Home</a>
			</div>
		</div>
	</div>
<!-- //register -->

</asp:Content>

