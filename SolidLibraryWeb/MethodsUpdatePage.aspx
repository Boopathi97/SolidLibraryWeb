<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MethodsUpdatePage.aspx.cs" Inherits="MethodsUpdatePage" %>

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
            <asp:Label style="  margin-left: 550px; " ID="Heading" runat="server" Text="Add Your Project"></asp:Label>

            <table style="width: 50%;    margin-left: 400px; ">
                <tr>
                    <td>MethodId</td>
                    <td><asp:Label ID="LebelMethodId" runat="server" Text=""></asp:Label></td>
                    
                </tr>
                <tr>
                    <td> <asp:Label ID="LabelMethodName" runat="server" Text="Enter The Method Name"></asp:Label></td>
                    <td> <asp:TextBox ID="TextBoxMethodName" runat="server"></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td> <asp:Label ID="LabelMethodScope" runat="server" Text="Select Method Scope"></asp:Label></td>
                    <td> <asp:DropDownList ID="DropDownListMethodScope" runat="server" OnSelectedIndexChanged="DropDownListMethodScope_SelectedIndexChanged">
                        <asp:ListItem>Public</asp:ListItem>
                        <asp:ListItem>Protected</asp:ListItem>
                        <asp:ListItem>Private</asp:ListItem>
                        <asp:ListItem>Internal</asp:ListItem>
                        <asp:ListItem>Protected Internal</asp:ListItem>
                        </asp:DropDownList></td>
                   
                </tr>
                <tr>
                    <td> <asp:Label ID="LabelMethodReturnType" runat="server" Text="Select Method Return Type"></asp:Label></td>
                    <td> <asp:DropDownList ID="DropDownListMethodReturnType" runat="server" OnSelectedIndexChanged="DropDownListMethodReturnType_SelectedIndexChanged">
                        <asp:ListItem>Int</asp:ListItem>
                        <asp:ListItem>String</asp:ListItem>
                        <asp:ListItem>Array</asp:ListItem>
                        <asp:ListItem>Object</asp:ListItem>
                        <asp:ListItem>Bool</asp:ListItem>
                        <asp:ListItem>Enum</asp:ListItem>
                        <asp:ListItem>Reference</asp:ListItem>
                        </asp:DropDownList></td>
                   
                </tr>
                 <tr>
                    <td> <asp:Label ID="LabelDescription" runat="server" Text="Enter The Method Name"></asp:Label></td>
                    <td> <asp:TextBox ID="TextBoxDescription" runat="server" Height="37px" TextMode="MultiLine" Width="204px"></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td>ClassId</td>
                    <td><asp:Label ID="ClassId" runat="server" Text=""></asp:Label></td>
                    
                </tr>
                <tr>
                    <td>Creator</td>
                    <td><asp:Label ID="MethodCreator" runat="server" Text=""></asp:Label></td>
                   
                </tr>
                 <tr>
                    <td>Created At</td>
                    <td><asp:Label ID="MethodCreatedAt" runat="server" Text=""></asp:Label></td>
                   
                </tr>
                 <tr>
                    <td>Modifier</td>
                    <td><asp:Label ID="MethodModifier" runat="server" Text=""></asp:Label></td>
                   
                </tr>
                 <tr>
                    <td>Modified At</td>
                    <td><asp:Label ID="MethodModifiedAt" runat="server" Text=""></asp:Label></td>
                   
                </tr>
                <tr>
                    <td> &nbsp;</td>
                    <td> <asp:Button ID="UpdateMethodSubmit" runat="server" Text="UpdateMethod" OnClick="UpdateMethodSubmit_Click" /></td>
                   
                   
                </tr>
                
            </table>
        </div> <br /><br /><br />
    </form>
</body>
</html>
