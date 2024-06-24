<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sign up.aspx.cs" Inherits="Champions_league.sign_up" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>sign up</title>
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

#middleRectangle1 {
    background-color: midnightblue;
    height: 800px;
    width: 600px;
    position: absolute;
    top: 8%;
    left: 35%;
    z-index: 0;
    border-radius: 30px;
    border:solid;
    border-color: black;
    filter: drop-shadow(0 0 10px);
}


p {
    color: ghostwhite;
    font-family: Georgia;
}
#title {
    font-size: 45px;
    color: ghostwhite;
    font-family: Georgia;
    z-index: 1;
    position: absolute;
    top: 2%;
    left: 33%;
}
.textBox{
    border-radius: 12px;
    margin-bottom: 3px;
    width: 410px;
    height: 35px;
    background-color: transparent;
    font-size: 17px;
    font-family: Georgia;
    border-color: white;
}
.inputFields {
    display: flex;
    flex-direction: column;
    position: absolute;
    top: 16%;
    left: 16%;
    font-family: Georgia;
}
.radioButtonList {
    color: ghostwhite;
    font-family: Georgia;
}

.submitButton{
        border-color: black;
        border-radius: 9px;
        background-color: transparent;
        color: ghostwhite;
        font-family: Georgia;
        font-size: 15px;
        margin-left: 124px;
        margin-top: 80px;
        transition: transform .1s ease;
        background-color: black;
}
.submitButton:hover{
    cursor: pointer;
    transform: scale(1.3);
}
.term{
    font-family: Georgia;
    color: ghostwhite;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <div>
      <asp:Label ID="errorMessage" runat="server" Width="400px" Height="23px" style="margin-top: 25px; font-family: Courier New, Courier, monospace; font-size: 20px"></asp:Label>
      <div id="middleRectangle1">
          <h1 id="title">sign up</h1>
<div class="inputFields">
  <div>
      <p>first name:</p>
      <asp:TextBox runat="server" CssClass="textBox" ID="firstName"></asp:TextBox>
  </div>

  <div>
      <p>last name:</p>
      <asp:TextBox runat="server" CssClass="textBox" ID="lastName"></asp:TextBox>
  </div>

  <div>
      <p>username:</p>
      <asp:TextBox runat="server" CssClass="textBox" ID="userName"></asp:TextBox>
  </div>

  <div>
      <p>password:</p>
      <asp:TextBox runat="server" CssClass="textBox" ID="password"></asp:TextBox>
  </div>

  <div>
      <p>sex:</p>
      <asp:RadioButtonList ID="sexChoise" CssClass="radioButtonList" runat="server">
          <asp:ListItem>male</asp:ListItem>
          <asp:ListItem>female</asp:ListItem>
      </asp:RadioButtonList>
  </div>
    <asp:CheckBox ID="notRobot" CssClass="term" runat="server" Text="i am not a robot"/>
    <asp:CheckBox ID="termsOfConditions" CssClass="term" runat="server" Text="i agree to the terms of conditions"/>
  <asp:Button runat="server" Text="submit" OnClick="submit" CssClass="submitButton" ID="submitButton" Height="31px" Width="165px"/>
  </div>
        </div>
                  </div>
  </div>
    </form>
</body>
</html>
