<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebClient.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style type="text/css">
  </style>
  <title></title>
</head>
<body>
    <form id="form1" runat="server">
      
      <div style ="text-align: center">
        <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
        <p>

        </p>
      <div style ="text-align: center">
         <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
         <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </div>
        <p>

        </p>
        <div style ="text-align: center">
            <asp:Button ID="Button1" runat="server" Text="Log in" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>
