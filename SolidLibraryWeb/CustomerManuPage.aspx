<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManuPage.aspx.cs" Inherits="CustomerManuPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
             <asp:Label style="  margin-left: 550px; " ID="Label2" runat="server" Text="User Information"></asp:Label>
             <table style="width:50%; margin-left: 400px;">
                <tr>
                    <td> <asp:Label ID="LUserName" runat="server" Text="User Name"></asp:Label></td>
                    <td> <asp:Label ID="IdUserName" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td> <asp:Label ID="LUserId" runat="server" Text="User Id"></asp:Label></td>
                    <td> <asp:Label ID="IdUserId" runat="server" Text=""></asp:Label></td>
                </tr>
         </table>
        </div>
        <br /><br /><br />
        <div>
             <asp:Label style="  margin-left: 550px; " ID="Heading" runat="server" Text="Choose Your Action"></asp:Label>
            <table style="width: 50%;    margin-left: 400px;">
                <tr>
                    <td>  <asp:Button ID="IdCustomertView" runat="server" Text="View Customer" OnClick="IdCustomertView_Click" /></td>
                </tr>
                <tr>
                     <td>  <asp:Button ID="IdCustomerAdd" runat="server" Text="Add Customer" OnClick="IdCustomerAdd_Click" /></td>
                </tr>
                <%--<tr>
                     <td>  <asp:Button ID="IdClass" runat="server" Text="Class" /></td>
                </tr>
                <tr>
                     <td>  <asp:Button ID="IdMethodsq" runat="server" Text="Methodsq" /></td>
                </tr>
                <tr>
                      <td>  <asp:Button ID="IdParameters" runat="server" Text="Parameters" /></td>
                </tr>--%>
               
            </table>
        </div>
    </form>
</body>
</html>
