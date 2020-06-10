<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="row">
            <asp:Repeater ID="products" runat="server">
                <ItemTemplate>
                    <div class="col-sm-3 item" style="padding-top:2px">
                        <div class="agile_top_brand_left_grid">
                            <div class="agile_top_brand_left_grid_pos">
							    <img src="images/offer.png" alt=" " class="img-responsive" />
                            </div>
						    <div class="agile_top_brand_left_grid1">
						        <figure>
							        <div class="snipcart-item block">
								        <a href="product_detail.aspx?id=<%# Eval("product_id") %>">
                                        <div class="snipcart-thumb">
									        <img id="pimage" title=" " alt=" " src="admin/<%# Eval("imagename") %>" />		
										    <p><asp:Label ID="Label1" runat="server" Text='<%# Eval("product_name") %>'></asp:Label></p>
									        <div class="stars">
										        <i class="fa fa-star blue-star" aria-hidden="true"></i>
											    <i class="fa fa-star blue-star" aria-hidden="true"></i>
											    <i class="fa fa-star blue-star" aria-hidden="true"></i>
											    <i class="fa fa-star blue-star" aria-hidden="true"></i>
											    <i class="fa fa-star gray-star" aria-hidden="false"></i>
										    </div>
										    <h4>$ <%# Eval("price") %><span>$ <%# Eval("old_price") %></span></h4>
									    </div>
								        <div class="snipcart-details top_brand_home_details">
                                            <input name="submit" value="Display Deatils" class="button">
                                            
							            </div>
						            </div>
							    </figure>
							</div>
            			</div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            
          
            
           &nbsp;
        </div><!--row-->
        
       </div><!--container-->
       &nbsp;
      </div><!--conatiner-fluid-->
</asp:Content>

