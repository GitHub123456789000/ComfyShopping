<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="FullWebSite.CustomerAccount.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container" id="log">
        <div class="row">

            <div class=" col-md-4 ">

                <div class="   d-none d-sm-block ">
                    <asp:Label ID="Label4" runat="server" Text="Validations Checks on page" Font-Bold="True" ForeColor="#003300"></asp:Label>
                </div>
                <div class="  d-none d-sm-block">
                    <asp:Label ID="Label2" runat="server" Text="E-mail already exist" ForeColor="#990000"></asp:Label>
                </div>
                <div class="  d-none d-sm-block">
                    <asp:Label ID="Label3" runat="server" Text="Required Field Validater" ForeColor="#990000"></asp:Label>
                </div>
                <div class="  d-none d-sm-block ">
                    <asp:Label ID="Label5" runat="server" Text="Invalid e-mail format" ForeColor="#990000"></asp:Label>
                </div>
            </div>







            <div class=" col-sm-4 col-md-4 col-12">
                <div class="form-group">

                   
                    <div><i class='fa fa-envelope'></i>
                        <asp:Label ID="Label1" runat="server" Text="" ForeColor="red"></asp:Label></div>
                    <asp:TextBox ID="email" runat="server" placeholder="e-mail" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email is required" ControlToValidate="email" ForeColor="red" Display="Dynamic"></asp:RequiredFieldValidator>

                      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="InValid E-mail format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="email" ForeColor="#990000" Display="Dynamic"></asp:RegularExpressionValidator>

                </div>
                

                <div class="form-group">
                    <div><i class='fa fa-lock'></i></div>
                    <asp:TextBox ID="password" runat="server" placeholder="password" class="form-control"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=" Password is required" ControlToValidate="password" ForeColor="red"></asp:RequiredFieldValidator>
                   
                </div>

                <div class="form-group">
                    <div><i class='fa fa-phone'></i></div>
                    <asp:TextBox ID="phone" runat="server" placeholder="phone" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Phone is required" ControlToValidate="phone" ForeColor="red"></asp:RequiredFieldValidator>

                </div>
               
                <asp:LinkButton ID="Csignin" runat="server" CssClass="btn btn-primary  mb-3" Text="<i class='fa fa-user-md'></i> Signin " OnClick="Csignin_Click"></asp:LinkButton>

            </div>

        </div>
    </div>
            

</asp:Content>
