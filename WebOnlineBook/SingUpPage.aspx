<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SingUpPage.aspx.cs" Inherits="SingUpPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 727px">
    <form id="form1" runat="server">
    <div style="height: 729px; font-size: xx-large; font-weight: 700">
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registration<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" style="font-size: medium" Text="Please Enter your Details"></asp:Label>
        <br />
        <br />
&nbsp;
        <asp:Label ID="LblName" runat="server" style="font-size: medium" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtName" runat="server" Width="302px"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtName" ErrorMessage="Please enter your name!" ForeColor="#666633" style="font-size: medium"></asp:RequiredFieldValidator>
        <br />
        <br />
&nbsp;
        <asp:Label ID="LblSurname" runat="server" style="font-size: medium" Text="Surname"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtSurname" runat="server" Width="304px"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtSurname" ErrorMessage="Please enter your surname!" ForeColor="#666633" style="font-size: medium"></asp:RequiredFieldValidator>
        <br />
        <br />
&nbsp;
        <asp:Label ID="Label2" runat="server" style="font-size: medium" Text="E-Mail address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtMail" runat="server" Width="303px"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtMail" ErrorMessage="Please enter your email!" ForeColor="#666633" style="font-size: medium"></asp:RequiredFieldValidator>
        <br />
&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;
        <br />
&nbsp;
        <asp:Label ID="LblPass" runat="server" style="font-size: medium" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtPass" runat="server" Width="304px" TextMode="Password"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtPass" ErrorMessage="Please enter your password!" ForeColor="#666633" style="font-size: medium"></asp:RequiredFieldValidator>
        <br />
        <br />
&nbsp;
        <asp:Label ID="Label4" runat="server" style="font-size: medium" Text="Confirm Password"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtConfirm" runat="server" Width="302px" TextMode="Password"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TxtConfirm" ErrorMessage="Please confirm your password!" ForeColor="#666633" style="font-size: medium"></asp:RequiredFieldValidator>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="msgEmail" runat="server" ForeColor="Red" style="font-size: medium" Text="Email Already Exist" Visible="False"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="msgPass" runat="server" ForeColor="Red" style="font-size: medium" Text="Password does not match" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;<asp:Button ID="BtnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Submit" Width="68px" style="height: 26px" />
&nbsp;
    
    </div>
    </form>
</body>
</html>
