<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="holidayRedesign.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Staff Weekend Requests</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/app.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Lato" rel="stylesheet">
</head>
<body>
       <nav class="navbar navbar-inverse">
    <div class="container">
      <!-- Brand and toggle get grouped for better mobile display -->
      <div class="navbar-header">
        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
          <span class="sr-only">Toggle navigation</span>
          <span class="icon-bar"></span>
          <span class="icon-bar"></span>
          <span class="icon-bar"></span>
        </button>
        <a class="navbar-brand" href="http://atintranet/default.aspx"><class="auto-style1">Atintranet</a>
      </div>

      <!-- Collect the nav links, forms, and other content for toggling -->
      <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
        <ul class="nav navbar-nav">
         <li class="active"><a href="http://web.abbey.ie/personaldetails/">Staff Personal Details Form</a></li>
         <li><a href="http://web.abbey.ie/holiday/">Staff Weekend Requests</a></li>
         <li><a href="http://web.abbey.ie/cashadvance/">Cash Advance Form</a></li>
         <li><a href="http://web.abbey.ie/overtimeform/">Overtime Form</a></li>
       </ul>
     </li>
   </ul>
 </div><!-- /.navbar-collapse -->
</div><!-- /.container-fluid -->
</nav>
    <form id="form1" runat="server">
        <div>
            <div class="container">
  <div class="row">
   <div class="row">
    <div class="col-lg-12">
     <div id="content">
      <h1>Staff Weekend Requests</h1>

      <h3>Please select your Office location</h3>
      <hr />
         <asp:DropDownList ID="DropDownList1" runat="server" cssclass="form-control">
             <asp:ListItem>Please select....</asp:ListItem>
             <asp:ListItem>United Kingdom</asp:ListItem>
             <asp:ListItem>Ireland</asp:ListItem>
         </asp:DropDownList>
         <asp:LinkButton ID="Button1" CssClass="btn btn-default btn-lg" runat="server" OnClick="Button1_Click">Submit</asp:LinkButton>
    </div>

  </div>
</div>

</div>	
</div>
        </div>
    </form>
</body>
</html>
