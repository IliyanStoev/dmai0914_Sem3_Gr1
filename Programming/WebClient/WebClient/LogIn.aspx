<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebClient.LogIn" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-6 col-lg-offset-3" style="margin-top: 20px">
            <div style="text-align: center">
                <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
                <asp:TextBox ID="UserNameTB" runat="server"></asp:TextBox>
            </div>
            <p>
            </p>
            <div style="text-align: center">
                <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
                <asp:TextBox ID="UserPasswordTB" runat="server"></asp:TextBox>
            </div>
            <p>
            </p>
            <div style="text-align: center">
                <asp:Button ID="Button1" runat="server" Text="Log in" OnClick="Button1_Click" />
            </div>
        </div>
    </div>

</asp:Content>
