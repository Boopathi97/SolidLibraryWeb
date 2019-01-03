using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SolidLibiaryDataLayer;
using SolidLibiary;
using ConnectionDatabase;

public partial class CustomerManuPage : System.Web.UI.Page
{
    string UserName;
    Guid Id;
    ConnectionClass ObjConetion = new ConnectionClass();
    protected void Page_Load(object sender, EventArgs e)
    {

        UserName = Session["UserName"].ToString();
        Id = Guid.Parse(Session["UserId"].ToString());
        IdUserName.Text = UserName;
        IdUserId.Text = Id.ToString();
    }

    protected void IdCustomerAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerAddPage.aspx");
    }

    protected void IdCustomertView_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerViewPage.aspx");
    }
}