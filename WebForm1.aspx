<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="holidayRedesign.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Personal Details</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/app.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Lato" rel="stylesheet">
    <style type="text/css">
        .auto-style1 {
            width: 104px;
            height: 49px;
        }
    </style>
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
                <a class="navbar-brand" href="http://atintranet/default.aspx">Atintranet</a>
            </div>

            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                    <li class="active"><a href="http://web.abbey.ie/personaldetails/">Staff Personal Details Form</a></li>
                    <li><a href="http://web.abbey.ie/holiday/">Staff Weekend Requests</a></li>
                    <li><a href="http://web.abbey.ie/cashadvance/">Cash Advance Form</a></li>
                    <li><a href="http://web.abbey.ie/overtimeform/">Overtime Form</a></li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container-fluid -->
    </nav>


    <div class="container">
        <div class="jumbotron">
            <img alt="" class="auto-style4" src="pic/irlfooter.jpg" />
            <h3>Staff Weekend Request</h3>

        </div>
        <form runat="server" id="form1">
            <div class="form-group">
                <label id="Label1" runat="server">Full Name</label>
                <asp:TextBox ID="textbox1" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label id="Label2" runat="server">Email</label>
                <asp:TextBox ID="textbox2" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label id="Label3" runat="server">Room Type</label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                    <asp:ListItem>Please select.......</asp:ListItem>
                    <asp:ListItem>Single</asp:ListItem>
                    <asp:ListItem>Double</asp:ListItem>
                    <asp:ListItem>Twin</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label id="Label4" runat="server">Years In Abbey</label>
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control">
                    <asp:ListItem>Please select.......</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label id="Label5" runat="server">First Requested Date</label>
                <div class="row">
                    <div class="col-lg-4 col-sm-4">
                        <label>Date</label>
                        <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control">
                            <asp:ListItem>Please select.......</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                            <asp:ListItem>21</asp:ListItem>
                            <asp:ListItem>22</asp:ListItem>
                            <asp:ListItem>23</asp:ListItem>
                            <asp:ListItem>24</asp:ListItem>
                            <asp:ListItem>25</asp:ListItem>
                            <asp:ListItem>26</asp:ListItem>
                            <asp:ListItem>27</asp:ListItem>
                            <asp:ListItem>28</asp:ListItem>
                            <asp:ListItem>29</asp:ListItem>
                            <asp:ListItem>30</asp:ListItem>
                            <asp:ListItem>31</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="col-lg-4 col-sm-4">
                        <label>Month</label>
                        <asp:DropDownList ID="DropDownList4" runat="server" CssClass="form-control">
                            <asp:ListItem>Please select.......</asp:ListItem>
                            <asp:ListItem>January</asp:ListItem>
                            <asp:ListItem>February</asp:ListItem>
                            <asp:ListItem>March</asp:ListItem>
                            <asp:ListItem>April</asp:ListItem>
                            <asp:ListItem>May</asp:ListItem>
                            <asp:ListItem>June</asp:ListItem>
                            <asp:ListItem>July</asp:ListItem>
                            <asp:ListItem>August</asp:ListItem>
                            <asp:ListItem>September</asp:ListItem>
                            <asp:ListItem>October</asp:ListItem>
                            <asp:ListItem>November</asp:ListItem>
                            <asp:ListItem>December</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="col-lg-4 col-sm-4">
                        <label>Year</label>
                        <asp:DropDownList ID="DropDownList5" runat="server" CssClass="form-control">
                            <asp:ListItem>Please select.......</asp:ListItem>
                            <asp:ListItem>2017</asp:ListItem>
                            <asp:ListItem>2018</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <label id="Label6" runat="server">Comments</label>
                <asp:TextBox ID="textbox3" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label id="Label7" runat="server">Location</label>
                <asp:TextBox ID="textbox4" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div></div>

            <div class="form-group">
                <label id="Label8" runat="server">Second Choice</label>
                <div class="row">
                    <div class="col-lg-4 col-sm-4">
                        <label>Date</label>
                        <asp:DropDownList ID="DropDownList6" runat="server" CssClass="form-control">
                            <asp:ListItem>Please select.......</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                            <asp:ListItem>21</asp:ListItem>
                            <asp:ListItem>22</asp:ListItem>
                            <asp:ListItem>23</asp:ListItem>
                            <asp:ListItem>24</asp:ListItem>
                            <asp:ListItem>25</asp:ListItem>
                            <asp:ListItem>26</asp:ListItem>
                            <asp:ListItem>27</asp:ListItem>
                            <asp:ListItem>28</asp:ListItem>
                            <asp:ListItem>29</asp:ListItem>
                            <asp:ListItem>30</asp:ListItem>
                            <asp:ListItem>31</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="col-lg-4 col-sm-4">
                        <label>Month</label>
                        <asp:DropDownList ID="DropDownList7" runat="server" CssClass="form-control">
                            <asp:ListItem>Please select.......</asp:ListItem>
                            <asp:ListItem>January</asp:ListItem>
                            <asp:ListItem>February</asp:ListItem>
                            <asp:ListItem>March</asp:ListItem>
                            <asp:ListItem>April</asp:ListItem>
                            <asp:ListItem>May</asp:ListItem>
                            <asp:ListItem>June</asp:ListItem>
                            <asp:ListItem>July</asp:ListItem>
                            <asp:ListItem>August</asp:ListItem>
                            <asp:ListItem>September</asp:ListItem>
                            <asp:ListItem>October</asp:ListItem>
                            <asp:ListItem>November</asp:ListItem>
                            <asp:ListItem>December</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="col-lg-4 col-sm-4">
                        <label>Year</label>
                        <asp:DropDownList ID="DropDownList8" runat="server" CssClass="form-control">
                            <asp:ListItem>Please select.......</asp:ListItem>
                            <asp:ListItem>2017</asp:ListItem>
                            <asp:ListItem>2018</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <label id="Label9" runat="server">Comments</label>
                <asp:TextBox ID="textbox6" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label id="Label10" runat="server">Location</label>
                <asp:TextBox ID="textbox7" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Department</label>
                <asp:DropDownList ID="DropDownList9" runat="server" CssClass="form-control">
                    <asp:ListItem>Please select.......</asp:ListItem>
                    <asp:ListItem>Conference</asp:ListItem>
                    <asp:ListItem>Info Systems</asp:ListItem>
                    <asp:ListItem>HR</asp:ListItem>
                    <asp:ListItem>Accounts</asp:ListItem>
                    <asp:ListItem>International</asp:ListItem>
                    <asp:ListItem>German</asp:ListItem>
                    <asp:ListItem>Accommodation</asp:ListItem>
                    <asp:ListItem>Operations</asp:ListItem>
                    <asp:ListItem>Nordics</asp:ListItem>
                    <asp:ListItem>French(Caroline)</asp:ListItem>
                    <asp:ListItem>French(Aurelie)</asp:ListItem>
                    <asp:ListItem>French(Carene)</asp:ListItem>
                    <asp:ListItem>French(Teresa)</asp:ListItem>
                    <asp:ListItem>Contracting</asp:ListItem>
                    <asp:ListItem>FIT</asp:ListItem>
                    <asp:ListItem>Meds</asp:ListItem>
                    <asp:ListItem>Moloney</asp:ListItem>
                    <asp:ListItem>Product</asp:ListItem>

                    <asp:ListItem>Operations Director</asp:ListItem>

                    <asp:ListItem>WMOF</asp:ListItem>

                </asp:DropDownList>
            </div>

            <div class="form-group">
                <asp:LinkButton ID="Button1" CssClass="btn btn-default btn-lg" runat="server" OnClick="Button1_Click">Submit</asp:LinkButton>
            </div>
        </form>
    </div>
      <script
        src="https://code.jquery.com/jquery-3.2.1.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

</body>
</html>
