<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SmallGroupTraining.aspx.cs" Inherits="Fitness_UI.SmallGroupTraining" %>

<!DOCTYPE html>
<html>
<head runat="server">
<title>Small group training</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://www.w3schools.com/lib/w3-theme-black.css">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="ExtraLayout.css" />
</head>
<body id="myPage">
<form id="formsmallGroupTraining" runat="server">
  
<!-- Navbar -->
<div class="w3-top">
 <div class="w3-bar w3-theme-d2 w3-left-align">
  <a class="w3-bar-item w3-button w3-hide-medium w3-hide-large w3-right w3-hover-white w3-theme-d2" href="javascript:void(0);" onclick="openNav()"><i class="fa fa-bars"></i></a>
  <a href="Home.aspx" class="w3-bar-item w3-button w3-teal"><i class="fa fa-home w3-margin-right"></i>Home</a>
  <a href="Reservatie.aspx" class="w3-bar-item w3-button w3-hide-small w3-hover-white">Reservatie</a>
    <div class="w3-dropdown-hover w3-hide-small">
    <button class="w3-button" title="Notifications">Aanbod <i class="fa fa-caret-down"></i></button>     
    <div class="w3-dropdown-content w3-card-4 w3-bar-block">
      <a href="Fitness.aspx" class="w3-bar-item w3-button">Fitness</a>
      <a href="GroupTraining.aspx" class="w3-bar-item w3-button">Group training</a>
      <a href="SmallGroupTraining.aspx" class="w3-bar-item w3-button">Small group training</a>
      <a href="PersonalTraining.aspx" class="w3-bar-item w3-button">Personal training</a>
    </div>
  </div>
  <a href="Contact.aspx" class="w3-bar-item w3-button w3-hide-small w3-hover-white">Contact</a>    
  <a href="#" class="w3-bar-item w3-button w3-hide-small w3-right w3-hover-teal">Account</a>
 </div>

  <!-- Navbar klein scherm -->
  <div id="navDemo" class="w3-bar-block w3-theme-d2 w3-hide w3-hide-large w3-hide-medium">
    <a href="Home.aspx" class="w3-bar-item w3-button">Home</a>
    <a href="Reservatie.aspx" class="w3-bar-item w3-button">Reservatie</a>  
    <a href="Fitness.aspx" class="w3-bar-item w3-button">Fitness</a>
    <a href="GroupTraining.aspx" class="w3-bar-item w3-button">Group training</a>
    <a href="SmallGroupTraining.aspx" class="w3-bar-item w3-button">Small group training</a>
    <a href="PersonalTraining.aspx" class="w3-bar-item w3-button">Personal training</a>
    <a href="Contact.aspx" class="w3-bar-item w3-button">Contact</a>
    <a href="#" class="w3-bar-item w3-button">Account</a>
  </div>
</div>

<!-- Image Header -->
<div class="w3-display-container w3-animate-opacity">
    <asp:Image ID="HeaderImage" runat="server" ImageUrl="Images/HeaderImage.jpg" style="width:100%;min-height:350px;max-height:800px;"/>
</div>

<!-- Fitness gedeelte -->
<div class="w3-row-padding w3-padding-64 w3-theme-l1" id="work">
    <div class="w3-twothird">
        <h2>Small Group Training</h2>
        <p><b>Wat is een Small Group training?</b> Een Small Group bestaat uit maximaal 5 personen. Door de 
            kleine groep is persoonlijke begeleiding in de training heel goed. Sporten in een kleine groep verhoogd ook de 
            motivatie. Het is mogelijk om je eigen groep te starten met bekenden of deel te nemen aan een 
            bestaande groep. Een Small Group trainingssessie duurt 30 tot 60 min. De workouts zijn  afgestemd 
            op kleine groepen en de focus ligt op conditie en functioneel trainen.</p>
        <br />
        <h3>Wat doe je in een Small Group training?</h3>
        <br />
        <asp:ListBox ID="lbxSGTGeeft" runat="server">
            <asp:ListItem>Cardio training</asp:ListItem>
            <asp:ListItem>Krachttraining</asp:ListItem>
        </asp:ListBox>
        <br />
        <p>De trainingen zijn gericht op alle spiergroepen maar ook op de lichaamshouding, flexibilieit en stabiliteit
            tijdens het trainen</p>
        <br />
        <asp:ListBox ID="lbxAssortimentSGT" runat="server">
            <asp:ListItem>Training op alle niveaus</asp:ListItem>
            <asp:ListItem>Afwisselende, persoonlijke en motiverende trainingsmethode</asp:ListItem>
            <asp:ListItem>Gegarandeerd optimaal resultaat</asp:ListItem>
            <asp:ListItem>Mogelijkheid tot buiten training</asp:ListItem>
        </asp:ListBox>
        <br />
        <h3>Voor wie is Small Group Training?</h3>
        <p>Iedereen die graag in groepsverband traint is geschikt voor Small Group Training. Maar ook degene die 
            graag de extra uitdaging heeft van een persoonlijke training. Ook voor mensen die na hun Personal 
            Training begeleiding willen blijven houden.</p>
    </div>
</div>

<!-- Footer -->
<footer class="w3-container w3-padding-32 w3-theme-d1 w3-center">
  <h4>Follow Us</h4>
  <a class="w3-button w3-large w3-teal" href="javascript:void(0)" title="Facebook"><i class="fa fa-facebook"></i></a>
  <a class="w3-button w3-large w3-teal" href="javascript:void(0)" title="Twitter"><i class="fa fa-twitter"></i></a>
  <a class="w3-button w3-large w3-teal" href="javascript:void(0)" title="Google +"><i class="fa fa-google-plus"></i></a>
  <a class="w3-button w3-large w3-teal" href="javascript:void(0)" title="Google +"><i class="fa fa-instagram"></i></a>
  <a class="w3-button w3-large w3-teal w3-hide-small" href="javascript:void(0)" title="Linkedin"><i class="fa fa-linkedin"></i></a>

  <div style="position:relative;bottom:100px;z-index:1;" class="w3-tooltip w3-right">
    <span class="w3-text w3-padding w3-teal w3-hide-small">Go To Top</span>   
    <a class="w3-button w3-theme" href="#myPage"><span class="w3-xlarge">
    <i class="fa fa-chevron-circle-up"></i></span></a>
  </div>
</footer>
</form>
</body>
</html>