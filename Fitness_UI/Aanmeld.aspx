<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aanmeld.aspx.cs" Inherits="Fitness_UI.Aanmeld" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Aanmelding</title>

<meta charset="UTF-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
<link rel="stylesheet" href="https://www.w3schools.com/lib/w3-theme-black.css"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="ExtraLayout.css" />

<style>
body {
    background-image: url(Images/AanmeldImage.jpg);
    background-repeat: no-repeat;
    background-position: center;
    background-size: cover;
}
</style>
</head>
<body>
    <%-- Aanmeld gedeelte --%>
    <form id="formAanmeld" runat="server">
        <div class="w3-container" style$="padding:128px 16px">
            <div class="layoutSignInUp">
                <asp:Label ID="lblFamilienaam" runat="server" Text="Familienaam" Width="215px" ForeColor="White"></asp:Label>
                <asp:TextBox ID="txtfamilienaam" runat="server" BackColor="Transparent" BorderColor="White" BorderWidth="1px" Font-Size="Medium" ForeColor="White"></asp:TextBox><br />
                <br />
                <asp:Label ID="lblVoornaam" runat="server" Text="Voornaam" Width="215px" ForeColor="White"></asp:Label>
                <asp:TextBox ID="txtVoornaam" runat="server" BackColor="Transparent" BorderColor="White" BorderWidth="1px" Font-Size="Medium" ForeColor="White"></asp:TextBox><br />
                <br />
                <asp:Label ID="lblGeboortedatum" runat="server" Text="Geboortedatum" Width="215px" ForeColor="White"></asp:Label>
                <asp:TextBox ID="txtGeboortedatum" runat="server"  TextMode="DateTimeLocal"  placeholder="01-01-2000" BackColor="Transparent" BorderColor="White" BorderWidth="1px" Font-Size="Medium" ForeColor="White"></asp:TextBox><br />
                <br />
                <asp:Label ID="lblAdres" runat="server" Text="Adres" Width="215px" ForeColor="White"></asp:Label>
                <asp:TextBox ID="txtAdres" runat="server" BackColor="Transparent" BorderColor="White" BorderWidth="1px" Font-Size="Medium" ForeColor="White"></asp:TextBox><br />
                <br />
                <asp:Label ID="lblPostcode" runat="server" Text="Postcode" Width="215px" ForeColor="White"></asp:Label>
                <asp:TextBox ID="txtPostcode" runat="server" BackColor="Transparent" BorderColor="White" BorderWidth="1px" Font-Size="Medium" ForeColor="White"></asp:TextBox><br />
                <br />
                <asp:Label ID="lblGemeente" runat="server" Text="Gemeente" Width="215px" ForeColor="White"></asp:Label>
                <asp:TextBox ID="txtGemeente" runat="server" BackColor="Transparent" BorderColor="White" BorderWidth="1px" Font-Size="Medium" ForeColor="White"></asp:TextBox><br />
                <br />
                <asp:Label ID="lblTelefoonnummer" runat="server" Text="Telefoonnummer" Width="215px" ForeColor="White"></asp:Label>
                <asp:TextBox ID="txtTelefoonnummer" runat="server" BackColor="Transparent" BorderColor="White" BorderWidth="1px" Font-Size="Medium" ForeColor="White"></asp:TextBox><br />
                <br />
                <asp:Label ID="lblEmailadres" runat="server" Text="Emailadres" Width="215px" ForeColor="White"></asp:Label>
                <asp:TextBox ID="txtEmailadres" runat="server" BackColor="Transparent" BorderColor="White" BorderWidth="1px" Font-Size="Medium" ForeColor="White"></asp:TextBox><br />
                <br />
                <asp:Label ID="lblRijksregisternummer" runat="server" Text="Rijksregisternummer" Width="215px" ForeColor="White"></asp:Label>
                <asp:TextBox ID="txtRijksregisternummer" runat="server" BackColor="Transparent" BorderColor="White" BorderWidth="1px" Font-Size="Medium" ForeColor="White"></asp:TextBox><br />
                <br />
                <asp:Button ID="btnMeldAan" runat="server" Text="Word Lid" BackColor="Teal" ForeColor="White" Width="430px" OnClick="btnMeldAan_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
