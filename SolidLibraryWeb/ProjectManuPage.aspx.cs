using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProjectPage : System.Web.UI.Page
{
    string UserName, Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        UserName = Session["UserName"].ToString();
        Id = Session["UserId"].ToString();
        IdUserName.Text = UserName;
        IdUserId.Text = Id;

    }

    protected void IdProjectAdd_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("ProjectAddPage.aspx");
    }

    protected void IdProjectView_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProjectViewPage.aspx");
    }
}