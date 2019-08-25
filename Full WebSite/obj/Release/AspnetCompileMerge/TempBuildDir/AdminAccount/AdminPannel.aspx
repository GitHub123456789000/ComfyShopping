<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPannel.aspx.cs" Inherits="FullWebSite.Admin_In_Boot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
          
 <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script> 
    
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.1/css/all.css" integrity="sha384-50oBUHEmvpQ+1lW4y57PTFmhCaXp0ML5d60M1M7uH2+nqUivzIebhndOJK28anvf" crossorigin="anonymous"/>

    <link href="../css/style.css" rel="stylesheet" />
    <link href="../css/bootstrap4.css" rel="stylesheet" />
    <title></title>
</head>
<body>
     <form id="form1" runat="server">

         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
          <ContentTemplate>
     <div class="container" >
             <div class="row ">
                 
    <div id="mySidenav" class="sidenav" >
  <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
<asp:LinkButton ID="PostAdd" runat="server" OnClick="AddPost_Click"  CausesValidation="False" Font-Size="Medium">Post An Ad</asp:LinkButton><br />
 <asp:LinkButton ID="ViewAdd" runat="server" CausesValidation="False" OnClick="ViewAdd_Click">Sort Oders By Number</asp:LinkButton>
        </div>
               </div>  
                

 
          
        <span class="  text-danger  text-large" style= "cursor:pointer;" onclick="openNav()">&#9776;Open</span> 
         <div class =" offset-md-10 offset-sm-10 offset-10   ">  

                <i class="fas fa-sign-out-alt" aria-hidden="true"> 
               <a><asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CssClass=" text-danger " OnClick="LinkButton2_Click" Font-Size="Large">&nbspSignout</asp:LinkButton></a></i>
              
                     </div>

                 <div class =" offset-md-4 offset-sm-4 offset-4   ">  
                 <h3 class="text-primary"> Admin Page</h3>
                  </div>
                 
                    
  

                
                  <asp:MultiView ID="MultiView1" runat="server">
                   <asp:View ID="View1" runat="server">
                     <div  class="offset-md-2 col-sm-12 col-md-10 col-12 ">
                        <table class="table table-bordered table-responsive " > 
                           <thead>
                               <tr >
                                   <th class="text-center text-capitalize font-weight-normal text-large   bg-success" colspan="2" >
                                       Add Products
                                   </th>

                               </tr>
                           </thead>
            <tr>
                <td class="bg-success" align ="center" >Main Category</td>
                <td class=" bg-secondary"> 
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="228px"  DataTextField="cat_name" DataValueField="cat_id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList></td>
                </tr>
               
            <tr>
                <td class="bg-success" align="center">Sub Category</td>
                <td class=" bg-secondary">
                    <asp:DropDownList ID="DropDownList2"  runat="server" Width="228px" DataTextField="sub_name" DataValueField="sub_id"></asp:DropDownList></td>
                
               
            </tr>

            <tr>
                <td class="bg-success" align="center">Product Name</td>
                <td class=" bg-secondary">
               <asp:TextBox ID="TextBox1" class="form-control" runat="server"  ></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Product Name Requird" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                 
            </tr>
         
            <tr>
                <td class="bg-success" align="center">Date</td>
                <td class=" bg-secondary">
               <asp:TextBox ID="TextBox2" class="form-control" runat="server"  ReadOnly="true" ></asp:TextBox> </td>
                 
            </tr>

            <tr>
                <td class="bg-success" align="center">Product Price</td>
                <td class=" bg-secondary">
               <asp:TextBox ID="TextBox3" class="form-control" runat="server"></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Price required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                
            </tr>
                            <tr>
               <td class="bg-success" >Product image</td>
                <td class=" bg-secondary"> <asp:FileUpload ID="FileUpload3" runat="server" />
                                
<%--                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="FileUpload3" ErrorMessage="Img required" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                                
                                </td>
             </tr>
                           
                  <tr>           
                 <td colspan="2"align="center"> <asp:LinkButton ID="AddPost"  runat="server" CssClass="btn btn-primary" Text= "<i class='fa fa-user-md'></i> Post add " OnClick="Button3_Click"></asp:LinkButton>
                     </td> </tr> 
                    <tr> <td colspan="2"align="center">    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                              <asp:HyperLink ID="HyperLink1" runat="server"></asp:HyperLink></td>
                             </tr>  
               </table>
                       
                     
                        </div>
                         </asp:View>     
                        
         <asp:View ID="View2" runat="server">
              
      <div class="container mt-2 mb-4">
            <div class="row">
     <div  class=" col-sm-12 col-md-12 col-12 ">

   <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" ShowFooter="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="2px" CellPadding="3" CellSpacing="2" Height="200px"  OnItemCommand="GridView1_ItemCommand" >
         <Columns>
                            <asp:BoundField DataField="order_id" HeaderText="Order Number" >
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="order_price" HeaderText="OrderPrice" >
                            </asp:BoundField>
                             
                            <asp:BoundField DataField="placed_date" HeaderText="Placed Date" >

                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="cu_email" HeaderText="Customer Email" />
                            <asp:BoundField DataField="cu_phone" HeaderText="Customer Phone" />
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
             
                 
            </div>
       
    </div>
        
                     
                         </asp:View>
                      
                
                                </asp:MultiView>

                    </div> 
            </ContentTemplate>
                 </asp:UpdatePanel> 
           </form>               
             
     

    <script>
       
            document.getElementById("TextBox1").onmouseover = function () { mouseOver() };
            function mouseOver() {
              
                var now = new Date();
                var year = now.getFullYear();
                var month = now.getMonth();
                var day = now.getDate();
                var hour = now.getHours();
                var minute = now.getMinutes();
                var dateTime = year + '/' + month + '/' + day + ' ' + hour + ':' + minute + ':' + second;
              
                document.getElementById("TextBox2").value = "LastSync: " + now.today() + " @ " + now.timeNow();
            }

        
        

function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
}

function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
}
</script>
    </body>
    </html>
    
