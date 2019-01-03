<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProjectAddPage.aspx.cs" Inherits="ProjectAdd" %>

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
                    <td> <asp:Label ID="LabelPorjctName" runat="server" Text="Enter The Project Name"></asp:Label></td>
                    <td> <asp:TextBox ID="TextBoxProjectName" runat="server"></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td> &nbsp;</td>
                    <td> <asp:Button ID="AddProjectSubmit" runat="server" Text="Add Project" OnClick="AddProjectSubmit_Click" /></td>
                   
                   
                </tr>
                
            </table>
        </div> <br /><br /><br />
        <div>
             <asp:Label style="  margin-left: 550px; " ID="Label1" runat="server" Text="User Information"></asp:Label>
          <table style="width:50%; margin-left: 400px;">
            <tr>
               
                <td> <asp:Label ID="LprojectId" runat="server" Text="Project Id"></asp:Label></td>
                <td> <asp:Label ID="IdProjectId" runat="server" Text=""></asp:Label></td>
               
            </tr>
            <tr>
               <td> <asp:Label ID="LprojectName" runat="server" Text="Project Name"></asp:Label></td>
                <td> <asp:Label ID="IdProjectName" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
               <td> <asp:Label ID="LCreator" runat="server" Text="Project Creator"></asp:Label></td>
                <td> <asp:Label ID="IdProjectCreator" runat="server" Text=""></asp:Label></td>
            </tr>
               <tr>
               <td> <asp:Label ID="LCreatedAt" runat="server" Text="Project Created At"></asp:Label></td>
                <td> <asp:Label ID="IdProjectCreatedAt" runat="server" Text=""></asp:Label></td>
            </tr>
               <tr>
               <td> <asp:Label ID="LModifier" runat="server" Text="Project Modifier"></asp:Label></td>
                <td> <asp:Label ID="IdProjectModifier" runat="server" Text=""></asp:Label></td>
            </tr>
               <tr>
               <td> <asp:Label ID="LModifierAt" runat="server" Text="Project Modifier At"></asp:Label></td>
                <td> <asp:Label ID="IdProjectModifierAt" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
        </div>
         
        
    </form>
    
</body>
</html>
