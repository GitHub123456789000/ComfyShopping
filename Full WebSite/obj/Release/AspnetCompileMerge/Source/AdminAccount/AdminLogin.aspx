<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="FullWebSite.Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1"  runat="server">
    <div class="container-fluid"id="log">
	<div class="row">
		
		<div class="col-sm-4">
            
        <div class="   d-none d-sm-block d-none d-md-block">
             <asp:Label ID="Label4" runat="server" Text="Validations Checks on page" Font-Bold="True" ForeColor="#003300"></asp:Label>
            </div>
            <div class="  d-none d-sm-block d-none d-md-block">
            <asp:Label ID="Label6" runat="server" Text="User given password and database password comparsion " ForeColor="#990000"></asp:Label>
	</div>

           
         <div class="  d-none d-sm-block d-none d-md-block">
            <asp:Label ID="Label3" runat="server" Text="Required Field Validater" ForeColor="#990000"></asp:Label>
	</div>
            <div class="  d-none d-sm-block d-none d-md-block">
            <asp:Label ID="Label5" runat="server" Text="Invalid e-mail format" ForeColor="#990000"></asp:Label>
	</div>
            </div>
        

            <div class="col-sm-4 col-xs-12">
			<div class="form-group">
			<div class=" offset-3 col-xs-12">
			<img class="img img-responsive img-circle" src="../img/logoBig.png">
               </div>
					     <div>
                        <i class='fa fa-envelope'></i>
              <asp:Label ID="Label1" runat="server" Text="" ForeColor="red"></asp:Label>

                        </div>
                    <asp:TextBox ID="email" runat="server" placeholder="admin@gmail.com" class="form-control" ></asp:TextBox>
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
                <asp:LinkButton ID="Asignin"  runat="server" CssClass="btn btn-primary  mb-3" OnClick="Asignin_Click"  Text="<i class='fa fa-user-md'></i> Signin "  ></asp:LinkButton>


           </div>
       
</div>
        </div>
     


</asp:Content>
