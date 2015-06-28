<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">

<!-- Optional theme -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css">

<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
<link rel="stylesheet" type="text/css" href="css/bootstrap-theme.min.css">
<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
<script type="text/javascript" src = "js/bootstrap.min.js"></script>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Final Database Project</title>
</head>
<body>
    <form id="form1" runat="server">
<div class="container mb">
	<div class="row">
		<div class="col-md-12">
			 <nav class="navbar navbar-static-top navbar-inverse mb">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="http://localhost">Super Video</a>
            </div>
            <div id="navbar" class="collapse navbar-collapse">
                <ul class="nav navbar-nav">
                    <li class="active"><a href="/">Home</a></li>
                   
                </ul>
            </div>
        </div>
    </nav>

			<br><br>
			<div class="jumbotron">
				<h1>
					資料庫期末專題-Super Video
				</h1>
				<h3>
				 	可以選取歌手的名子並選取其歌曲影片播放
				</h3>
				<p>
				<div class="col-md-3">
				<select class="btn btn-default mbutton mbutton-lg form-control" id="pl-select">
                <option>Lady Gaga</option>
                <option>Bruno Mars</option>
                <option>Maroon5</option>
              
           		</select>
           		</div>
				<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Visible="False">
                </asp:DropDownList>
				</p>
			</div>
		</div>
		<br>
			<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:s1021704ConnectionString %>" SelectCommand="SELECT [singer_name], [singer_id], [gender] FROM [singer]"></asp:SqlDataSource>
			<div class="col-md-8">
				<iframe width="630 " height="470" src="http://www.youtube.com/embed/qrO4YZeyl0I?autoplay=0">
    			</iframe>
			</div>
			<div class="col-md-4">
				<h2>Lady Gaga</h2> <br>
				<h3>Song name</h3>
			</div>

	</div>
</div>

	
    </form>

	
</body>
</html>
