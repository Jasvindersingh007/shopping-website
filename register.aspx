<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- breadcrumbs -->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="index.aspx"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Register Page</li>
			</ol>
		</div>
	</div>
<!-- //breadcrumbs -->
<!-- register -->
	<div class="register">
		<div class="container">
			<h2>Register Here</h2>
			<div class="login-form-grids">
				<h5>profile information</h5>
				<%-- <form runat="server" id="userreg"> --%>
                <asp:TextBox ID="name" runat="server" placeholder="First Name..."></asp:TextBox>
                <asp:TextBox ID="contact" runat="server" placeholder="Contact N..."></asp:TextBox>
					
				
				<div class="register-check-box">
					<div class="check">
						<label class="checkbox"><input type="checkbox" name="checkbox"><i> </i>Subscribe to Newsletter</label>
					</div>
				</div>
				<h6>Login information</h6>
                <asp:TextBox placeholder="Email Address" ID="email" runat="server"></asp:TextBox>
                <asp:TextBox placeholder="Password" ID="pwd" runat="server"></asp:TextBox>
                <asp:TextBox placeholder="Password Confirmation" ID="cpwd" runat="server"></asp:TextBox>
					<div class="register-check-box">
						<div class="check">
							<label class="checkbox"><input type="checkbox" name="checkbox"><i> </i>I accept the terms and conditions</label>
						</div>
					</div>
                    <asp:Button ID="Button1" OnClick="save" runat="server" Text="aspRegisterbtn"></asp:Button>
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

