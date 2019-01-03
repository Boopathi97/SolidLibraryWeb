using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MethodsMenuPage : System.Web.UI.Page
{
    string UserName, Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        UserName = Session["UserName"].ToString();
        Id = Session["UserId"].ToString();
        IdUserName.Text = UserName;
        IdUserId.Text = Id;

    }

    protected void IdMethodView_Click(object sender, EventArgs e)
    {
        Response.Redirect("MethodsViewPage.aspx");
    }

    protected void IdMethodAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("MethodsAddPage.aspx");
    }
}