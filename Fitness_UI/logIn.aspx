<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="logIn.aspx.cs" Inherits="Fitness_UI.logIn" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Log In</title>

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
    background-image: url(Images/LogInImage.jpg);
    background-repeat: no-repeat;
    background-position: center;
    background-size: cover;
}
</style>
</head>
<body>
    <%-- Login gedeelte --%>
    <form id="formLogIn" runat="server">
        <div class="w3-container" style="padding:128px 16px">
            <div class="layoutSignInUp">
                <asp:Label ID="lblEmailadres" runat="server" Text="Emailadres" Width="215px" ForeColor="White"></asp:Label>
                <asp:TextBox ID="txtEmailadres" runat="server" Required Width="215px" BackColor="Transparent" BorderColor="White" BorderWidth="1px" Font-Size="Medium" ForeColor="White"></asp:TextBox><br />
                <br />
                <asp:Label ID="lblPaswoord" runat="server" Text="Paswoord" Width="215px" ForeColor="White"></asp:Label>
                <asp:TextBox ID="txtPaswoord" runat="server" Required TextMode="Password" Width="215px" BackColor="Transparent" BorderColor="White" BorderWidth="1px" Font-Size="Medium" ForeColor="White"></asp:TextBox><br />
                <br />
                <asp:Button ID="btnLogIn" runat="server" Text="Log in" BackColor="Teal" ForeColor="White" Width="430px" OnClick="btnLogIn_Click" Font-Size="Medium"/>
                <br />
                <a href="Aanmeld.aspx" class="w3-hover-text-blue">Nog niet aangemeld? Meld je hier aan!</a>
            </div>
        </div>
    </form>
</body>
</html>
