<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="invisible_recaptcha_webforms._default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Invisible Recaptcha in Web Forms</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnLogin" Style="display: none;" runat="server" OnClick="btnLogin_Click" />
        <button class="g-recaptcha" data-sitekey="6LeIxAcTAAAAAJcZVRqyHh71UMIEGNQ_MXjiZKhI" data-callback="Login">Login</button>
        <br />
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </form>
    <script>
        function Login() {
            $("#<%= btnLogin.ClientID %>").click();
        }
    </script>
    <script async="" defer="" src="https://www.google.com/recaptcha/api.js"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
</body>
</html>
