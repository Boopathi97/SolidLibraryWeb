<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerAddPage.aspx.cs" Inherits="CustomerAddPage" %>

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
                    <td> <asp:Label ID="LabelCustomerName" runat="server" Text="Enter The Customer Name"></asp:Label></td>
                    <td> <asp:TextBox ID="TextBoxCustomerName" runat="server"></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td> <asp:Label ID="SelectProjectName" runat="server" Text="Select The Project Name"></asp:Label></td>
                    <td>  <asp:DropDownList ID="DropDownListProjectName" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="DropDownListProjectName_SelectedIndexChanged" >
                       
                        </asp:DropDownList></td>
                   
                </tr>
                <tr>
                    <td> &nbsp;</td>
                    <td> <asp:Button ID="AddCustomerSubmit" runat="server" Text="Add Customer" OnClick="AddCustomerSubmit_Click" /></td>
                   
                   
                </tr>
                
            </table>
        </div> <br /><br /><br />
    </form>
</body>
</html>
