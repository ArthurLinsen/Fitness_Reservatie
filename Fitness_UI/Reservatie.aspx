<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reservatie.aspx.cs" Inherits="Fitness_UI.Reservatie" %>

<!DOCTYPE html>
<html>
<head runat="server">
<title>Home</title>
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
<form id="formReservatie" runat="server">

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

<!-- SignIn/SignUp gedeelte -->
<div class="w3-row-padding w3-center w3-padding-64" id="pricing">
    <h2>Log in of meld je aan</h2>
    <p>Bij rtalsmove kan u enkel komen fitnessen wanneer u gereserveerd heeft. Als u 
        een lid bent kan u hier links onder inloggen. Indien u geen lid bent kan u 
        zichzelf aanmelden hier rechts aanmelden.</p><br>
    <div class="w3-half w3-margin-bottom">
      <ul class="w3-ul w3-border w3-hover-shadow">
        <li class="w3-theme">
          <p class="w3-xlarge">Lid</p>
        </li>
        <li class="w3-padding-16"><b>Reservatie fitness: </b> voor de fitness kan u meerder uren achter elkaar reserveren</li>
        <li class="w3-padding-16"><b>Reservatie groeples en personal training: </b> bij deze categoriën kan u enkel 1 uur per keer reserveren</li>        
        <li class="w3-theme-l5 w3-padding-24">
          <asp:Button ID="btnSingIn" class="w3-button w3-teal w3-padding-large" runat="server" Text="Sign In" OnClick="btnSingIn_Click" />
          <button class="w3-button w3-teal w3-padding-large"><i class="fa fa-check"></i> Sign in</button>
        </li>
      </ul>
    </div>

    <div class="w3-half w3-margin-bottom">
      <ul class="w3-ul w3-border w3-hover-shadow">
        <li class="w3-theme-l2">
          <p class="w3-xlarge">Geen lid</p>
        </li>
        <li class="w3-padding-16"><b>Krijg toegang tot: </b>Fitness, Group training, Small group training & Personal training</li>
        <li class="w3-padding-16"><b>Voor een prijs van: <i class="fa fa-eur"></i> 50</b> per maand</li>
        <li class="w3-theme-l5 w3-padding-24">
          <asp:Button ID="btnSignUp" class="w3-button w3-teal w3-padding-large" runat="server" Text="Sign Up" OnClick="btnSignUp_Click" />
          <button class="w3-button w3-teal w3-padding-large"><i class="fa fa-check"></i> Sign Up</button>
        </li>
      </ul>
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
