<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeworkSubmit.aspx.cs" Inherits="WebClient.HomeworkSubmit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Select homework file: 
        <asp:FileUpload ID="FileUpload1" runat="server" />
        
    </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
