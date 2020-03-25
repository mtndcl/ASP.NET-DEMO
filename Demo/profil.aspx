<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profil.aspx.cs" Inherits="Demo.profil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    
</head>
<body>
    <form id="form1" runat="server">
      <div>
           <p> Your Message : <asp:TextBox ID="message" runat="server" OnTextChanged="message_TextChanged"></asp:TextBox></p> 
           
             <p>  <asp:Button ID="sendbutton" runat="server" Text="Get All User" OnClick="sendbutton_Click"  UseSubmitBehavior="false"/></p> 
          <p>    <asp:GridView ID="info" runat="server" >
            </asp:GridView></p> 
           
            <asp:Button ID="logout" runat="server" Text="Logout" OnClick="logout_Click"  UseSubmitBehavior="false"/>

            
        </div>
    </form>
</body>
</html>



