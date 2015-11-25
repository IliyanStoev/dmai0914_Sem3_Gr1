<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomeworkSubmit.aspx.cs" Inherits="WebClient.HomeworkSubmit" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-6 col-lg-offset-3" style="margin-top: 20px">
            <div>
                <p>Select an assignment: </p>
                <asp:DropDownList ID="assignmentList" runat="server"></asp:DropDownList>
                <p>Select homework file: </p>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </div><br />

            <div>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </div>
        </div>
    </div>

</asp:Content>
