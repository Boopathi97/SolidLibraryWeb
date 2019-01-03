using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManuPage : System.Web.UI.Page
{
    string UserName, Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        UserName = Session["UserName"].ToString();
        Id = Session["UserId"].ToString();
        IdUserName.Text = UserName;
        IdUserId.Text = Id;

    }

    protected void IdProject_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProjectManuPage.aspx");

    }

    protected void IdCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerManuPage.aspx");
    }
    protected void IdMethods_Click(object sender, EventArgs e)
    {
        Response.Redirect("MethodsMenuPage.aspx");
    }

    protected void IdClass_Click(object sender, EventArgs e)
    {
        Response.Redirect("ClassMenuPage.aspx");
    }
}