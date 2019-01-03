﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProjectViewPage.aspx.cs" Inherits="ProjectViewPage" %>

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
        #GridPageView_filter.dataTables_filter
        {
                text-align: -webkit-right;
        }
    </style>
    <script type="text/javascript">
        $(document).ready(function() {
    $('#GridPageView').DataTable(
        
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
            <asp:GridView ID="GridPageView" runat="server"  
                   OnSelectedIndexChanging ="GridPageView_SelectedIndexChanged"  
                  OnRowDeleting="GridPageView_RowDeleting"
                 
                    
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
        <div>
            <asp:Button ID="ProjectBack" runat="server" Text="ManuPage" OnClick="ProjectBack_Click" />
        </div>
    </form>
</body>
</html>
