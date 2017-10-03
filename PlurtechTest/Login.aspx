<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PlurtechTest.Login" MasterPageFile="~/Site1.Master" %>

<asp:Content ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
.center-box{
    position:absolute;
    top:0;
    right:0;
    bottom:0;
    left:0;
    z-index:99;
    margin:auto;
    height:400px;
    width:400px;
    text-align:center;
}
            </style>

</asp:Content>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="container">
    <div class="row">
        <div class="center-box">

            <asp:Login ID="Login1" runat="server" OnAuthenticate="ValidateUser" DisplayRememberMe="false" LoginButtonText="Sign in" UserNameLabelText="Login:">
            </asp:Login>

       </div>
    </div>
</div>

</asp:Content>