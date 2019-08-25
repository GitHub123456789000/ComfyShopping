<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CLogin.aspx.cs" Inherits="FullWebSite.CustomerAccount.CLogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   

    <div class="container" id="log">
        <div class="row">

            <div class=" col-sm-8 col-m-4  col-lg-4 col-12">
                <div class="form-group">

                   
                    <div>
                        <i class='fa fa-envelope'></i>
                        <asp:Label ID="Label1" runat="server" Text="" ForeColor="red"></asp:Label>
                        
                    </div>
                    <asp:TextBox ID="email" runat="server" placeholder="kashif.net@yahoo.com" class="form-control" required=""></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email is required" ControlToValidate="email" ForeColor="red" Display="Dynamic"></asp:RequiredFieldValidator>

                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"  Display="Dynamic" ErrorMessage="E-mail format wrong" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="email" ForeColor="red"></asp:RegularExpressionValidator>
                </div>

                <div class="form-group">
                    <div>
                        <i class='fa fa-lock'></i>
                        <asp:Label ID="Label7" runat="server" Text="" ForeColor="red"></asp:Label>
                         
                    </div>
                  
                    <asp:TextBox ID="password" runat="server" placeholder="aaa" class="form-control" ></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password is required" ControlToValidate="password" ForeColor="red" Display="Dynamic"></asp:RequiredFieldValidator>


                </div>
                <div class="checkbox">
                    <label>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                        Remember me</label>
                </div>
                <asp:LinkButton ID="Csignin"  runat="server" CssClass="btn btn-primary  mb-3" OnClientClick="return ValidateData()" OnClick="Csignin_Click"  Text="<i class='fa fa-user-md'></i> Signin "  ></asp:LinkButton>


           </div>

            <div>
                <div class=" offset-md-4 col-sm-8 col-12">

                    <h3>New Customers
                    </h3>
                    <div>
                        <h4>Create a Comfy account today</h4>
                    </div>
                    <asp:LinkButton ID="Csignup" runat="server" CssClass="btn btn-primary  mb-3" Text="<i class='fa fa-user-plus'></i> Signup " OnClick="Csignup_Click" CausesValidation="False"></asp:LinkButton>
                   
                   
                </div>
            </div>
            </div>
            <div class="row">
            <div class=" offset-md-6 ">
                

                <div class="   d-none d-sm-block ">
                    <asp:Label ID="Label4" runat="server" Text="Validations Checks on page" Font-Bold="True" ForeColor="#003300"></asp:Label>
                </div>
                <div class="  d-none d-sm-block">
                    <asp:Label ID="Label2" runat="server" Text="User given password and database password comparsion with execute scaler " ForeColor="#990000"></asp:Label>
                </div>
                <div class="  d-none d-sm-block">
                    <asp:Label ID="Label3" runat="server" Text="Required Field Validater " ForeColor="#990000"></asp:Label>
                </div>
                <div class="  d-none d-sm-block ">
                    <asp:Label ID="Label5" runat="server" Text="Invalid e-mail format" ForeColor="#990000"></asp:Label>
                </div>
                    </div>
            </div>
                
       
    </div>
   <%--<script type="text/javascript">
   
        function ValidateData() {

             var text1 = document.getElementById('<%=email.ClientID %>').value;
             if (text1 == "") {
                 document.getElementById("idEmail").innerHTML = "<span style = 'color:red;' >E-mail is required!</span>"; 
                 return false;
             }
                 var text2 = document.getElementById('<%=password.ClientID %>').value;
                 if (text2 == "") {
                     document.getElementById("idPassword").innerHTML = "<span style = 'color:red;' >Password is required!</span>";
                     return false;
                 
                    
                     }





                }
             
         
       
            
</script>--%>



    </asp:Content>