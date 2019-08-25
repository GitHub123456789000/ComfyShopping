<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home_Main.aspx.cs" Inherits="FullWebSite.Home_Main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
  </ol>

  <div class="carousel-inner "style="max-width:100%; max-height:200px !important;">
    <div class="carousel-item active top ">
      <img class="d-block  w-100   " src="img/Home_slide2.png" alt="First slide">
      <div class="carousel-caption d-none d-md-block">
    
      </div>
    </div>
    <div class="carousel-item  ">
      <img class="d-block  w-100   " src="img/Home_slide1.png" alt="Second slide">
      <div class="carousel-caption d-none d-md-block">
     
      </div>
    </div>
    
  </div>
  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon2" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
    <span class="carousel-control-next-icon1" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>


<div class="container-fluid offer pt-3 pb-1 bg-gold d-none d-md-block">
	<div class="container">
		<div class="row text-white">
			<div class="col-md-4  ">
				<h4>FREE SHIPPING</h4>
				<p>on order over 90£</p>
			</div>
			<div class="col-md-4 ">
				<h4>CALL US ANYTIME</h4>
				<p>07538415895</p>
			</div>
			<div class="col-md-4">
				<h4>OUR  LOCATION</h4>
				<p>Birmingham</p>
			</div>
		</div>
	</div>
</div>  
    <div class="container mt-5">
	<div class="row">
		<h4>FROM THE  BLOG</h4>
	</div>
	<div class="row">
		<div class="underline"></div>
	</div>
</div>

<div class="container pb-5 blog">
	<div class="row">
		<div class="col-md-6">
			<div class="media mt-5">
				<img src="img/b1.jpg" class="img-fluid mr-3" alt="media1">
				<div class="media-body">
					<h5>Winter Jackets For The Soul... </h5>
					
				
				</div>
			</div>
		</div>
		
		<div class="col-md-6">
			<div class="media mt-5">
				<img src="img/b2.jpg" class="img-fluid mr-3" alt="media1">
				<div class="media-body">
					<h5>Long Legs? No Longer And...</h5>
					
					
				</div>
			</div>
		</div>
	</div>
	
	
	<div class="row">
		<div class="col-md-6">
			<div class="media mt-5">
				<img src="img/b3.jpg" class="img-fluid mr-3" alt="media1">
				<div class="media-body">
					<h5>Cotton Collecton For Autumn Are…</h5>
					<p>Welcome to the biggest trends of the new autumn/winter 2019 season.</p>
					
				</div>
			</div>
		</div>
		
		<div class="col-md-6">
			<div class="media mt-5">
				<img src="img/b4.jpg" class="img-fluid mr-3" alt="media1">
				<div class="media-body">
					<h5>Latest Trends For Autumn Are…</h5>
					<p> Welcome to the biggest trends of the new autumn/winter 2019 season.
</p>
				
				</div>
			</div>
		</div>
	</div>
</div>





</asp:Content>
