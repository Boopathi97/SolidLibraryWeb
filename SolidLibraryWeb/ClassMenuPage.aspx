<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClassMenuPage.aspx.cs" Inherits="ClassMenuPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet">
    
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

<script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
<script src="https://cdn.datatables.net/1.10.16/js/dataTables.bootstrap4.min.js"></script>
    <style type="text/css">
        #GridViewClass_filter.dataTables_filter
        {
                text-align: -webkit-right;
        }
    </style>
    <script type="text/javascript">
        $(document).ready(function() {
    $('#GridViewClass').DataTable(
        
         {     

      "aLengthMenu": [[3, 5, 10, 25, -1], [3, 5, 10, 25, "All"]],
        "iDisplayLength": 3
       } 
        );
} );
    </script>
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
             <asp:Label style="  margin-left: 550px; " ID="Msg" runat="server" ForeColor="#33CC33"></asp:Label>
            <table style="width: 50%;    margin-left: 400px;">
                <tr>
                     <td>  <asp:Button ID="IdClassAdd" runat="server" Text="Add Class" OnClick="IdClassAdd_Click" /></td>
                </tr>
            </table>
        </div>
        <div>
            <asp:GridView ID="GridViewClass" runat="server" 
                 OnSelectedIndexChanging="GridViewClass_SelectedIndexChanging"
                 OnRowDeleting="GridViewClass_RowDeleting"
                class="table table-striped table-bordered"
                >
                <columns>
                
                      <asp:buttonfield buttontype="Button" 
                        commandname="select"
                        headertext="Action" 
                        text="Edit"/>
                     <asp:buttonfield buttontype="Button" 
                        commandname="delete"
                        headertext="Action" 
                        text="Delete"/>
                    
                    
                
                 </columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
