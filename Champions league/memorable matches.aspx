<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="memorable matches.aspx.cs" Inherits="Champions_league.memorable_matches" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>memorable matches</title>
    <style>
                body {
            position: relative;
            margin: 0;
            padding: 0;
            height: 100vh;
            overflow: hidden;
        }

            body::before {
                content: '';
                position: absolute;
                top: -4%;
                left: -2.5%;
                width: 105%;
                height: 105%;
                background-image: url('images/הורדה (1).jpeg');
                background-size: cover;
                filter: blur(20px);
                z-index: -1;
            }

        .container{
            position: absolute;
            top: 1%;
            left: 40%;
        }
        h1{
            color: #FFF;
            font-family: Georgia;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="container">
                <h1>UEFA Champions League</h1>
                <asp:DropDownList ID="DropDownList" runat="server"></asp:DropDownList>
                <asp:Button ID="submit" runat="server" Text="search" OnClick="onSearch"/>

                <asp:Label ID="ErrorText" runat="server" Text=""></asp:Label>
                <p></p>
                <asp:PlaceHolder ID="ButtonPlaceHolder" runat="server"></asp:PlaceHolder>
            </div>

        </div>
    </form>
</body>
</html>
