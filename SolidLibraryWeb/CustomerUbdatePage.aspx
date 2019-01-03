<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerUbdatePage.aspx.cs" Inherits="CustomerUbdatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table style="width: 100%;">
                <tr>
                    <td>CustomertId</td>
                    <td><asp:Label ID="LabelCustomerId" runat="server" Text=""></asp:Label></td>
                    
                </tr>
                <tr>
                    <td>CustomerName</td>
                    <td><asp:TextBox ID="IdCustomerName" runat="server" ></asp:TextBox>  </td>
                    
                </tr>
                  <tr>
                    <td>ProjectId</td>
                    <td><asp:Label ID="ProjectId" runat="server" Text=""></asp:Label></td>
                    
                </tr>
                <tr>
                    <td>Creator</td>
                    <td><asp:Label ID="CustomerCreator" runat="server" Text=""></asp:Label></td>
                   
                </tr>
                 <tr>
                    <td>Created At</td>
                    <td><asp:Label ID="CustomerCreatedAt" runat="server" Text=""></asp:Label></td>
                   
                </tr>
                 <tr>
                    <td>Modifier</td>
                    <td><asp:Label ID="CustomerModifier" runat="server" Text=""></asp:Label></td>
                   
                </tr>
                 <tr>
                    <td>Modified At</td>
                    <td><asp:Label ID="CustomerModifiedAt" runat="server" Text=""></asp:Label></td>
                   
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td> <asp:Button ID="CustomerUpdateButton" runat="server" Text="Update" OnClick="CustomerUpdateButton_Click" /> </td>
                   
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
