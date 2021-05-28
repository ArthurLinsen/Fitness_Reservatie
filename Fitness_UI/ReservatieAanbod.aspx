<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservatieAanbod.aspx.cs" Inherits="Fitness_UI.ReservatieAanbod" %>

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
            background-image: url(Images/ReservatieImage.jpg);
            background-repeat: no-repeat;
            background-position: center;
            background-size: cover;
        }
        h3 {
            color: white;
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
                <a href="#" class="w3-bar-item w3-button w3-hide-small w3-right w3-hover-teal">rtalsmove</a>
            </div>

            <!-- Navbar klein scherm -->
            <div id="navDemo" class="w3-bar-block w3-theme-d2 w3-hide w3-hide-large w3-hide-medium">
                <a href="Home.aspx" class="w3-bar-item w3-button">Home</a>
                <a href="ReservatieAanbod.aspx" class="w3-bar-item w3-button">Reserveer</a>
            </div>
        </div>

        <%-- Reservatie type les gedeelte --%>
        <div class="w3-container" style="padding:128px 16px">
            <div class="layoutReservatie">
                <h3>Kies de soort les</h3>
                <asp:RadioButtonList ID="rbtnSoortLes" runat="server" ForeColor="White"></asp:RadioButtonList>
                <br />
                <asp:Button ID="btnGekozenLes" runat="server" Text="Kies deze les" BackColor="Teal" ForeColor="White" Width="300px" OnClick="btnGekozenLes_Click" />
                <br />
                <h3>Kies de datum</h3>
                <asp:RadioButtonList ID="rbtnDatum" runat="server" ForeColor="White"></asp:RadioButtonList>
                <br />
                <asp:Button ID="btnGekozenDatum" runat="server" Text="Kies deze datum" BackColor="Teal" ForeColor="White" Width="300px" OnClick="btnGekozenDatum_Click" />
                <br />
                <h3>Kies het tijdstip</h3>
                <br />
                <asp:RadioButtonList ID="rbtnTijd" runat="server" ForeColor="White" TextAlign="Right"></asp:RadioButtonList>
                <br />
                <asp:Button ID="btnReserveer" runat="server" Text="Reserveer" BackColor="Teal" ForeColor="White" Width="300px" OnClick="btnReserveer_Click" />
            </div>
        </div>
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
