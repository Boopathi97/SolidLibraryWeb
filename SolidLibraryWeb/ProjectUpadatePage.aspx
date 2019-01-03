<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProjectUpadatePage.aspx.cs" Inherits="ProjectUpadatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
        <div>
            <center>
            <asp:Label ID="msg" runat="server" ForeColor="#33CC33"></asp:Label></center>
            <table style="width: 100%;">
                <tr>
                    <td>ProjectId</td>
                    <td><asp:Label ID="LabelProjectId" runat="server" Text=""></asp:Label></td>
                    
                </tr>
                <tr>
                    <td>ProjectName</td>
                    <td><asp:TextBox ID="IdProjectName" runat="server" ></asp:TextBox>  </td>
                    
                </tr>
                <tr>
                    <td>Creator</td>
                    <td><asp:Label ID="ProjectCreator" runat="server" Text=""></asp:Label></td>
                   
                </tr>
                 <tr>
                    <td>Created At</td>
                    <td><asp:Label ID="ProjectCreatedAt" runat="server" Text=""></asp:Label></td>
                   
                </tr>
                 <tr>
                    <td>Modifier</td>
                    <td><asp:Label ID="ProjectModifier" runat="server" Text=""></asp:Label></td>
                   
                </tr>
                 <tr>
                    <td>Modified At</td>
                    <td><asp:Label ID="ProjectModifiedAt" runat="server" Text=""></asp:Label></td>
                   
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td> <asp:Button ID="ProjectUpdateButton" runat="server" Text="Update" OnClick="ProjectUpdateButton_Click" /> </td>
                   
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
