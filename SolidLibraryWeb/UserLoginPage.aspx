<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserLoginPage.aspx.cs" Inherits="UserLoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label style="  margin-left: 550px; " ID="Heading" runat="server" Text="Wellcome"></asp:Label>

            <table style="width: 50%;    margin-left: 400px; ">
                <tr>
                    <td> <asp:Label ID="LabelUserName" runat="server" Text="Enter The User Name"></asp:Label></td>
                    <td> <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td> &nbsp;</td>
                    <td> <asp:Button ID="LoginSubmit" runat="server" Text="Login" OnClick="LoginSubmit_Click" /></td>
                   
                   
                </tr>
                
            </table>
        </div>
    </form>
</body>
</html>
