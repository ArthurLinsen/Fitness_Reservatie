﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservatieAanbod.aspx.cs" Inherits="Fitness_UI.ReservatieAanbod" %>

<!DOCTYPE html>
<html>
<head runat="server">
<title>Reservatie aanbod</title>
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

<style>
body {
    background-image: url();
    background-repeat: no-repeat;
    background-position: center;
    background-size: cover;
}
</style>
</head>
<body>
<form id="formReservatieAanbod" runat="server">

<!-- Navbar -->
    <div class="w3-top">
        <div class="w3-bar w3-theme-d2 w3-left-align">
            <a class="w3-bar-item w3-button w3-hide-medium w3-hide-large w3-right w3-hover-white w3-theme-d2" href="javascript:void(0);" onclick="openNav()"><i class="fa fa-bars"></i></a>
            <a href="Home.aspx" class="w3-bar-item w3-button w3-teal"><i class="fa fa-home w3-margin-right"></i>Home</a>
            <a href="ReservatieAanbod.aspx" class="w3-bar-item w3-button w3-hide-small w3-hover-white">Reserveer</a>   
        </div>

<!-- Navbar klein scherm -->
  <div id="navDemo" class="w3-bar-block w3-theme-d2 w3-hide w3-hide-large w3-hide-medium">
    <a href="Home.aspx" class="w3-bar-item w3-button">Home</a>
    <a href="ReservatieAanbod.aspx" class="w3-bar-item w3-button">Reserveer</a>  
  </div>
</div>

<%-- Reservatie account gedeelte --%>
<div>
    <h2>Welkom beste fitnesser</h2>
     <p>Hieronder kan u reserveren voor de les die u verkiest.</p>
</div>

<%-- Reservatie type les gedeelte --%>
<div>
    <h3>Kies uw soort les:</h3>
    <asp:RadioButtonList ID="rbtnSoortLes" runat="server"></asp:RadioButtonList>
    <br />
    <asp:Button ID="btnKiesLes" runat="server" Text="Kies soort les" OnClick="btnKiesLes_Click" />
    <br />
    <h3>Kiess u datum en tijdstip:</h3>
    <asp:RadioButtonList ID="rbtnDatum" runat="server"></asp:RadioButtonList>
    <br />
    <asp:RadioButtonList ID="rbtnTijd" runat="server"></asp:RadioButtonList>
    <br />
    <asp:Button ID="btnReserveer" runat="server" Text="Reserveer" OnClick="btnReserveer_Click" />
</div>
</form>
</body>
</html>
