<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FullCart.aspx.cs" Inherits="FullWebSite.ShoopigCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container-fluid bg-black">
      <div class="container mt-2 mb-4">
            <div class="row">
     <div  class=" col-sm-12 col-md-12 col-12 ">

   <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" ShowFooter="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="2px" CellPadding="3" CellSpacing="2" Height="200px"  OnItemCommand="GridView1_ItemCommand" OnRowDeleting="GridView1_RowDeleting">
         <Columns>
                            <asp:BoundField DataField="sno" HeaderText=" Serial" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="pro_id" HeaderText="id" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="pro_name" HeaderText="Name" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="pro_price" HeaderText="Price" />
                                          
                              
            
                            <asp:BoundField DataField="Quantity" HeaderText="Quantity">
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:ImageField DataImageUrlField="pro_image" HeaderText="Images"  ControlStyle-Height="100">
                                
<ControlStyle Height="100px"></ControlStyle>

                                <ItemStyle Width="100px" HorizontalAlign="Center" />
                                
                            </asp:ImageField>
                             
                            <asp:BoundField DataField="TotalPrice" HeaderText="TotalPrice" >

                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:CommandField HeaderText="Remove" ShowDeleteButton="True">
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:CommandField>
                        </Columns>


                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />


        </asp:GridView>
         </div>
              <div class=" offset-md-3 col-sm-3 col-3">
                <a><asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-outline-success btn-sm mb-3 mt-3"  OnClick = "Checkout_Click"><span><i class="fas fa-shopping-basket"></i>
                 </span> Checkout</asp:LinkButton></a>
            </div>
                 <div class=" col-sm-3 col-3">
                <a><asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-outline-success btn-sm mb-3 mt-3"  href="../Home_Main.aspx"><span><i class="fas fa-home"></i>
                 </span> Continue Shopping</asp:LinkButton></a>
            </div>
        </div>
    </div>
         </div>
</asp:Content>
