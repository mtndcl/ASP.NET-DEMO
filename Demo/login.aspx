<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Demo.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

 <link href="Stylesheet.css" rel="stylesheet" type="text/css" />
<head runat="server">
    
    <title>

    </title>

   
</head>
<body>
    <div class="container">
        <div class="center">
            <form id="form1" runat="server">
                <div>

                    <p>
                        Username : <asp:TextBox ID="username" runat="server"  Text="mtndcl"></asp:TextBox>
                    </p>
            
                     <p>
                        Password :    <asp:TextBox ID="password" runat="server"  TextMode="Password" Text="7Miyemedimi"></asp:TextBox>
                    </p>
                     <p>
                        <asp:Button ID="login_Button" runat="server" Text="Login" OnClick="login_Button_Click" />
                    </p>
                    <p>
                        <asp:Label ID="warning_label" runat="server" Text=""></asp:Label>
                    </p>
                </div>
            </form>
          </div>
    </div>

</body>
</html>
