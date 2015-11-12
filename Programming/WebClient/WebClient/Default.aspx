<%@ page title="Home Page" language="C#" masterpagefile="~/Site.Master" autoeventwireup="true" codebehind="Default.aspx.cs" inherits="WebClient._Default" %>

<asp:content id="BodyContent" contentplaceholderid="MainContent" runat="server">

    <div class="row">
        <div class="col-md-6 col-lg-offset-3" style="margin-top: 20px">
            <a href="#" class="btn btn-primary btn-large btn-block"><span class="glyphicon glyphicon-folder-open"></span> Browse assignments</a>
            <a href="HomeworkSubmit.aspx" class="btn btn-primary btn-large btn-block"><span class="glyphicon glyphicon-cloud-upload"></span> Submit assignment</a>
            <a href="#" class="btn btn-primary btn-large btn-block"><span class="glyphicon glyphicon-tags"></span> Assignments statistics</a>
        </div>
        <div class="col-md-6 col-lg-offset-3" style="margin-top: 20px">
            <a href="#" class="btn btn-primary btn-large btn-block"><span class="glyphicon glyphicon-education"></span> Browse tutors</a>
            <a href="#" class="btn btn-primary btn-large btn-block"><span class="glyphicon glyphicon-time"></span> Book tutor</a>
        </div>
    </div>

</asp:content>
