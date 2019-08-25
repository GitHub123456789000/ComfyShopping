<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Product Search.aspx.cs" Inherits="FullWebSite.Search_Page.Product_Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <div class="container-fluid bg-white">
        <div class="container pt-5">
            <div class="row">
                <h3></h3>
                
            </div>


        </div>
      
            
        <div class="container mt-5">
            <div class="row">
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:comfy_string %>" SelectCommand="SELECT * FROM [tbl_product_items] WHERE ([Search] LIKE '%' + @Search + '%')">
              <SelectParameters>
                  <asp:ControlParameter ControlID="TextBox1" Name="Search" PropertyName="Text" Type="String" />
              </SelectParameters>
               
                </asp:SqlDataSource>

                
                <asp:Repeater ID="Repeater1" runat="server" >
                    <ItemTemplate>
                        <div class="col-md-4 col-sm-6">
              

                            <div class="card">
                                
                                <asp:Image CssClass="img-fluid  " ID="Image1" Style="width: 224px; height: 336px" runat="server" ImageUrl='<%# Eval("pro_image")%>' />
                                <div class="card-body">
                                   <%-- <asp:DropDownList ID="DropDownList1" runat="server">
                                         <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    </asp:DropDownList>--%>
                                    
                                    <asp:Label ID="Label2" runat="server" CssClass="h5 " Text='<%# Eval("pro_name")%>'>
                                    </asp:Label>
                                    <br />
                                    &nbsp
               <asp:Label ID="Label3" runat="server" CssClass="h5  " Text='<%# "£ " + Eval( "pro_price"  )%>'>


               </asp:Label>

                                    <br />


<%--                                    <asp:ImageButton ID="ImageButton1" runat="server"  CssClass="m-2 img-fluid"  ImageUrl="~/img/button.png" CommandName="add to cart" CommandArgument='<%#Eval("pro_id")%>' />--%>
                                </div>
                            </div>
                        </div>

                    </ItemTemplate>

                </asp:Repeater>




            </div>
        </div>
    </div>
 
</asp:Content>