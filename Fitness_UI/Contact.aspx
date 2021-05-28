<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Fitness_UI.Contact" %>

<<!DOCTYPE html>
<html>
<head runat="server">
    <title>Contact</title>
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
    <form id="formContact" runat="server">

        <!-- Navbar -->
        <div class="w3-top">
            <div class="w3-bar w3-theme-d2 w3-left-align">
                <a class="w3-bar-item w3-button w3-hide-medium w3-hide-large w3-right w3-hover-white w3-theme-d2" href="javascript:void(0);" onclick="openNav()"><i class="fa fa-bars"></i></a>
                <a href="Home.aspx" class="w3-bar-item w3-button w3-teal"><i class="fa fa-home w3-margin-right"></i>Home</a>
                <a href="ReservatieWebsite.aspx" class="w3-bar-item w3-button w3-hide-small w3-hover-white">Reservatie</a>
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
                <a href="#" class="w3-bar-item w3-button w3-hide-small w3-right w3-hover-teal">rtalsmove</a>
            </div>

            <!-- Navbar klein scherm -->
            <div id="navDemo" class="w3-bar-block w3-theme-d2 w3-hide w3-hide-large w3-hide-medium">
                <a href="Home.aspx" class="w3-bar-item w3-button">Home</a>
                <a href="ReservatieWebsite.aspx" class="w3-bar-item w3-button">Reservatie</a>
                <a href="Fitness.aspx" class="w3-bar-item w3-button">Fitness</a>
                <a href="GroupTraining.aspx" class="w3-bar-item w3-button">Group training</a>
                <a href="SmallGroupTraining.aspx" class="w3-bar-item w3-button">Small group training</a>
                <a href="PersonalTraining.aspx" class="w3-bar-item w3-button">Personal training</a>
                <a href="Contact.aspx" class="w3-bar-item w3-button">Contact</a>
            </div>
        </div>

        <!-- Contact gedeelte -->
        <div class="w3-container w3-padding-64 w3-theme-l5" id="contact">
            <div class="w3-third">
                <div class="w3-padding-16"><span class="w3-xlarge w3-border-teal w3-bottombar">Contact</span></div>
                <h3>Adres, Telefoonnummer & Emailadres</h3>
                <p>Kom langs voor fitness, groepslessen, personaltraining of voor iets te drinken in onze cafetaria.</p>
                <p><i class="fa fa-map-marker w3-text-teal w3-xlarge"></i>Herentals, Lierseweg 230</p>
                <p><i class="fa fa-phone w3-text-teal w3-xlarge"></i>0468/00 19 11</p>
                <p><i class="fa fa-fax w3-text-teal w3-xlarge"></i>014/89 84 68</p>
                <p><i class="fa fa-envelope-o w3-text-teal w3-xlarge"></i>info@rtalsmove.be</p>
            </div>
            <div class="w3-twothird w3-center">
                <asp:Image ID="imgGebouwRtalsmove" runat="server" ImageUrl="Images/gebouwRtalsmove.PNG" Style="min-height: 100px; max-height: 300px;" />
            </div>
        </div>

        <!-- Image van locatie -->
        <div class="w3-center">
            <asp:Image ID="imgLocatieRtalsmove" runat="server" ImageUrl="Images/locateRtalsmove.PNG" Style="min-height: 300px; max-height: 550px;" />
        </div>
        <!-- Footer -->
        <footer class="w3-container w3-padding-32 w3-theme-d1 w3-center">
            <h4>Volg ons op sociale media!</h4>
            <a class="w3-button w3-large w3-teal" href="https://www.facebook.com/rtalsmove/" title="Facebook"><i class="fa fa-facebook"></i></a>
            <a class="w3-button w3-large w3-teal" href="https://www.instagram.com/rtalsmove/" title="Google +"><i class="fa fa-instagram"></i></a>

            <div style="position: relative; bottom: 100px; z-index: 1;" class="w3-tooltip w3-right">
                <span class="w3-text w3-padding w3-teal w3-hide-small">Go To Top</span>
                <a class="w3-button w3-theme" href="#myPage"><span class="w3-xlarge">
                    <i class="fa fa-chevron-circle-up"></i></span></a>
            </div>
        </footer>
    </form>
    <script>
        // Script for side navigation
        function w3_open() {
            var x = document.getElementById("mySidebar");
            x.style.width = "300px";
            x.style.paddingTop = "10%";
            x.style.display = "block";
        }

        // Close side navigation
        function w3_close() {
            document.getElementById("mySidebar").style.display = "none";
        }

        // Used to toggle the menu on smaller screens when clicking on the menu button
        function openNav() {
            var x = document.getElementById("navDemo");
            if (x.className.indexOf("w3-show") == -1) {
                x.className += " w3-show";
            } else {
                x.className = x.className.replace(" w3-show", "");
            }
        }
    </script>
</body>
</html>
