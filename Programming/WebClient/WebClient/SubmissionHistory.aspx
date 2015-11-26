<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SubmissionHistory.aspx.cs" Inherits="WebClient.SubmissionHistory" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="row">
        <div class="col-md-6 col-lg-offset-3 margin-top-20" style="float:left">
            <div>
               <h3>Your Homework Submission History :</h3>
                <asp:Table ID="hwTable" runat="server" BackColor="White" BorderColor="Black" 
                         BorderWidth="1" ForeColor="Black" GridLines="Both" BorderStyle="Solid" CellSpacing="40" CellPadding="10">
                    <asp:TableRow>
                        <asp:TableHeaderCell Font-Italic="true">Date :</asp:TableHeaderCell>
                        <asp:TableHeaderCell Font-Italic="true">File Name :</asp:TableHeaderCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
        </div>
    </div>

</asp:Content>
