<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClassAddPage.aspx.cs" Inherits="ClassAddPage" %>

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
            <asp:Label style="  margin-left: 550px; " ID="Heading" runat="server" Text="Add Your Class"></asp:Label>

            <table style="width: 50%;    margin-left: 400px; ">
                <tr>
                    <td> <asp:Label ID="LabelClassName" runat="server" Text="Enter The Class Name"></asp:Label></td>
                    <td> <asp:TextBox ID="TextBoxClassName" runat="server"></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td> <asp:Label ID="SelectProjectName" runat="server" Text="Select The Project Name"></asp:Label></td>
                    <td>  <asp:DropDownList ID="DropDownListProjectName" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="DropDownListProjectName_SelectedIndexChanged" AutoPostBack="True" >
                       
                        </asp:DropDownList></td>
                   
                </tr>
                <tr>
                    <td> <asp:Label ID="SelectCustomerName" runat="server" Text="Select The Customer Name"></asp:Label></td>
                    <td>  <asp:DropDownList ID="DropDownListCustomerName" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="DropDownListCustomerName_SelectedIndexChanged" >
                       
                        </asp:DropDownList></td>
                   
                </tr>
                <tr>
                    <td> <asp:Label ID="LabelDescription" runat="server" Text="Description"></asp:Label></td>
                    <td> <asp:TextBox ID="TextBoxDescription" runat="server" MaxLength="900" Rows="3" TextMode="MultiLine"></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td> <asp:Label ID="LabelClassScope" runat="server" Text="ClassScope"></asp:Label></td>
                    <td> <asp:DropDownList ID="DDClassScope" runat="server">
                        <asp:ListItem>Choose any one</asp:ListItem>
                        <asp:ListItem>Public</asp:ListItem>
                        <asp:ListItem>Private</asp:ListItem>
                        <asp:ListItem>Protected</asp:ListItem>
                        <asp:ListItem>Internal</asp:ListItem>
                        </asp:DropDownList></td>
                   
                </tr>
                <tr>
                    <td> <asp:Label ID="LabelClassPublicVariable" runat="server" Text="ClassPublicVariable"></asp:Label></td>
                    <td> <asp:TextBox ID="TextBoxClassPublicVariable" runat="server" MaxLength="2000" Rows="5" TextMode="MultiLine"></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td> <asp:Button ID="ViewClass" runat="server" Text="View Class" OnClick="ViewClass_Click" /></td>
                    <td> <asp:Button ID="AddClassSubmit" runat="server" Text="Add Class" OnClick="AddClassSubmit_Click" /></td>
                   
                   
                </tr>
                
            </table>
        </div> <br /><br /><br />
    </form>
</body>
</html>
